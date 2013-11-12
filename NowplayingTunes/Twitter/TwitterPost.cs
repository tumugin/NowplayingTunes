using System;
using System.Collections.Generic;
using System.Compat.Web;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TweetSharp;

namespace NowplayingTunes.Twitter
{
    public class TwitterPost
    {
        public Core.iTunesClass Song;
        public String TweetText;
        public List<Core.ApplicationSetting.AccountClass> AccountList = new List<Core.ApplicationSetting.AccountClass>();
        public bool AutoDeleteText = false;
        //処理完了イベント
        public delegate void onProcessFinishedHandler(List<TwitterService> response);
        public event onProcessFinishedHandler onProcessFinished;

        public void TweetWithImage()
        {
            try
            {
                //ステータスリスト
                List<TwitterService> ResponseList = new List<TwitterService>();

                //各アカウントでつぶやく
                foreach (Core.ApplicationSetting.AccountClass account in AccountList)
                {
                    //ファイルのストリームを取得
                    System.IO.Stream stream = Song.getAlbumArtworkFileStream();
                    TwitterService service = new TwitterService(Core.Twitter.CONSUMERKEY, Core.Twitter.CONSUMERSECRET);
                    service.AuthenticateWith(account.Token, account.TokenSecret);
                    SendTweetWithMediaOptions opt = new SendTweetWithMediaOptions();
                    opt.Status = Core.Replace.ReplaceText(TweetText, Song); // ツイートする内容
                    //テキストを自動的に削るやつ
                    if (AutoDeleteText == true && opt.Status.Length > 117)
                    {
                        opt.Status = opt.Status.Remove(114);//...の三文字分含めて削除
                        opt.Status += "...";
                    }
                    //opt.Status = HttpUtility.UrlEncode(opt.Status);
                    opt.Images = new Dictionary<string, System.IO.Stream> { { "image", stream } };
                    service.SendTweetWithMedia(opt);
                    ResponseList.Add(service);
                    stream.Close();
                    stream.Dispose();
                }
                //完了イベントを投げる
                onProcessFinished(ResponseList);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("[TwitterPost ERROR]" + ex.ToString());
            }
        }

        public void Tweet()
        {
            //ステータスリスト
            List<TwitterService> ResponseList = new List<TwitterService>();
            //各アカウントでつぶやく
            foreach (Core.ApplicationSetting.AccountClass account in AccountList)
            {
                TwitterService service = new TwitterService(Core.Twitter.CONSUMERKEY, Core.Twitter.CONSUMERSECRET);
                service.AuthenticateWith(account.Token, account.TokenSecret);
                SendTweetOptions opt = new SendTweetOptions();
                opt.Status = Core.Replace.ReplaceText(TweetText, Song); // ツイートする内容
                //テキストを自動的に削るやつ
                if (AutoDeleteText == true && opt.Status.Length > 140)
                {
                    opt.Status = opt.Status.Remove(137);//...の三文字分含めて削除
                    opt.Status += "...";
                }
                service.SendTweet(opt);
                ResponseList.Add(service);
            }
            //完了イベントを投げる
            onProcessFinished(ResponseList);
        }
    }
}

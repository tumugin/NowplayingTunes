using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NowplayingTunes.Core
{
    public class ApplicationSetting
    {
        //設定のシリアライズデシリアライズ用クラス
        public class SettingClass
        {
            public String TweetText = "NowPlaying $TITLE - $ARTIST(Album:$ALBUMNAME) #nowplaying #なうぷれ";
            public bool EnableAutoPost = false;
            public bool EnablePostWait = false;
            public int WaitSecond = 30;
            public bool EnableCheckAlbum = false;
            public bool EnableCheckTime = false;
            public int WaitSecond2 = 60;
            public bool CheckUpdate = true;
            public bool NotifyUpdate = true;
            public bool PostAlbumArtWork = false;
            public bool DeleteText140 = false;
            public List<AccountClass> AccountList = new List<AccountClass>();
        }
        public class AccountClass
        {
            public String Token;
            public String TokenSecret;
            public String AccountName;
            public bool Enabled;
        }
    }
}

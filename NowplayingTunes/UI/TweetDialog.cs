using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TweetSharp;

namespace NowplayingTunes.UI
{
    public partial class TweetDialog : Form
    {
        public Core.iTunesClass song;
        public String replacetext;

        public TweetDialog()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Height = 440;
        }

        private void TweetDialog_Load(object sender, EventArgs e)
        {
            if (song != null)
            {
                textBox1.Text = Core.Replace.ReplaceText(replacetext, song);
                int lenth = 140 - textBox1.Text.Length;
                TweetDigit.Text = lenth.ToString();
                this.FormClosed += TweetDialog_FormClosed;
            }
            else
            {
                MessageBox.Show("再生されている曲がありません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        void TweetDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //アカウントのリストを作成する
                List<Core.ApplicationSetting.AccountClass> acclist = new List<Core.ApplicationSetting.AccountClass>();
                foreach (ListViewItem listviewitem in AccountList.CheckedItems)
                {
                    Core.ApplicationSetting.AccountClass account = new Core.ApplicationSetting.AccountClass();
                    account.AccountName = listviewitem.Text;
                    account.Token = listviewitem.SubItems[1].Text;
                    account.TokenSecret = listviewitem.SubItems[2].Text;
                    account.Enabled = true;
                    acclist.Add(account);
                }

                //バックグラウンドで実行する
                Twitter.TwitterPost twitterpost = new Twitter.TwitterPost();
                twitterpost.isCustomTweet = true;
                twitterpost.AccountList = acclist;
                twitterpost.Song = song;
                twitterpost.TweetText = textBox1.Text;
                twitterpost.onProcessFinished += twitterpost_onProcessFinished;
                if (EnableAlbumArtTweet.Checked == true && song.getAlbumArtworkFileStream() != null)
                {
                    Thread thread = new Thread(twitterpost.TweetWithImage);
                    thread.IsBackground = true;
                    thread.Start();
                }
                else
                {
                    Thread thread = new Thread(twitterpost.Tweet);
                    thread.IsBackground = true;
                    thread.Start();
                }
                this.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        delegate void CloseDialogDelegate();
        delegate void ShowDialogInvoke(String text);
        internal void ShowDialog(String text)
        {
            MessageBox.Show(text, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Enabled = true;
        }

        void twitterpost_onProcessFinished(List<TwitterService> response)
        {
            int errorcount = 0;
            foreach (TwitterService service in response)
            {
                if (service.Response.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    //エラーの場合はエラーメッセージを表示する
                    this.Invoke(new ShowDialogInvoke(ShowDialog), service.Response.Error.ToString());
                    errorcount += 1;
                }
            }
            if (errorcount == 0)
            {
                //エラーが一度も起こって無ければダイアログを閉じる
                this.Invoke(new CloseDialogDelegate(this.Close));
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int lenth = 140 - textBox1.Text.Length;
            TweetDigit.Text = lenth.ToString();
            if (lenth <= -1)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void KezuruButton_Click(object sender, EventArgs e)
        {
            if (EnableAlbumArtTweet.Checked && textBox1.Text.Length >= 114)
            {
                textBox1.Text =  textBox1.Text.Remove(114);
                textBox1.Text += "...";
            }
            else
            {
                if (textBox1.Text.Length >= 137)
                {
                    textBox1.Text = textBox1.Text.Remove(137);
                    textBox1.Text += "...";
                }
            }
        }
    }
}

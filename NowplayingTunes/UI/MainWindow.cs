using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NowplayingTunes.Core;
using System.Diagnostics;
using TweetSharp;
using System.Threading;

namespace NowplayingTunes
{
    public partial class MainWindow : Form
    {
        public iTunes.LinkToiTunes itunes;
        public Core.SongManagement songmanage;
        public Plugin.PluginSystem plugin;
        UpdateChecker.Updater updater;

        public MainWindow()
        {
            InitializeComponent();
        }

        //クラスからUIに設定を復元する
        void PutSettingToUI(Core.ApplicationSetting.SettingClass set)
        {
            TextBoxTweetText.Text = set.TweetText;
            CheckBoxEnableAutoPost.Checked = set.EnableAutoPost;
            CheckBoxEnablePostWait.Checked = set.EnablePostWait;
            CheckBoxEnableCheckAlbum.Checked = set.EnableCheckAlbum;
            CheckBoxCheckTime.Checked = set.EnableCheckTime;
            checkBoxPostAlbumArtWork.Checked = set.PostAlbumArtWork;
            CheckUpdate.Checked = set.CheckUpdate;
            CheckBoxDeleteText140.Checked = set.DeleteText140;
            CheckBoxExitWithiTunes.Checked = set.ExitWithiTunes;
            NotifyUpdate.Checked = set.NotifyUpdate;
            numericUpDownWaitSecond.Value = set.WaitSecond;
            numericUpDownWaitSecond2.Value = set.WaitSecond2;
            foreach (Core.ApplicationSetting.AccountClass account in set.AccountList)
            {
                ListViewItem item = AccountList.Items.Add(account.AccountName);
                item.SubItems.Add(account.Token);
                item.SubItems.Add(account.TokenSecret);
                item.Checked = account.Enabled;
            }
            if (CheckBoxEnableAutoPost.Checked == true)
            {
                AutoPostONOFFToolStripMenuItem.Text = "自動投稿を無効にする";
            }
            else
            {
                AutoPostONOFFToolStripMenuItem.Text = "自動投稿を有効にする";
            }
        }

        //UIからクラスに代入する
        Core.ApplicationSetting.SettingClass PutSettingToClass()
        {
            Core.ApplicationSetting.SettingClass set = new Core.ApplicationSetting.SettingClass();
            set.TweetText = TextBoxTweetText.Text;
            set.EnableAutoPost = CheckBoxEnableAutoPost.Checked;
            set.EnablePostWait = CheckBoxEnablePostWait.Checked;
            set.EnableCheckAlbum = CheckBoxEnableCheckAlbum.Checked;
            set.EnableCheckTime = CheckBoxCheckTime.Checked;
            set.PostAlbumArtWork = checkBoxPostAlbumArtWork.Checked;
            set.CheckUpdate = CheckUpdate.Checked;
            set.NotifyUpdate = NotifyUpdate.Checked;
            set.WaitSecond = (int)numericUpDownWaitSecond.Value;
            set.WaitSecond2 = (int)numericUpDownWaitSecond2.Value;
            set.DeleteText140 = CheckBoxDeleteText140.Checked;
            set.ExitWithiTunes = CheckBoxExitWithiTunes.Checked;
            foreach (ListViewItem item in AccountList.Items)
            {
                Core.ApplicationSetting.AccountClass account = new Core.ApplicationSetting.AccountClass();
                account.AccountName = item.Text;
                account.Token = item.SubItems[1].Text;
                account.TokenSecret = item.SubItems[2].Text;
                account.Enabled = item.Checked;
                set.AccountList.Add(account);
            }
            return set;
        }

        void initiTunes(Core.ApplicationSetting.SettingClass set)
        {
            //iTunesと連携する
            if (itunes == null && songmanage == null)
            {
                itunes = new iTunes.LinkToiTunes();
                songmanage = new Core.SongManagement(itunes);
            }
            //イベントハンドラを登録
            songmanage.OnSongChangedEvent -= songmanage_OnSongChangedEvent;
            songmanage.OnSongChangedEvent += songmanage_OnSongChangedEvent;
            itunes.OniTunesStartExit -= itunes_OniTunesStartExit;
            itunes.OniTunesStartExit += itunes_OniTunesStartExit;
            //イベント発生条件を登録
            songmanage.EventSetting.EnableAutoPost = set.EnableAutoPost;
            songmanage.EventSetting.CheckIsAlbumChanged = set.EnableCheckAlbum;
            songmanage.EventSetting.CheckIsTimeElapsedFromLastTweet = set.EnableCheckTime;
            songmanage.EventSetting.EnableLateTweet = set.EnablePostWait;
            songmanage.EventSetting.LateTweetSeconds = set.WaitSecond;
            songmanage.EventSetting.TimeElapsedFromLastTweetSec = set.WaitSecond2;
        }

        void itunes_OniTunesStartExit(bool status)
        {
            if (status == true)
            {
                //notifyIcon1.Icon = NowplayingTunes.Properties.Resources.NP_Icon_Enabled;
            }
            else
            {
                //notifyIcon1.Icon = NowplayingTunes.Properties.Resources.NP_Icon_Disabled;
                //iTunesと同時に終了する設定ならば
                if (CheckBoxExitWithiTunes.Checked == true)
                {
                    Application.Exit();
                }
            }
        }

        private void ButtonBasicSettings_Click(object sender, EventArgs e)
        {
            SettingPanelTabControl.SelectedIndex = 0;
        }

        private void ButtonAutoPostSettings_Click(object sender, EventArgs e)
        {
            SettingPanelTabControl.SelectedIndex = 1;
        }

        private void ButtonUpdateSettings_Click(object sender, EventArgs e)
        {
            SettingPanelTabControl.SelectedIndex = 2;
        }

        private void ButtonDebugSettings_Click(object sender, EventArgs e)
        {
            SettingPanelTabControl.SelectedIndex = 3;
        }

        private void ButtonVesionInfo_Click(object sender, EventArgs e)
        {
            SettingPanelTabControl.SelectedIndex = 4;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            //デバッガの準備
            Core.Debugger.TextBoxTraceListener tbtl = new Core.Debugger.TextBoxTraceListener(DebugTextBox);
            //Debug.Listeners.Add(tbtl);
            Trace.Listeners.Add(tbtl);

            //tmpフォルダの作成
            if (System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\tmp\") == false)
            {
                System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\tmp\");
            }

            //設定を読み出す
            Core.ApplicationSetting.SettingClass set;
            if(System.IO.File.Exists(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\setting.xml"))
            {
                //XmlSerializerオブジェクトを作成
                System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(Core.ApplicationSetting.SettingClass));
                //読み込むファイルを開く
                System.IO.FileStream fs = new System.IO.FileStream(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\setting.xml", System.IO.FileMode.Open);
                //XMLファイルから読み込み、逆シリアル化する
                set = (Core.ApplicationSetting.SettingClass) serializer.Deserialize(fs);
                //ファイルを閉じる
                fs.Close();
                //初回起動ではないのでフォーム非表示
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                set = new Core.ApplicationSetting.SettingClass();
            }
            
            //初期化処理
            PutSettingToUI(set);
            initiTunes(set);
            //プラグインシステムの初期化
            plugin = new Plugin.PluginSystem(songmanage);
            plugin.StartThread();

            this.FormClosing += MainWindow_Closing;
            this.Shown += MainWindow_Shown;
            CheckForIllegalCrossThreadCalls = false;
            
            //更新の確認をする
            if (set.CheckUpdate == true)
            {
                updater = new UpdateChecker.Updater();
                updater.CheckUpdateFinished += updater_CheckUpdateFinished;
                Thread UpdaterThread = new Thread(updater.CheckUpdate);
                UpdaterThread.IsBackground = true;
                UpdaterThread.Start();
            }
        }

        void updater_CheckUpdateFinished(Version ver, string Updatetext, string UpdateURL)
        {
            //自分自身のAssemblyを取得
            System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
            //バージョンの取得
            System.Version myver = asm.GetName().Version;
            if (myver < ver)
            {
                //最新版が出ている場合はアップデートを促す
                NewVersionToolStripMenuItem.Enabled = true;
                NewVersionToolStripMenuItem.Text = "新しいバージョンが利用可能です";
                NewVersionToolStripMenuItem.ForeColor = Color.Red;
                //必要に応じて通知も出す
                if (NotifyUpdate.Checked == true)
                {
                    notifyIcon1.ShowBalloonTip(10000, "アップデートのお知らせ", Updatetext, ToolTipIcon.Info);
                }
            }
            else
            {
                NewVersionToolStripMenuItem.Text = "お使いのバージョンは最新版です";
            }
        }

        void MainWindow_Shown(object sender, EventArgs e)
        {
            //フォームを隠す
            if (System.IO.File.Exists(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\setting.xml"))
            {
                this.Hide();
            }
        }

        private void MainWindow_Closing(object sender, FormClosingEventArgs e)
        {
            //アプリケーションを終了しないようにする
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
            CloseAndSave();
        }

        void CloseAndSave()
        {
            //フォームが閉じるときに設定を保存する
            try
            {
                //設定を取得
                Core.ApplicationSetting.SettingClass set = PutSettingToClass();
                //設定を代入
                initiTunes(set);
                //クラスをシリアライズ
                String XmlPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\setting.xml";
                System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(Core.ApplicationSetting.SettingClass));
                System.IO.FileStream fs = new System.IO.FileStream(XmlPath, System.IO.FileMode.Create);
                serializer.Serialize(fs, set);
                fs.Close();
            }
            catch (Exception ex)
            {
                Debug.Write(ex.ToString());
            }
        }

        void songmanage_OnSongChangedEvent(iTunesClass song)
        {
            try
            {
                Trace.WriteLine("[Event OnSongChangedEvent MainWindow]" + "Title:" + song.SongTitle + ",Artist:" + song.SongArtist);
                Trace.WriteLine("[Event 自動投稿 MainWindow]" + "Sending tweet...");

                //曲が再生されているか確認する
                if(itunes.checkIsPlaying() == false)
                {
                    Trace.WriteLine("[Event 自動投稿 MainWindow]" + "Not playing... exit thread.");
                    return;
                }

                //アカウントのリストを作成する
                List<Core.ApplicationSetting.AccountClass> acclist = new List<ApplicationSetting.AccountClass>();
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
                twitterpost.AccountList = acclist;
                twitterpost.Song = song;
                twitterpost.TweetText = TextBoxTweetText.Text;
                twitterpost.AutoDeleteText = CheckBoxDeleteText140.Checked;
                twitterpost.onProcessFinished += twitterpost_onProcessFinished;
                if (checkBoxPostAlbumArtWork.Checked == true && song.getAlbumArtworkFileStream() != null)
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

                Trace.WriteLine("[Event 自動投稿 MainWindow]" + "Tweet send thread start...");
            }
            catch (Exception ex)
            {
                Debug.Write(ex.ToString());
            }
        }

        private void ButtonSelectedDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in AccountList.SelectedItems)
            {
                item.Remove();
            }
        }

        private void ButtonAccountAdd_Click(object sender, EventArgs e)
        {
            AddAccount dialog = new AddAccount();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //UIの方に適用
                ListViewItem item = AccountList.Items.Add(dialog.access.ScreenName);
                item.SubItems.Add(dialog.access.Token);
                item.SubItems.Add(dialog.access.TokenSecret);
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            カスタム投稿TToolStripMenuItem_Click(sender, e);
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        private void カスタム投稿TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //待機中のツイートを全てキャンセル
            songmanage.StopAllWaitingEvent();

            UI.TweetDialog dialog = new UI.TweetDialog();
            dialog.song = songmanage.getLatestSong();
            dialog.replacetext = TextBoxTweetText.Text;
            foreach (ListViewItem item in AccountList.Items)
            {
                dialog.AccountList.Items.Add((ListViewItem)item.Clone());
            }
            dialog.ShowDialog();
            dialog.Dispose();
        }

        private void 今すぐツイートToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //待機中のツイートを全てキャンセル
                songmanage.StopAllWaitingEvent();
                Trace.WriteLine("[Event 今すぐツイート MainWindow]" + "Stopped all waiting event.");

                Core.iTunesClass song = songmanage.getLatestSong();
                if (song == null)
                {
                    MessageBox.Show("再生されている曲がありません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Trace.WriteLine("[Event 今すぐツイート MainWindow]" + "Sending tweet...");

                //アカウントのリストを作成する
                List<Core.ApplicationSetting.AccountClass> acclist = new List<ApplicationSetting.AccountClass>();
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
                twitterpost.AccountList = acclist;
                twitterpost.Song = song;
                twitterpost.TweetText = TextBoxTweetText.Text;
                twitterpost.AutoDeleteText = CheckBoxDeleteText140.Checked;
                twitterpost.onProcessFinished += twitterpost_onProcessFinished;
                if (checkBoxPostAlbumArtWork.Checked == true && song.getAlbumArtworkFileStream() != null)
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

                Trace.WriteLine("[Event 今すぐツイート MainWindow]" + "Tweet process started!");
            }
            catch (Exception ex)
            {
                Debug.Write(ex.ToString());
            }
        }

        void twitterpost_onProcessFinished(List<TwitterService> response)
        {
            //ツイート完了時のイベント
            Trace.WriteLine("[Event TwitterPostProcessFinished MainWindow]" + "Send completed.");
            foreach (TwitterService service in response)
            {
                if (service.Response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    //返り値が200だった場合は
                    Trace.WriteLine("[Event TwitterPostProcessFinished MainWindow]" + "Send OK!");
                }
                else
                {
                    //エラーの場合はエラーメッセージを表示する
                    Trace.WriteLine("[ERROR TwitterPostProcessFinished MainWindow]" + service.Response.Error);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://www.jisakuroom.net/blog/");
        }

        private void NewVersionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(updater.UpdateURL);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UI.ReplaceTextList dialog = new UI.ReplaceTextList();
            dialog.Show();
        }

        private void CheckBoxEnableAutoPost_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxEnableAutoPost.Checked == true)
            {
                AutoPostONOFFToolStripMenuItem.Text = "自動投稿を無効にする";
            }
            else
            {
                AutoPostONOFFToolStripMenuItem.Text = "自動投稿を有効にする";
            }
        }

        private void AutoPostONOFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckBoxEnableAutoPost.Checked == true)
            {
                CheckBoxEnableAutoPost.Checked = false;
            }
            else
            {
                CheckBoxEnableAutoPost.Checked = true;
            }
            CloseAndSave();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading;


namespace NowplayingTunes.Plugin
{
    public class PluginSystem
    {
        List<Thread> Threadlist = new List<Thread> { };
        Core.SongManagement Song;

        /*initialize*/
        public PluginSystem(Core.SongManagement songmng)
        {
            Song = songmng;
        }

        public void StartThread()
        {
            Thread thread = new Thread(PipeThread);
            Threadlist.Add(thread);
            thread.IsBackground = true;
            thread.Start();
        }

        public void Dispose()
        {
            foreach (Thread thread in Threadlist)
            {
                if (thread != null && thread.IsAlive == true)
                {
                    thread.Abort();
                }
            }
        }

        //UIと他の実装の分離化が出来ていないための暫定的な実装です
        String getTweetText()
        {
            //設定を読み出す
            Core.ApplicationSetting.SettingClass set;
            if (System.IO.File.Exists(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\setting.xml"))
            {
                //XmlSerializerオブジェクトを作成
                System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(Core.ApplicationSetting.SettingClass));
                //読み込むファイルを開く
                System.IO.FileStream fs = new System.IO.FileStream(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\setting.xml", System.IO.FileMode.Open);
                //XMLファイルから読み込み、逆シリアル化する
                set = (Core.ApplicationSetting.SettingClass)serializer.Deserialize(fs);
                //ファイルを閉じる
                fs.Close();
            }
            else
            {
                set = new Core.ApplicationSetting.SettingClass();
            }
            return set.TweetText;
        }

        void PipeThread()
        {
            NamedPipeServerStream pipeServer = null;
            try
            {
                pipeServer = new NamedPipeServerStream("NowPlayingTunes", PipeDirection.InOut);
                StreamString stream = new StreamString(pipeServer);
                pipeServer.WaitForConnection();
                //When Connected
                if (Song.getLatestSong() != null)
                {
                    String TweetText = getTweetText();
                    Core.iTunesClass latestsong = Song.getLatestSong();
                    String sendtext = Core.Replace.ReplaceText(TweetText, latestsong);
                    stream.WriteString(sendtext);
                }
                pipeServer.Close();
                pipeServer.Dispose();
            }
            catch (Exception ex)
            {
                Debug.WriteLine("[PluginSystem] ERROR");
                Debug.WriteLine(ex.ToString());
            }
            finally
            {
                if (pipeServer != null)
                {
                    if (pipeServer.IsConnected)
                    {
                        pipeServer.Dispose();
                    }
                }
            }
            //Remake thread
            StartThread();
        }
    }
}

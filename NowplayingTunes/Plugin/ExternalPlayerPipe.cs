using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading;

namespace NowplayingTunes.Plugin
{
    public class ExternalPlayerPipe
    {
        List<Thread> Threadlist = new List<Thread> { };
        //イベントハンドラ
        public delegate void onSongChanged(Core.iTunesClass song);
        public event onSongChanged onSongChangedEvent;

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

        public void StartThread()
        {
            Thread thread = new Thread(PipeThread);
            Threadlist.Add(thread);
            thread.IsBackground = true;
            thread.Start();
        }

        void PipeThread()
        {
            NamedPipeServerStream pipeServer = null;
            try
            {
                pipeServer = new NamedPipeServerStream("NowPlayingtunesSongPipe", PipeDirection.InOut);
                pipeServer.WaitForConnection();
                //When Connected
                StreamString stream = new StreamString(pipeServer);
                String playerStr = stream.ReadString();
                Debug.WriteLine("[foobar2000]Song changed.");
                Debug.WriteLine(playerStr);
                Debug.WriteLine("[foobar2000]dump end.");
                String[] playerStrSplit = playerStr.Split('\n');
                Core.iTunesClass song = new Core.iTunesClass();
                song.AlbumArtworkEnabled = false;
                song.SongTitle = playerStrSplit[0];
                song.SongAlbum = playerStrSplit[1];
                song.SongArtist = playerStrSplit[2];
                song.SongAlbumArtist = playerStrSplit[3];
                song.isFoobar = true;
                try
                {
                    song.SongTrackNumber = int.Parse(playerStrSplit[4]);
                }
                catch (Exception ex2)
                {
                }
                song.SongGenre = playerStrSplit[5];
                song.SongComposer = playerStrSplit[6];

                pipeServer.Close();
                pipeServer.Dispose();
                //適当にイベント発生させる
                onSongChangedEvent(song);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("[foobar2000] ERROR");
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

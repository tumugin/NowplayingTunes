using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTunesLib;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;

namespace NowplayingTunes.iTunes
{
    public class LinkToiTunes
    {
        //イベント
        public delegate void OnPlayerPlayEventHandler(Core.iTunesClass song);
        public event OnPlayerPlayEventHandler OnPlayerPlayEvent;
        public delegate void OniTunesStartExitHandler(bool status);
        public event OniTunesStartExitHandler OniTunesStartExit = delegate { };

        iTunesApp iTunes;
        Core.iTunesClass LastSong = new Core.iTunesClass();

        public LinkToiTunes()
        {
            if (Process.GetProcessesByName("itunes").Count() != 0)
            {
                //プロセスがあればiTunesと接続する
                iTunes = new iTunesAppClass();
                iTunes.OnPlayerPlayEvent += iTunes_OnPlayerPlayEvent;
                //試しに変更
                iTunes.OnQuittingEvent += iTunes_OnAboutToPromptUserToQuitEvent;
                OniTunesStartExit(true);
                Trace.WriteLine("[Event init LinkToiTunes] Connect to iTunes OK!");
            }
            else
            {
                //監視用スレッドを回す
                StartChecker();
            }
        }

        //監視スレッド起動
        void StartChecker()
        {
            Trace.WriteLine("[Event StartChecker LinkToiTunes] Starting itunes watcher...");
            Thread thread = new Thread(CheckiTunesProcess);
            thread.IsBackground = true;
            thread.Start();
        }

        //iTunes起動監視
        void CheckiTunesProcess()
        {
            //無限ループ
            while (true)
            {
                if (Process.GetProcessesByName("itunes").Count() != 0)
                {
                    //iTunesとリンクさせる
                    iTunes = new iTunesAppClass();
                    iTunes.OnPlayerPlayEvent += iTunes_OnPlayerPlayEvent;
                    iTunes.OnAboutToPromptUserToQuitEvent += iTunes_OnAboutToPromptUserToQuitEvent;
                    Trace.WriteLine("[Event CheckiTunesProcess LinkToiTunes] iTunes link OK!");
                    OniTunesStartExit(true);
                    break;
                }
                else
                {
                    System.Threading.Thread.Sleep(1000);//一応1秒間待つ(負荷軽減の為)
                }
            }
        }

        //iTunesが無事に終了するまで待つスレッド
        void WaitUntilItunesEnd() 
        {
            while (true)
            {
                if (Process.GetProcessesByName("itunes").Count() == 0)
                {
                    //無事に終了する
                    Trace.WriteLine("[Event WaitUntilItunesEnd LinkToiTunes] iTunes stop OK! Starting itunes watcher...");
                    StartChecker();
                    break;
                }
            }
        }

        //iTunes終了イベント
        void iTunes_OnAboutToPromptUserToQuitEvent()
        {
            Dispose();
        }

        //iTunesの曲変更イベント
        void iTunes_OnPlayerPlayEvent(object iTrack)
        {
            Core.iTunesClass song = new Core.iTunesClass(iTunes.CurrentTrack);
            //曲が変更された時だけイベントを取るから前回と比較する
            if (song.TrackDatabaseID != LastSong.TrackDatabaseID)
            {
                LastSong = song;
                OnPlayerPlayEvent(song);
            }
        }

        //曲が再生されているか確認する
        public bool checkIsPlaying()
        {
            if (iTunes == null) return true;
            if(iTunes.PlayerState == ITPlayerState.ITPlayerStatePlaying)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Dispose()
        {
            Marshal.FinalReleaseComObject(iTunes);
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
            System.GC.Collect();
            //iTunesの終了を待つスレッドを起動
            Trace.WriteLine("[Event iTunesDispose LinkToiTunes] Starting iTunes stop watcher...");
            Thread thread = new Thread(WaitUntilItunesEnd);
            thread.IsBackground = true;
            thread.Start();
            OniTunesStartExit(false);
        }
    }
}

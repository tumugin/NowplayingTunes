using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NowplayingTunes.Core
{
    public class SongManagement
    {
        //イベントハンドラ
        public delegate void OnSongChangedEventHandler(Core.iTunesClass song);
        public event OnSongChangedEventHandler OnSongChangedEvent;
        //設定用変数
        public EventSettingClass EventSetting = new EventSettingClass();
        //履歴保存用変数
        public List<Core.iTunesClass> SongList = new List<iTunesClass>();
        //イベント発生履歴保存用変数
        public List<IventHistory> IventHistoryList = new List<IventHistory>();
        //Thread保管用リスト
        List<Thread> ThreadList = new List<Thread>();
        //iTunesクラス
        iTunes.LinkToiTunes itunesclass;
        //設定用クラス
        public class EventSettingClass
        {
            public bool EnableAutoPost = false;
            public bool CheckIsAlbumChanged = false;
            public bool EnableLateTweet = false;
            public int LateTweetSeconds = 60;
            public bool CheckIsTimeElapsedFromLastTweet = false;
            public int TimeElapsedFromLastTweetSec = 60;
        }
        //イベント発生履歴保存用クラス
        public class IventHistory
        {
            public IventHistory(iTunesClass sng, DateTime dt)
            {
                Song = sng;
                Time = dt;
            }
            public iTunesClass Song;
            public DateTime Time;
        }

        public SongManagement(iTunes.LinkToiTunes ev)
        {
            ev.OnPlayerPlayEvent += ev_OnPlayerPlayEvent;
            itunesclass = ev;
        }

        void ev_OnPlayerPlayEvent(iTunesClass song)
        {
            //iTunesのスレッドで実行されてるから使う時は必ずスレッドを建てること!!
            Debug.WriteLine("[Event OnPlayerPlayEvent(iTunesThread) SongManagement]" + "Title:" + song.SongTitle + ",Artist:" + song.SongArtist);
            // スレッド開始
            SongChangeEventSenderClass senderclass = new SongChangeEventSenderClass(this);
            senderclass.song = song;
            senderclass.EventSetting = EventSetting;

            Thread thread = new Thread(senderclass.SongChangeEventSender);
            ThreadList.Add(thread);
            thread.IsBackground = true;
            thread.Start();
        }

        public void StopAllWaitingEvent()
        {
            //スレッド保管用リストから読み出し
            foreach (Thread thread in ThreadList)
            {
                //スレッドが生きてるか確認
                if (thread.IsAlive == true)
                {
                    //スレッドを強制終了
                    thread.Abort();
                }
            }
        }

        //最後に再生した曲を返す
        public iTunesClass getLatestSong()
        {
            if (SongList.Count != 0)
            {
                return SongList[SongList.Count - 1];
            }
            else
            {
                return null;
            }
        }

        public void Dispose()
        {
            itunesclass.Dispose();
        }

        class SongChangeEventSenderClass
        {
            public iTunesClass song;
            public EventSettingClass EventSetting;
            SongManagement SongManagementForEventSender;
            public SongChangeEventSenderClass(SongManagement sm)
            {
                SongManagementForEventSender = sm;
            }
            public void SongChangeEventSender()
            {
                try
                {
                    Debug.WriteLine("[Event SongChangeEventSender SongManagement]" + "Title:" + song.SongTitle + ",Artist:" + song.SongArtist);
                    //履歴に保存
                    SongManagementForEventSender.SongList.Add(song);
                    //ここで待機処理とかをする
                    
                    //自動投稿自体ONになっていなければreturn
                    if (EventSetting.EnableAutoPost == false)
                    {
                        return;
                    }

                    //遅れてイベントを発生させるオプション
                    if (EventSetting.EnableLateTweet == true)
                    {
                        //秒からミリ秒に変換
                        //指定秒数待つ
                        Debug.WriteLine("[Event SongChangeEventSender SongManagement]" + "EnableLateTweet=true waiting for " + EventSetting.LateTweetSeconds * 1000 + "msec.");
                        System.Threading.Thread.Sleep(EventSetting.LateTweetSeconds * 1000);
                        //前回と同じ曲かどうか調べる
                        if (SongManagementForEventSender.SongList[SongManagementForEventSender.SongList.Count - 1].TrackDatabaseID != song.TrackDatabaseID)
                        {
                            Debug.WriteLine("[Event SongChangeEventSender SongManagement]" + "Song changed!! Exit thread.");
                            return;
                        }
                    }

                    //アルバムが変わってるか確認するオプション
                    if (EventSetting.CheckIsAlbumChanged == true)
                    {
                        //履歴が2件以上無いと処理出来ないのでチェック
                        if (SongManagementForEventSender.SongList.Count >= 2)
                        {
                            //同じアルバムの場合は処理を抜ける
                            if (SongManagementForEventSender.SongList[SongManagementForEventSender.SongList.Count - 2].SongAlbum == song.SongAlbum)
                            {
                                Debug.WriteLine("[Event SongChangeEventSender SongManagement]" + "Album not changed!! Exit thread.");
                                return;
                            }
                        }
                    }

                    //前回のイベント発生からの経過を見てイベントを発生させるか判定するオプション
                    if (EventSetting.CheckIsTimeElapsedFromLastTweet == true)
                    {
                        //前回のイベント発生を取得
                        if (SongManagementForEventSender.IventHistoryList.Count != 0)
                        {
                            //差を求める
                            IventHistory IvnHistory = SongManagementForEventSender.IventHistoryList[SongManagementForEventSender.IventHistoryList.Count - 1];
                            TimeSpan span = DateTime.Now - IvnHistory.Time;
                            Debug.WriteLine("[Event SongChangeEventSender SongManagement]" + "Time span is " + span.TotalSeconds + "sec.");
                            if (span.TotalSeconds < EventSetting.TimeElapsedFromLastTweetSec)
                            {
                                Debug.WriteLine("[Event SongChangeEventSender SongManagement]" + "Time not elapsed from last event!! Exit thread.");
                                return;
                            }
                        }
                    }

                    //最後にイベントを投げる
                    SongManagementForEventSender.OnSongChangedEvent(song);//イベントを発生させる
                    SongManagementForEventSender.IventHistoryList.Add(new IventHistory(song, DateTime.Now));//履歴を保存
                }
                catch (System.Threading.ThreadAbortException)
                {
                    Debug.WriteLine("[Event SongChangeEventSender SongManagement] Thread Abort signal recived!! Aborting...");
                }
            }
        }
    }
}

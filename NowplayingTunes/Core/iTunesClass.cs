using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace NowplayingTunes.Core
{
    public class iTunesClass
    {
        public String SongTitle; //曲名
        public String SongArtist; //アーティスト名
        public String SongAlbum; //アルバム名
        public int SongPlayedTimes; //再生回数
        public int SongRating; //評価
        public DateTime SongLastPlayed; //最後に再生した日
        public int SongYear; //リリース年
        public String SongGenre; //ジャンル
        public String SongComment; //コメント
        public String SongComposer; //作曲者
        public int SongDiscCount; //ディスク枚数
        public int SongDiscNumber; //ディスク番号
        public int SongTrackNumber; //トラックナンバー
        public String SongAlbumArtist; //アルバムアーティスト
        public int TrackDatabaseID;
        public bool AlbumArtworkEnabled = true; //アルバムアートワークを有効にするかどうか

        public iTunesClass() { }

        public iTunesClass(iTunesLib.IITTrack track)
        {
            try
            {
                //型を変換
                iTunesLib.IITFileOrCDTrack track2 = (iTunesLib.IITFileOrCDTrack)track;

                SongAlbum = track2.Album;
                SongAlbumArtist = track2.AlbumArtist;
                SongArtist = track2.Artist;
                SongComment = track2.Comment;
                SongComposer = track2.Composer;
                SongDiscCount = track2.DiscCount;
                SongDiscNumber = track2.DiscNumber;
                SongGenre = track2.Genre;
                SongLastPlayed = track2.PlayedDate;
                SongPlayedTimes = track2.PlayedCount;
                SongRating = track2.Rating;
                SongTitle = track2.Name;
                SongTrackNumber = track2.TrackNumber;
                SongYear = track2.Year;
                TrackDatabaseID = track2.TrackDatabaseID;
                if (SongAlbumArtist == "" | SongAlbumArtist == null)
                {
                    SongAlbumArtist = SongArtist;
                }
                try
                {
                    track2.Artwork[1].SaveArtworkToFile(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\tmp\" + TrackDatabaseID.ToString() + ".png");
                }
                catch (Exception ex)
                {
                }
                Marshal.FinalReleaseComObject(track2);
            }
            catch (InvalidCastException castex)
            {
                //キャスト出来ない曲(ホームシェアリング等)
                SongAlbum = track.Album;
                SongAlbumArtist = "";
                SongArtist = track.Artist;
                SongComment = track.Comment;
                SongComposer = track.Composer;
                SongDiscCount = track.DiscCount;
                SongDiscNumber = track.DiscNumber;
                SongGenre = track.Genre;
                SongLastPlayed = track.PlayedDate;
                SongPlayedTimes = track.PlayedCount;
                SongRating = track.Rating;
                SongTitle = track.Name;
                SongTrackNumber = track.TrackNumber;
                SongYear = track.Year;
                TrackDatabaseID = track.TrackDatabaseID;
                if (SongAlbumArtist == "" || SongAlbumArtist == null)
                {
                    SongAlbumArtist = SongArtist;
                }
                try
                {
                    track.Artwork[1].SaveArtworkToFile(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\tmp\" + TrackDatabaseID.ToString() + ".png");
                }
                catch (Exception ex)
                {
                }
            }
        }

        public Image getAlbumArtwork()
        {
            try
            {
                String filepath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\tmp\" + TrackDatabaseID.ToString() + ".png";
                System.IO.FileStream fs = new System.IO.FileStream(filepath, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                Image img = Bitmap.FromStream(fs);
                fs.Close();
                return img;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public System.IO.FileStream getAlbumArtworkFileStream()
        {
            try
            {
                String filepath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\tmp\" + TrackDatabaseID.ToString() + ".png";
                System.IO.FileStream fs = new System.IO.FileStream(filepath, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                return fs;

            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}

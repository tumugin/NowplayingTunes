using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NowplayingTunes.Core
{
    public static class Replace
    {
        public static String ReplaceText(string text,iTunesClass song)
        {
            String returnText = text;
            returnText = returnText.Replace("$TITLE", song.SongTitle);
            returnText = returnText.Replace("$ARTIST", song.SongArtist);
            returnText = returnText.Replace("$ALBUMARTIST", song.SongAlbumArtist);
            returnText = returnText.Replace("$ALBUMNAME", song.SongAlbum);
            returnText = returnText.Replace("$COMMENT", song.SongComment);
            returnText = returnText.Replace("$COMPOSER", song.SongComposer);
            returnText = returnText.Replace("$DISCCOUNT", song.SongDiscCount.ToString());
            returnText = returnText.Replace("$DISCNUMBER", song.SongDiscNumber.ToString());
            returnText = returnText.Replace("$GENRE", song.SongGenre);
            returnText = returnText.Replace("$LASTPLAYED", song.SongLastPlayed.ToString("F"));
            returnText = returnText.Replace("$PLAYEDTIMES", song.SongPlayedTimes.ToString());
            returnText = returnText.Replace("$RATING", song.SongRating.ToString());
            returnText = returnText.Replace("$TRACKNUMBER", song.SongTrackNumber.ToString());
            returnText = returnText.Replace("$YEAR", song.SongYear.ToString());
            returnText = returnText.Replace("$NEWLINE", System.Environment.NewLine);
            returnText = returnText.Replace("$GROUP", song.Group);
            return returnText;
        }
    }
}

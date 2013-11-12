using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Xml;

namespace NowplayingTunes.UpdateChecker
{
    public class Updater
    {
        public const String UPDATERURL = "http://www.jisakuroom.net/updateCheck/nowplaying.xml";
        public delegate void CheckUpdateFinishedHandler(Version ver, String Updatetext, String UpdateURL);
        public event CheckUpdateFinishedHandler CheckUpdateFinished;
        public String AppVersionString;
        public String UpdateMessage;
        public String UpdateURL;
        public Version AppVersion;

        public void CheckUpdate()
        {
            try
            {
                //XMLから取得
                XmlDocument doc = new XmlDocument();
                doc.Load(UPDATERURL);
                AppVersionString = doc.SelectSingleNode("app/ver").InnerText;
                UpdateMessage = doc.SelectSingleNode("app/mesg").InnerText;
                UpdateURL = doc.SelectSingleNode("app/url").InnerText;
                //イベントを発生させる
                AppVersion = Version.Parse(AppVersionString);
                CheckUpdateFinished(AppVersion, UpdateMessage, UpdateURL);
            }
            catch (Exception ex)
            {
                Debug.Write(ex.ToString());
            }
        }

    }
}

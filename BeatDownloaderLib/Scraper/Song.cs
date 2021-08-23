using System;
using System.Collections.Generic;
using System.Text;

namespace BeatDownloaderLib.Scraper
{
    public class Song
    {
        public Song(string id)
        {
            this.ID = id;
        }

        public string ID { get; set; }
    }
}

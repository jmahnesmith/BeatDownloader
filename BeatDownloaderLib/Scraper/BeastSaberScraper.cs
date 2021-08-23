using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeatDownloaderLib.Scraper
{
    public class BeastSaberScraper
    {
        // TODO: Add overload methods to allow for different time filters.
        public List<Song> ScrapeSongs()
        {
            //Create a list of songs
            List<Song> songs = new List<Song>();

            HtmlWeb web = new HtmlWeb();
            //Loads the url into a document
            HtmlDocument doc = web.Load("https://bsaber.com/songs/top/?time=7-days");

            // Loop through each element that has the class "-download-zip" and add the href to the 
            foreach (var songElement in doc.DocumentNode.SelectNodes("//a[contains(@class, '-download-zip')]"))
            {
                // Gets the href link of the download link
                // For example:
                // href="https://api.beatsaver.com/download/key/1ac0f"
                var href = songElement.Attributes["href"].Value;

                // Take the id in the last part of the url
                var songId = href.Substring(href.LastIndexOf('/') + 1);

                // Create a song and add it to a list
                songs.Add(new Song(songId));
            }

            return songs;
        }
    }
}

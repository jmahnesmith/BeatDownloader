using BeastsaberScraper;
using BeatsaverDataTunnel.Api;
using BeatsaverDataTunnel.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BeatDownloaderConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to BeatDownloader.");
            Console.WriteLine("Finding Maps...");

            Scraper scraper = new Scraper();
            var songs = scraper.ScrapeSongs();

            Console.WriteLine("Found the following songs:");
            Maps map = new Maps();
            List<MapDetail> maps = new List<MapDetail>();
            SongDownloader songDownloader = new SongDownloader();
            foreach (var song in songs)
            {
                var mapDetail = await map.GetMapById(song.ID);
                //maps.Add(mapDetail);
                if (songDownloader.SongExists(mapDetail))
                {
                    Console.WriteLine($"{mapDetail.name} already exists! Skipping...");
                }
                else
                {
                    Console.WriteLine($"Downloading: {mapDetail.name}");
                    songDownloader.DownloadSong(mapDetail);
                }
            }
        }
    }
}

using BeatDownloaderLib.API.DataAccess;
using BeatDownloaderLib.API.Models;
using BeatDownloaderLib.Core;
using BeatDownloaderLib.Scraper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeatDownloaderConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello, welcome to BeatDownloader.");
            Console.WriteLine("Finding Maps...");

            BeastSaberScraper scraper = new BeastSaberScraper();
            var songs = scraper.ScrapeSongs();

            Console.WriteLine("Found the following songs:");
            MapEndpoint map = new MapEndpoint();
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

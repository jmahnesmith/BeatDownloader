
using System.Net;
using System.IO.Compression;
using System.IO;
using System;
using BeatDownloaderLib.API.Models;

namespace BeatDownloaderLib.Core
{
    public class SongDownloader
    {
        private GamePathManager gamePathManager;
        public SongDownloader(GamePathManager gamePathManager)
        {
            this.gamePathManager = gamePathManager;
        }

        // TODO: Add a way to find beatsaber path automatically
        public void DownloadSong(MapDetail song)
        {
            using (WebClient client = new WebClient())
            { 
                var fileName = $"{ song.id } ({ song.name})";
                var zipPath = Path.GetTempPath() + $"{fileName}.zip";
                var extractedPath = gamePathManager.GetGamePath() + fileName;
                var latestVersion = song.versions[song.versions.Count - 1];

                try
                {
                    client.DownloadFile(latestVersion.downloadURL, zipPath);
                    ZipFile.ExtractToDirectory(zipPath, extractedPath);
                    //Delete file after unzipping
                    File.Delete(zipPath);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error downloading song: {ex.Message.ToUpper()} Skipping...");
                }
            }
        }

        public bool SongExists(MapDetail song)
        {
            var folderName = $"{ song.id } ({song.name})";
            var folderPath = gamePathManager.GetGamePath() + folderName;

            if (Directory.Exists(folderPath))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

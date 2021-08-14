
using BeatsaverDataTunnel.Models;
using System.Net;
using System.IO.Compression;
using System.IO;
using System;

namespace BeatDownloaderConsole
{
    public class SongDownloader
    {
        // TODO: Add a way to find beatsaber path automatically
        public void DownloadSong(MapDetail song)
        {
            using (WebClient client = new WebClient())
            {
                var fileName = $"{ song.id } ({ song.name})";
                var zipPath = $"D:\\{fileName}.zip";
                var extractedPath = @"D:\SteamGames\steamapps\common\Beat Saber\Beat Saber_Data\CustomLevels\" + fileName;
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
            var folderPath = @"D:\SteamGames\steamapps\common\Beat Saber\Beat Saber_Data\CustomLevels\" + folderName;

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

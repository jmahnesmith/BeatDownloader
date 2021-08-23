using BeatDownloaderLib.Scraper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BeatDownloaderLib.Tests.Scraper
{
    public class ScraperTests
    {
        [Fact]
        public void ScrapeSongs_CheckForTopSong()
        {
            // Arrange
            BeastSaberScraper scraper = new BeastSaberScraper();
            // Act
            var listOfSongs = scraper.ScrapeSongs();
            var actualValue = listOfSongs[0].ID;
            // Assert
            Assert.NotNull(actualValue);
        }
    }
}

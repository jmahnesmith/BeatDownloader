
using Xunit;

namespace BeastsaberScraper.Tests
{
    public class ScraperTests
    {
        [Fact]
        public void ScrapeSongs_CheckForTopSong()
        {
            // Arrange
            Scraper scraper = new Scraper();
            var expected = "1ac0f";
            // Act
            var listOfSongs = scraper.ScrapeSongs();
            var actualValue = listOfSongs[0].ID;
            // Assert
            Assert.Equal(expected, actualValue);
        }
    }
}

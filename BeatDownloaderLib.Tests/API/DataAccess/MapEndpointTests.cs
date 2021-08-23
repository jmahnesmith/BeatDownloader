using BeatDownloaderLib.API.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BeatDownloaderLib.Tests.API.DataAccess
{
    public class MapEndpointTests
    {
        [Fact]
        public async Task GetMapById_ShouldGetMapNameAsync()
        {
            // Arrange
            MapEndpoint map = new MapEndpoint();
            string expected = "Mr. Blue Sky | Electric Light Orchestra";

            // Act
            var actualMap = await map.GetMapById("570");
            var actualMapName = actualMap.name;

            // Assert
            Assert.Equal(expected, actualMapName);
        }

        [Fact]
        public async Task GetMapById_ShouldGetMapDownloadURLAsync()
        {
            // Arrange
            MapEndpoint map = new MapEndpoint();
            // Act
            var actualMap = await map.GetMapById("570");
            var actualMapDownloadLink = actualMap.versions[0].downloadURL;

            // Assert
            Assert.NotNull(actualMapDownloadLink);
        }
    }
}

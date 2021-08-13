using BeatsaverDataTunnel.Api;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BeatsaverDataTunnel.Tests
{
    public class MapsTests
    {
        [Fact]
        public async Task GetMapById_ShouldGetMapNameAsync()
        {
            // Arrange
            Maps map = new Maps();
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
            Maps map = new Maps();
            string expected = "https://cdn.beatsaver.com/236173d5ba7dc379d480b9cb5fb6b4fa5abe77da.zip";
            // Act
            var actualMap = await map.GetMapById("570");
            var actualMapDownloadLink = actualMap.versions[0].downloadURL;

            // Assert
            Assert.Equal(expected, actualMapDownloadLink);
        }
    }
}

using BeatDownloaderLib.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BeatDownloaderLib.Tests.Core
{
    public class GamePathManagerTests
    {
        [Fact]
        public void GetSteamPath_ShouldReturnSteamPath()
        {
            // Arrange
            string expected = @"C:\Program Files (x86)\Steam";

            // Act
            GamePathManager gamePathManager = new GamePathManager();
            string actual = gamePathManager.GetSteamPath();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetGamePath_ShouldReturnBeatSaberPath()
        {
            // Arrange
            string expected = @"C:\Program Files (x86)\Steam\steamapps\common\Beat Saber";

            // Act
            GamePathManager gamePathManager = new GamePathManager();
            string actual = gamePathManager.GetGamePath();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}

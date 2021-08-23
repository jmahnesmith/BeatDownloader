using System;
using System.Collections.Generic;
using System.Text;

namespace BeatDownloaderLib.API.Models
{
    public class MapVersion
    {
        public string coverURL;
        public DateTime createdAt;
        public List<MapDifficulty> diffs = new List<MapDifficulty>();
        public string downloadURL;
        public string feedback;
        public string hash;
        public string key;
        public string previewURL;
        public short sageScore;
        public string state;
        public DateTime testplayAt;
        public List<MapTestplay> testplays = new List<MapTestplay>();
    }
}

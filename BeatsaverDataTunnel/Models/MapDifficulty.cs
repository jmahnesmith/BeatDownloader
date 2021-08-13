using System;
using System.Collections.Generic;
using System.Text;

namespace BeatsaverDataTunnel.Models
{
    public class MapDifficulty
    {
        public int bombs;
        public string[] characteristic = new[] { "Standard", "OneSaber", "NoArrows", "90Degree", "360Degree", "Lightshow", "Lawless" };
        public bool chroma;
        public bool cinema;
        public string[] difficulty = new[] { "Easy", "Normal", "Hard", "Expert", "ExpertPlus" };
        public int events;
        public double length;
        public bool me;
        public bool ne;
        public float njs;
        public int notes;
        public double nps;
        public int obstacles;
        public float offset;
        public MapParitySummary paritySummary;
        public double seconds;
        public float stars;
    }
}

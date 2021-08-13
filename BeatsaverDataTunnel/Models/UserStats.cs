﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BeatsaverDataTunnel.Models
{
    public class UserStats
    {
        public float avgBpm;
        public float avgDuration;
        public float avgScore;
        public UserDiffStats diffStats;
        public Instant firstUpload;
        public Instant lastUpload;
        public int rankedMaps;
        public int totalDownvotes;
        public int totalMaps;
        public int totalUpvotes;
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BeatDownloaderLib.API.Models
{
    public class VoteSummary
    {
        public int downvotes;
        public string hash;
        public string key64;
        public int mapId;
        public int oldDownvotes;
        public int oldUpvotes;
        public double score;
        public int upvotes;
    }
}

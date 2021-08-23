using System;
using System.Collections.Generic;
using System.Text;

namespace BeatDownloaderLib.API.Models
{
    public class VoteRequest
    {
        public AuthRequest auth;
        public bool direction;
        public string hash;
    }
}

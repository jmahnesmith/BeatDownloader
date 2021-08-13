using System;
using System.Collections.Generic;
using System.Text;

namespace BeatsaverDataTunnel.Models
{
    public class VoteRequest
    {
        public AuthRequest auth;
        public bool direction;
        public string hash;
    }
}

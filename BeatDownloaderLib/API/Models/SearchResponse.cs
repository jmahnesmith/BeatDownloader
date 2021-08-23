using System;
using System.Collections.Generic;
using System.Text;

namespace BeatDownloaderLib.API.Models
{
    public class SearchResponse
    {
        public List<MapDetail> docs = new List<MapDetail>();
        public string redirect;
        public UserDetail user;
    }
}

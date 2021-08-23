﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BeatDownloaderLib.API.Models
{
    public class MapDetail
    {
        public bool automapper;
        public string curator;
        public string description;
        public string id;
        public MapDetailMetadata metadata;
        public string name;
        public bool qualified;
        public bool ranked;
        public MapStats stats;
        public DateTime uploaded;
        public UserDetail uploader;
        public List<MapVersion> versions = new List<MapVersion>();
    }
}

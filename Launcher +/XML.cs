using System;
using System.IO;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Launcher__
{
    [Serializable]
    public class Setting
    {
        public List<XML> fullpath { get; set; } = new List<XML>();
    }
    
    [Serializable]
    public class XML
    {
        public string Path { get; set; }
        public string Rss { get; set; }

        public XML()
        { }

        public XML(string path, string rss)
        {
            this.Path = path;
            this.Rss = rss;
        }
    }
}

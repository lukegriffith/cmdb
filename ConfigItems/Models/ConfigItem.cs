using System;
using System.Collections.Generic;
using System.Text;

namespace ConfigItems.Models
{
    public class ConfigItem
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public Dictionary<string,string> Attributes { get; set; }   
        public string Category { get; set; }
        public string Owner { get; set; }
        public string User { get; set; }

    }
}

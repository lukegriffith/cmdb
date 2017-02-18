using System;
using System.Collections.Generic;

namespace ConfigItems.Models
{
    public class ConfigItem
    {
        public String Name { get; set; }
        public int Id { get; set; }
        public Dictionary<String,String> Attributes { get; set; }   
        public String Category { get; set; }
        public String Owner { get; set; }
        public String User { get; set; }

    }
}

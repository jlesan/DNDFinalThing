using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DNDCharSheet.Models
{
    public class Items
    {
        public int id { get; set; }
        public string name { get; set; }
        public string itemDesc { get; set; }
        public int weight { get; set; }
        public int amount { get; set; }
    }
}
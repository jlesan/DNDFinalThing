using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DNDCharSheet.Models
{
    public class Spells
    {
        public int id { get; set; }
        public string spellName { get; set; }
        public int level { get; set; }
        public string spellDesc { get; set; }
        public int spellRange { get; set; }
        public string castDuration { get; set; }
        public string castTime { get; set; }
        public string spellComponents { get; set; }

    }
}
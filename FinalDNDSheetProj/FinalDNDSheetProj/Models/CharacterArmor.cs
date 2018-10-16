using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DNDCharSheet.Models
{
    public class CharacterArmor
    {
        public int id { get; set; }
        public string name { get; set; }
        public string armorDesc { get; set; }
        public int ac { get; set; }
        public int weight { get; set; }
    }
}
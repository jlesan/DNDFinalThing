using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DNDCharSheet.Models
{
    public class CharacterWeapons
    {
        public int id { get; set; }
        public string weaponName { get; set; }
        public string weaponDesc { get; set; }
        public string atkType { get; set; }
        public string damage { get; set; }
        public string properties { get; set; }
        public int weight { get; set; }
    }
}
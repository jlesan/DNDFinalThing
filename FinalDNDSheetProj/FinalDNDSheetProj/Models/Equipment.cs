using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DNDCharSheet.Models
{
    public class Equipment
    {
        public int id { get; set; }
        public virtual ICollection<CharacterWeapons> weapons { get; set; }
        public virtual ICollection<CharacterArmor> armor { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DNDCharSheet.Models
{
    public class CharacterInventory
    {
        public int id { get; set; }
        public int platinum { get; set; }
        public int gold { get; set; }
        public int electrum { get; set; }
        public int silver { get; set; }
        public int copper { get; set; }
        public virtual ICollection<Items> items { get; set; }
    }
}
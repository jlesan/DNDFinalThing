using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DNDCharSheet.Models
{
    public class Characters
    {
        public int id { get; set; }
        public string charName { get; set; }
        public string charRace { get; set; }
        public int charLevel { get; set; }
        public int charExpPoints { get; set; }
        public string charClass { get; set; }
        public string charBackground { get; set; }
        public string charSubrace { get; set; }
        public int charAge { get; set; }
        public string charHeight { get; set; }
        public int charWeight { get; set; }
        public int charEquipWeight { get; set; }
        public string charLifestyle { get; set; }
        public string charDiety { get; set; }
        public string charAlightment { get; set; }
        public ICollection<string> charLanguages { get; set; }
        public ICollection<string> charConditions { get; set; }
        public string charPersonalityTraits { get; set; }
        public string charIdeals { get; set; }
        public string charBonds { get; set; }
        public string charFlaws { get; set; }
        public string charProficencies { get; set; }
        public string charFeatures { get; set; }
        public string charTraits { get; set; }
        public virtual ICollection<Spells> charSpells { get; set; }
        public virtual ICollection<CharacterSkills> charSkills { get; set; }
        public virtual ICollection<CharacterStats> charStats { get; set; }
        public virtual CharacterInventory charInventory { get; set; }
        public virtual Equipment charEquipment { get; set; }

    }
}
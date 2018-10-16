using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DNDCharSheet.Models
{
    public class CharacterStats
    {
        public int id { get; set; }
        public int ac { get; set; }
        public int hitPointsMax { get; set; }
        public int inititive { get; set; }
        public int speed { get; set; }
        public int hitPointsCurrent { get; set; }
        public int hitPointsTemp { get; set; }
        public int strength { get; set; }
        public int strengthMod { get; set; }
        public int dex { get; set; }
        public int dexMod { get; set; }
        public int constitution { get; set; }
        public int constitutionMod { get; set; }
        public int intelligence { get; set; }
        public int intelligenceMod { get; set; }
        public int wisdom { get; set; }
        public int wisdomMod { get; set; }
        public int charisma { get; set; }
        public int charismaMod { get; set; }
        public int profBonus { get; set; }
        public int perception { get; set; }
        public int hitDiceHeal { get; set; }
        public int hitDiceAmount { get; set; }
        public string spellAbility { get; set; }
        public int spellSave { get; set; }
        public int spellAtkBonus { get; set; }
        public string spellClass { get; set; }
        public ICollection<string> savingThrows { get; set; }
        public ICollection<string> skills { get; set; }
    }
}
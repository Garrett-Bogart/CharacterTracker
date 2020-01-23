using System;
using System.Collections.Generic;
using System.Text;

namespace Character.Data
{
    class Hero
    {
        public Guid Id { get; set; }
        public Stats Stats { get; set; }
        public int HP { get; set; }
        public int AC { get; set; }
        public int Race { get; set; }//have enum later
        public int Speed { get; set; }
        public int Initiative { get; set; }
        public Skills Skills { get; set; }
        public Spells Spells { get; set; }//one character can have many spells, one spells can have many characters     
        public SpellSlots Slots { get; set; }
    }
}

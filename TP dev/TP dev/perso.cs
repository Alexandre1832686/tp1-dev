using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_dev
{
    public class perso
    {
        public Race race;
        public ClassePerso classePerso;

        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }


        public perso(Race race, ClassePerso classePerso)
        {
            this.race = race;
            this.classePerso = classePerso;
        }
        public perso()
        {

        }

        
        
        
       
    }
}

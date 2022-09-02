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
        ClassePerso classePerso;
        
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

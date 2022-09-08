using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_dev
{
    class Halfling : Race
    {
        public override string[,] GetBonusRace()
        {
            string[,] montab = new string[2, 1];

            montab[0, 0] = "2";



            montab[1, 0] = "Dexterity";

            


            return montab;
        }
    }
}

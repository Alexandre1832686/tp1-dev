using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_dev
{
   class Tiefling : Race
    {
        public override string[,] GetBonusRace()
        {
            string[,] montab = new string[2, 2];

            montab[0, 0] = "1";
            montab[0, 1] = "2";




            montab[1, 0] = "Intelligence";
            
            montab[1, 1] = "Charisma";


            return montab;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_dev
{
    class Half_Orc : Race
    {
        
        public override string[,] GetBonusRace()
        {
            string[,] montab = new string[2, 2];

            montab[0, 0] = "2";
            montab[0, 1] = "1";


            montab[1, 0] = "Strength";

            montab[1, 1] = "Constitution";


            return montab;
        }
        

    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_dev
{
    class Humain : Race
    {
        public override string[,] GetBonusRace()
        {
            string[,] montab = new string[2, 6];

            for(int i=0;i<6;i++)
            {
                montab[0, i] = "1";
            }

            montab[1, 0] = "Strength";
            montab[1, 1] = "Dexterity";
            montab[1, 2] = "Constitution";
            montab[1, 3] = "Intelligence";
            montab[1, 4] = "Wisdom";
            montab[1, 5] = "Charisma";

            return montab;
        }
    }
}

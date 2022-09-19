using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_dev
{
    /// <summary>
    /// Classe pour lamcer un dé
    /// </summary>
    public static class De
    { 
        static Random random = new Random();

        //Trouve la valeur entre un et une valeur max passer en commentaire et la renvoie
        public static int lancerDe(int maxDe)
        {
            return random.Next(1, maxDe + 1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_dev
{
    /// <summary>
    /// Classe mère des 12 sous-classe de race
    /// </summary>
    public abstract class Race
    {
        /// <summary>
        /// Renvoie les bonus propres à chaque sous-classe de Race
        /// </summary>
        /// <returns></returns>
        public abstract string[,] GetBonusRace();
        
    }
}

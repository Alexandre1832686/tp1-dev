using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_dev
{
    /// <summary>
    /// Classe mère des 9 sous-classe de classe 
    /// </summary>
    public abstract class ClassePerso
    {
        /// <summary>
        /// renvoie la stat d'attaque de chaque sous-classe de ClassePerso et de base renvoie 8
        /// </summary>
        /// <returns></returns>
        public virtual int Attack()
        {
            return 8;
        }

    }
}

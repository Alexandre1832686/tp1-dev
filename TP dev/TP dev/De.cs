using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_dev
{
    public static class De
    {

        static Random random = new Random();

        public static int lancerDe(int maxDe)
        {
            return random.Next(1, maxDe + 1);
        }
    }
}

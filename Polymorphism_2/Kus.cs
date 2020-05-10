using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_2
{
    public class Kus
    {
        public virtual string Ses()
        {
            return "Kuş Sesi";
        }
    }

    public class Serce : Kus
    {
        public virtual string Ses()
        {
            return "cik cik";
        }
    }

    public class Karga : Kus
    {
        public virtual string Ses()
        {
            return "gak gak";
        }
    }
}
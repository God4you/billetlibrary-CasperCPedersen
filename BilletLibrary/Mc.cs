using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public class Mc : KøretøjStandart
    {

        public override DateTime Dato { get; set; }

        public override decimal Pris()
        {
            return 125;
        }

        public override string Køretøj()
        {
            return "MC";
        }
    }
}

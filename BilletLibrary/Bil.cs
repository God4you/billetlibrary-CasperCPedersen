using System;

namespace BilletLibrary
{
    public class Bil : KøretøjStandart
    {

        public override DateTime Dato { get; set; }

        public override decimal Pris()
        {
            return 240;
        }

        public override string Køretøj()
        {
            return "Bil";
        }
    }
}

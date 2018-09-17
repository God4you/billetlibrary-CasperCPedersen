using System;

namespace BilletLibrary
{
    public class Bil : Køretøj
    {
        public override string NummerPlade { get; set; }

        public override DateTime Dato { get; set; }

        public override decimal Pris()
        {
            return 240;
        }

        public string Køretøj()
        {
            return "Bil";
        }
    }
}

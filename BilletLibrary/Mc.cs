using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public class Mc : Køretøj
    {
        public override string NummerPlade { get; set; }

        public override DateTime Dato { get; set; }

        public override decimal Pris()
        {
            return 125;
        }

        public string Køretøj()
        {
            return "MC";
        }
    }
}

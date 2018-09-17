using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public class Mc
    {
        public string Nummerplade { get; set; }

        public DateTime Date { get; set; }

        public decimal Pris()
        {
            return 125;
        }

        public string Køretøj()
        {
            return "MC";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    /// <summary>
    /// Abstract Class Køretøj indholder alt info ens for alle Køretøjer i danmark
    /// </summary>
    public abstract class Køretøj
    {
        /// <summary>
        /// NummerPlade "String"
        /// </summary>
        public abstract string NummerPlade { get; set; }

        /// <summary>
        /// Dato "DateTime" visser hvornår køretøjet kom forbi
        /// </summary>
        public abstract DateTime Dato { get; set; }

        public virtual decimal Pris()
        {
            return 240;
        }

    }
}

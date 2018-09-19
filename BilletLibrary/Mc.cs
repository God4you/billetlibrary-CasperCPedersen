using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    /// <summary>
    /// MC public class
    /// </summary>
    public class Mc : KøretøjStandart
    {
        /// <summary>
        /// Override decimal Pris()
        /// </summary>
        /// <returns></returns>
        public override decimal Pris()
        {
            return 125;
        }
        /// <summary>
        /// Override string Køretøj()
        /// </summary>
        /// <returns></returns>
        public override string Køretøj()
        {
            return "MC";
        }
    }
}

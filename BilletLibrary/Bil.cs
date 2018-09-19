using System;

namespace BilletLibrary
{
    /// <summary>
    /// public Bil class.
    /// </summary>
    public class Bil : KøretøjStandart
    {
        /// <summary>
        /// override pris()
        /// </summary>
        /// <returns></returns>
        public override decimal Pris()
        {
            return 240;
        }
        /// <summary>
        /// override køretøj()
        /// </summary>
        /// <returns></returns>
        public override string Køretøj()
        {
            return "Bil";
        }
    }
}

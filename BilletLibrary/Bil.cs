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
        /// Med fast pris 240kr
        /// </summary>
        /// <returns></returns>
        public override decimal Pris()
        {
            return 240;
        }
        /// <summary>
        /// override køretøj()
        /// returner "Bil"
        /// </summary>
        /// <returns></returns>
        public override string Køretøj()
        {
            return "Bil";
        }
    }
}

using System;

namespace BilletLibrary
{
    /// <summary>
    /// Abstract Class Køretøj indholder alt info ens for alle Køretøjer i danmark
    /// </summary>
    public abstract class KøretøjStandart
    {
        private string _nummerplade;

        /// <summary>
        /// NummerPlade "String kan ikke blive sat til en string længer end 7 tengn"
        /// </summary>
        public virtual string NummerPlade
        {
            get { return _nummerplade; }
            set
            {
                if (value.Length < 8)
                {
                    _nummerplade = value;
                }
                else
                {
                    throw new ArgumentException("for lang");
                }
            }
        }


        /// <summary>
        /// Dato "DateTime" kan bruges til at gemme, hvornår køretøjet. Kom forbi.
        /// </summary>
        public virtual DateTime Dato { get; set; }

        /// <summary>
        /// Method returner Prisen, køretøjet skal betale i Dkk
        /// </summary>
        /// <returns></returns>
        public virtual decimal Pris()
        {
            return 240;
        }
        /// <summary>
        /// Method returner prisen med Brobizz rabat,
        /// </summary>
        /// <returns></returns>
        public virtual decimal BrobizzPris()
        {
            decimal rabat = 0.95m; 
            decimal nypris = Pris() * rabat;
            return nypris;
        }

        /// <summary>
        /// Method returner Køretøj "Type".
        /// </summary>
        /// <returns></returns>
        public virtual string Køretøj()
        {
            return "Køretøj";
        }

    }
}

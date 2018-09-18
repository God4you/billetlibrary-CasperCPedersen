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
        /// Dato "DateTime" viser hvornår køretøjet kom forbi
        /// </summary>
        public abstract DateTime Dato { get; set; }

        /// <summary>
        /// Method returner Prisen, køretøjet skal betale i Dkk
        /// </summary>
        /// <returns></returns>
        public virtual decimal Pris()
        {
            return 240;
        }
        /// <summary>
        /// Method returner prisen med rabat,
        /// </summary>
        /// <returns></returns>
        public virtual decimal BrobizzPris()
        {
            decimal rabat = 0.95m; 
            decimal nypris = Pris() * rabat;
            return nypris;
        }

        /// <summary>
        /// Method, NummerPladeLæser, registare nummerpladen og sikker at den ikke er længer end 7. 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public virtual string NummerPladeLæser(string input)
        {
            if (input.Length > 7)
            {
                return "Fejl: Nummerlade for lang";
            }
            NummerPlade = input;
            return "Nummerplade er godtaget";
        }

    }
}

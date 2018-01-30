using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaffe
{
    public class FlatWhite : Kaffe, Imælk
    {

        public FlatWhite()
            :base()
        {

        }

        /// <summary>
        /// Opretter et FlatWhite obj med rabat
        /// </summary>
        /// <param name="rabat">rabat der skal gives</param>
        public FlatWhite(int rabat)
            :base(rabat)
        {

        }
        /// <summary>
        /// Retunere en integer baseret på hvad ml mælk som denne kaffe skal bruge
        /// </summary>
        /// <returns></returns>
        public int MlMælk()
        {
            return 160;
        }

        /// <summary>
        /// Retunere pris med rabat
        /// </summary>
        /// <returns></returns>
        public override int Pris()
        {
            int prismedrabat = 45 - Rabat;

            if (prismedrabat <= 0)
                throw new ArgumentException("Uppss du gav for meget rabat");

            return prismedrabat;
        }

        /// <summary>
        /// returns a strength of the coffee
        /// </summary>
        /// <returns></returns>
        public override string Styrke()
        {
            return "Mild";
        }
    }
}

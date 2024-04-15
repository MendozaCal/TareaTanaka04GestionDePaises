using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaTanaka04GestiónDePaises
{
    internal class Felicidad : StatBase
    {
        public int Felicidad { get; set; }
        public int VariantFelicidad { get; set; }

        public virtual int GetHappy()
        {
            return Felicidad;
        }

        public virtual int GetVariationFelicidad()
        {
            return VariantFelicidad;
        }

        public void AffectHappiness(int gastoSeguridad)
        {
            if (gastoSeguridad < 20)
            {
                Felicidad -= 10; 
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaTanaka04GestiónDePaisesñ
{
    internal class Felicidad : StatBase
    {
        public StatBase()
        {
            protected string name { get;: set };
            int felicidad {  get; set; }
            int VariantFelicidad {  get; set; }
        }
        public virtual int GetHappy()
        {
            return felicidad;
        }
        public virtual int GetVariationFelecidad()
        {
            return VariantFelicida;
        }
    }
}

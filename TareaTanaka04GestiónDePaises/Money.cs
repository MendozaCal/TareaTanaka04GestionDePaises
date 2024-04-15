using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaTanaka04GestiónDePaises
{
    internal class Money : StatBase
    {
        public Money()
        {
            protected string name { get;: set };
            int money { get; set; }
            int VariantMoney { get; set; }
        }
        public virtual float     GetMoney()
        {
            return felicidad;
        }
        public virtual int GetVariationMoney()
        {
            return VariantMoney;
        }
}
}
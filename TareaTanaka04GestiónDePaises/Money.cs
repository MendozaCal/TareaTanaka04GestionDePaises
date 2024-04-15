using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaTanaka04GestiónDePaises
{
    internal class Money : StatBase
    {
        public int Money { get; set; }
        public int VariantMoney { get; set; }

        public virtual int GetMoney()
        {
            return Money;
        }

        public virtual int GetVariationMoney()
        {
            return VariantMoney;
        }
    }
}
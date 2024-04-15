using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaTanaka04GestiónDePaises
{
    internal class StatBase
    {
        public StatBase()
        {
            public string name { get;: set };
        }
        public virtual int GetPeople() 
        {
            return 0;
        }
        public virtual float GetMoney()
        {
            return 0;
        }
        public virtual int GetHappy()
        {
            return 0;
        }
        public virtual int GetVariationFelecidad()
        {
            return 0;
        }
        public virtual int GetVariationMoney()
        {
            return 0;
        }
    }
}

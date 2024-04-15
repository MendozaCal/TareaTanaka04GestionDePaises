using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaTanaka04GestiónDePaisesñ 
{
    internal class StatBase
    {
        public StatBase()
        {
            protected string name { get;: set };
        }
        public virtual int GetPopulation() 
        {
            return 0;
        }
        public virtual float GetMoney()
        {
            return 0;
        }
        public virtual float GetHappy()
        {
            return 0;
        }
    }
}

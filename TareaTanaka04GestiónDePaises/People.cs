using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaTanaka04GestiónDePaisesñ
{
    internal class People : StatBase
    {
        public People()
        {
            public string name { get;: set };
            int people { get; set; }
        }
        public virtual int GetPeople()
        {
            return people;
        }
    }
}

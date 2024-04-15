﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaTanaka04GestiónDePaises
{
    internal class Servicios
    {
        protected string name;
        
        public string Name
        {
            get { return name; }
        }

        public virtual float GetPrice()
        {
            return 0;
        }
        public virtual int GetVariationSalud()
        {
            return 0;
        }
        public virtual int GetVariationEducacion()
        {
            return 0;
        }
        public virtual int GetVariationSeguridad()
        {
            return 0;
        }

    }
}

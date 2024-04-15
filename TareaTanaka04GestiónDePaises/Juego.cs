using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaTanaka04GestiónDePaises
{
    internal class Juego
    {
        public void Execute()
        {
            Servicios[] serviciosArray = new Servicios[3];
            serviciosArray[0] = new Salud("Salud", 0,0 );
            serviciosArray[1] = new Educación("Educacion", 0,0 );
            serviciosArray[2] = new Seguridad("Seguridad", 0,0 );
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_13_06
{
    public interface IReproducible
    {
        void ReproducirVideo(string informacion);
        void ReproducirSonido(string informacion);
        string informacionReproduccion { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo2parcial
{
    public interface ISueldo
    {
        double CalcularSueldoBruto();
        double CalcularSueldoNeto();

        double SueldoBasico { set; get; }
    }
}

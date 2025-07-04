using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo2parcial
{
    public class EmpleadoACargoRepetidoException: Exception
    {
        public EmpleadoACargoRepetidoException(string message) :base (message)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo2parcial
{
    public class Pasante : Empleado
    {
        public string TipoJornada { get; set; }

        public Pasante(string nom, string ape, string dni, double sueldoB, string jornada) : base(nom, ape, dni, sueldoB)
        {
            TipoJornada = jornada;
        }


        public override double CalcularSueldoBruto()
        {
            if (TipoJornada == "PartTime")
            {
                return SueldoBasico;
            }
            else
            {
                return SueldoBasico * 1.5;
            }
        }
    }
}

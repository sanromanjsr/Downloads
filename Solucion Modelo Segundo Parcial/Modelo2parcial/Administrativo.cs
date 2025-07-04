using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo2parcial
{
    public class Administrativo : Empleado
    {
 
        public int HorasMensualesContrato { get; }

        public Administrativo(string nom, string ape, string dni, double sueldoB, int horasMensuales) : base(nom, ape, dni, sueldoB)
        {
            if (horasMensuales < 40)
            {
                throw new Exception("No se puede crear un empleado administrativo que trabaje menos de 40hs mensuales");
            }
            HorasMensualesContrato = horasMensuales;
        }


        public override double CalcularSueldoBruto()
        {
            double INCREMENTO_SALARIAL;
            if (HorasMensualesContrato >= 160)
            {
                INCREMENTO_SALARIAL = 0.10;
            }
            else if (HorasMensualesContrato >= 120)
            {

                INCREMENTO_SALARIAL = 0.08;
            }
            else if (HorasMensualesContrato <= 100)
            {
                INCREMENTO_SALARIAL = 0.05;
            }
            else
            {
                INCREMENTO_SALARIAL = 0.06;
            }
            double sueldoBruto = SueldoBasico + (SueldoBasico * INCREMENTO_SALARIAL);
            return sueldoBruto;
        }
    }
}

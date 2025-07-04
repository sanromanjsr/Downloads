using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo2parcial
{
   public abstract class Empleado : ISueldo
    {

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public double SueldoBasico { get; set; }
        //Propiedad de solo lectura que devuelve el sueldo bruto del empleado
        public double Sueldo_Bruto { get => CalcularSueldoBruto(); }
        //Propiedad de solo lectura que devuelve el sueldo neto del empleado
        public double Sueldo_Neto { get => CalcularSueldoNeto(); }


        public Empleado(string nom, string ape, string dni, double sueldoB)
        {
            if (sueldoB < 1800000)
            {
                throw new Exception("No se puede crear un empleado con sueldo inferior al mínimo permitido por ley");
            }
            Nombre = nom;
            Apellido = ape;
            DNI = dni;
            SueldoBasico = sueldoB;
        }


        public abstract double CalcularSueldoBruto();

        public double CalcularSueldoNeto()
        {
            double sueldoBruto = CalcularSueldoBruto();
            if (sueldoBruto < 500000)
            {
                 return sueldoBruto * 0.83;
              
            }
            else
            {
                return sueldoBruto * 0.65;
            }
        }

    }
}

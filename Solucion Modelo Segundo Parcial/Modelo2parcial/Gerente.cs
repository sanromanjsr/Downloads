using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo2parcial
{
    public class Gerente : Empleado
    {
        public List<Empleado> EmpleadosACargo { get; set; } = new List<Empleado>();
        public int CantidadEmpleadosACargo { get => EmpleadosACargo.Count(); }

        public Gerente(string nom, string ape, string dni, double sueldoB) : base(nom, ape, dni, sueldoB)
        {

        }

        public void AsignarEmpleadoACargo(Empleado empleado)
        {
            foreach (Empleado emplead2 in EmpleadosACargo)
            {
                if (emplead2.DNI == empleado.DNI)
                {
                    throw new EmpleadoACargoRepetidoException($"El empleado dni: {empleado.DNI} ya se encuentra a cargo de {this.Nombre} {this.Apellido}");
                }
            }

            EmpleadosACargo.Add(empleado);

        }
        public void EliminarEmpleadoACargo(string dni)
        {
            foreach (Empleado empleado in EmpleadosACargo)
            {
                if (empleado.DNI == dni)
                {
                    EmpleadosACargo.Remove(empleado);
                    return;
                }
            }
            throw new Exception("El empleado no existe");
        }

        public override double CalcularSueldoBruto()
        {
            if (CantidadEmpleadosACargo == 0)
            {
                throw new Exception("No se puede calcular el sueldo de un gerente sin personas a cargo");
            }

            double sueldoBruto = SueldoBasico + SueldoBasico * 0.02 * CantidadEmpleadosACargo;

            foreach (Empleado empleado in EmpleadosACargo)
            {
                sueldoBruto += empleado.SueldoBasico * 0.01;
            }
            return sueldoBruto;
        }

    }
}

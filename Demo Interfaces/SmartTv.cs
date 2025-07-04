using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_13_06
{
    public class SmartTv : Dispositivo, IReproducible
    {
        private double pulgadas;

        public string informacionReproduccion { get; set; }
        public double Pulgadas { get; set; }

        public override void Encender()
        {
            if (this.Estado == "Apagado")
            {
                this.Estado = "Encendido";
            }
            else
            {
                throw new Exception("La TV ya está encendida");
            }
        }

        public override void Apagar()
        {
            if (
                this.Estado == "Encendido" || 
                this.Estado == "ReproduciendoVideo" ||
                this.Estado == "ReproduciendoSonido"
            )
            {
                this.Estado = "Apagado";
                this.informacionReproduccion = null;
                
            } else
            {
                throw new Exception("La TV ya está apagada");
            }
        }

        public void ReproducirSonido(string informacion)
        {
            if (this.Estado != "Apagado")
            {
                this.informacionReproduccion = informacion;
                this.Estado = "ReproduciendoSonido";
            } else
            {
                throw new Exception("No se puede reproducir sonido, la TV está apagada");
            }
        }

        public void ReproducirVideo(string informacion)
        {
            if (this.Estado != "Apagado")
            {
                this.informacionReproduccion = informacion;
                this.Estado = "ReproduciendoVideo";
            }
            else
            {
                throw new Exception("No se puede reproducir video, la TV está apagada");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_13_06
{
    public class Tablet : Dispositivo, IReproducible
    {
        private double tamañoPantalla;

        public string informacionReproduccion { get; set; }

        public override void Encender()
        {
            if (this.Estado == "Apagado")
            {
                this.Estado = "Encendido";
            }
            else
            {
                throw new Exception("La Tablet ya está encendida");
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
            }
            else
            {
                throw new Exception("La Tablet ya está apagada");
            }
        }

        public void ReproducirSonido(string informacion)
        {
            if (this.Estado != "Apagado")
            {
                this.informacionReproduccion = informacion;
                this.Estado = "ReproduciendoSonido";
            }
            else
            {
                throw new Exception("No se puede reproducir sonido, la Tablet está apagada");
            }
        }

        public void ReproducirVideo(string informacion)
        {
            if (this.Estado != "Apagado" && this.Estado != "ReproduciendoSonido")
            {
                this.informacionReproduccion = informacion;
                this.Estado = "ReproduciendoVideo";
            }
            else if (this.Estado == "ReproduciendoSonido")
            {
                throw new Exception("Usted se encuentra reproduciendo sonido, para reproducir video necesita apagar y volver prender la tablet");
            }
            else
            {
                throw new Exception("No se puede reproducir video, la Tablet está apagada");
            }
        }
    }
}

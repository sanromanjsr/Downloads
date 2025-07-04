using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_13_06
{
    public abstract class Dispositivo
    {
        private string marca; 
        private string modelo;
        private MarcaEnum estado;

        public string Estado
        {
            get { return estado.ToString(); }
            set
            {
                if (Enum.TryParse(value, out MarcaEnum result))
                {
                    estado = result;
                }
                else
                {
                    throw new ArgumentException("Marca no válida");
                }
            }
        }

        public string Modelo{ get; set; }
        public string Marca { get; set; }

        public abstract void Encender();
        public abstract void Apagar();
    }
}

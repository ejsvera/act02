using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act02
{
    class Persona
    {
        private int id;
        private string nombre;
        private string direccion;
        private int fono;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public int Fono
        {
            get { return fono; }
            set { fono = value; }
        }

    }
}

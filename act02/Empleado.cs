using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act02
{
    class Empleado : Persona
    {
        private string email;
        private Jefe _jefe;
        private Departamento _departamento;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public Jefe Jefe
        {
            get { return _jefe;}
            set { _jefe = value; }
        }

        public Departamento Departamento
        {
            get { return _departamento; }
            set { _departamento = value;}
        }
    }
}

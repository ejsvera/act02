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

        public void Mostrar()
        {
            Console.WriteLine("Id        : " + Id);
            Console.WriteLine("Nombre    : " + Nombre);
            Console.WriteLine("Direccion : " + Direccion);
            Console.WriteLine("Telefono  : " + Fono);

            Console.WriteLine("Email     : " + email);

            Console.WriteLine("Jefe Id        : " + _jefe.Id);
            Console.WriteLine("Jefe Nombre    : " + _jefe.Nombre);
            Console.WriteLine("Jefe Direccion : " + _jefe.Direccion);
            Console.WriteLine("Jefe Telefono  : " + _jefe.Fono);

            Console.WriteLine("Departamento Id     : " + _departamento.Id);
            Console.WriteLine("Departamento Nombre : " + _departamento.Nombre);

            Console.WriteLine("---------------------------------------------------------------");
        }
    }
}

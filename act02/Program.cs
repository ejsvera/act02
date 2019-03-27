using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Departamentos
            Departamento d01 = new Departamento();
            Departamento d02 = new Departamento();

            d01.Id = 1;
            d01.Nombre = "Depto 01";

            d02.Id = 2;
            d02.Nombre = "Depto 02";

            // Jefes
            Jefe j01 = new Jefe();
            Jefe j02 = new Jefe();

            j01.Id = 11;
            j01.Nombre = "Jefe 01";
            j01.Direccion = "Dir jefe 01";
            j01.Fono = 11111111;
            j01.Nacimiento = new DateTime(2001, 11, 11);

            j02.Id = 22;
            j02.Nombre = "Jefe 02";
            j02.Direccion = "Dir jefe 02";
            j02.Fono = 22222222;
            j02.Nacimiento = new DateTime(2002, 12, 12);

            // Empleados
            Empleado e01 = new Empleado();
            Empleado e02 = new Empleado();
            Empleado e03 = new Empleado();

            e01.Id = 31;
            e01.Nombre = "Empleado 01";
            e01.Direccion = "Dir emp 01";
            e01.Fono = 33333333;
            e01.Email = "emp01@act02.cl";
            e01.Departamento = d01;
            e01.Jefe = j01;

            e02.Id = 32;
            e02.Nombre = "Empleado 02";
            e02.Direccion = "Dir emp 02";
            e02.Fono = 44444444;
            e02.Email = "emp02@act02.cl";
            e02.Departamento = d02;
            e02.Jefe = j02;

            e03.Id = 33;
            e03.Nombre = "Empleado 03";
            e03.Direccion = "Dir emp 03";
            e03.Fono = 55555555;
            e03.Email = "emp03@act02.cl";
            e03.Departamento = d01;
            e03.Jefe = j01;

            // mostrar datos
            e01.Mostrar();
            e02.Mostrar();
            e03.Mostrar();

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace act02
{
    class Jefe : Persona
    {
        private DateTime nacimiento;

        public DateTime Nacimiento
        {
            get { return nacimiento; }
            set { nacimiento = value; }
        }
    }
}

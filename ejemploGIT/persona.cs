using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploGIT
{
    class persona
    {
        String cedula,nombre;
        int ano_nacimiento, edad;

        public void calcular()
        {
            DateTime fecha_actual = DateTime.Now;
            int year = fecha_actual.Year;
            edad = year - ano_nacimiento;
        }
    }
}

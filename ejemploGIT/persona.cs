﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploGIT
{
    class persona
    {
        String cedula, nombre;
        int ano_nacimiento, edad;


        public persona(string nombreAux, string cedula, int edad, int ano_nacimiento)
        {
            this.nombre = nombreAux;
            this.cedula = cedula;
            this.edad = edad;
            this.ano_nacimiento = ano_nacimiento;
        }
    }
}
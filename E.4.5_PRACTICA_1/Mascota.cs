using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E._4._5_PRACTICA_1
{
    internal class Mascota
    {
        public string Nombre_Mascota { get; set; }
        public int Edad { get; set; }
        public string Raza { get; set; }
        public string Sexo { get; set; }

        public override string ToString()
        {
            return $"\nNombre De La Mascota:{Nombre_Mascota} \n Edad: {Edad} \n Raza: {Raza} \n Sexo: {Sexo} \n ------------------------";
        }
    }
}

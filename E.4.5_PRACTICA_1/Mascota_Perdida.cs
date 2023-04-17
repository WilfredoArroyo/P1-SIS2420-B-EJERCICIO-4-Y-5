using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E._4._5_PRACTICA_1
{
    internal class Mascota_Perdida : Mascota    
    {
        public string Motivo { get; set; }
        public DateTime Fecha_perdida { get; set; }


        public override string ToString()
        {
            return $"\nNombre De La Mascota:{Nombre_Mascota} \n Edad: {Edad} \n Raza: {Raza} \n Sexo: {Sexo} \n Motivo: {Motivo} \n fecha de perdida: {Fecha_perdida} ------------------------";
        }
    }
}

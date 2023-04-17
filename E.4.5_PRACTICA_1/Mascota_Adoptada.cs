using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E._4._5_PRACTICA_1
{
    internal class Mascota_Adoptada : Mascota   
    {
        public string Nombre_Dueño { get; set; }
        public decimal Pago_Mascota { get; set; }
        public DateTime Fecha_Adopcion { get; set; }

        public override string ToString()
        {
            return $"\nNombre De La Mascota:{Nombre_Mascota} \n Edad: {Edad} \n Raza: {Raza} \n Sexo: {Sexo} \n Nombre del Dueño: {Nombre_Dueño} \n Pago Mascota: {Pago_Mascota} \n Fecha de Adopcion: {Fecha_Adopcion} \n-----------------------------------------------------";
        }
    }
}

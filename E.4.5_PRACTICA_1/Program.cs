using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E._4._5_PRACTICA_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Mascota_Adoptada> ListaMascotas = new List<Mascota_Adoptada>();

            ListaMascotas.Add(new Mascota_Adoptada()
            {
                Nombre_Mascota = "locoto",
                Edad = 1,
                Raza = "chapi",
                Sexo = "masculino",
                Nombre_Dueño = "Pedro",
                Pago_Mascota = 50,
                Fecha_Adopcion =  new DateTime(2022,11,15),
            });
            ListaMascotas.Add(new Mascota_Adoptada()
            {
                Nombre_Mascota = "chiqui",
                Edad = 2,
                Raza = "chiwawa",
                Sexo = "femenino",
                Nombre_Dueño = "Juan",
                Pago_Mascota = 150,
                Fecha_Adopcion = new DateTime(2021, 5, 25),
            });
            ListaMascotas.Add(new Mascota_Adoptada()
            {
                Nombre_Mascota = "scott",
                Edad = 1,
                Raza = "buldog",
                Sexo = "masculino",
                Nombre_Dueño = "Frank",
                Pago_Mascota = 500,
                Fecha_Adopcion = new DateTime(2022, 11, 30),
            });
            ListaMascotas.Add(new Mascota_Adoptada()
            {
                Nombre_Mascota = "manchas",
                Edad = 2,
                Raza = "chiwawa",
                Sexo = "masculino",
                Nombre_Dueño = "Moises",
                Pago_Mascota = 100,
                Fecha_Adopcion = new DateTime(2021, 07, 18),
            });
            ListaMascotas.Add(new Mascota_Adoptada()
            {
                Nombre_Mascota = "salmon",
                Edad = 5,
                Raza = "pitbull",
                Sexo = "masculino",
                Nombre_Dueño = "Ruben",
                Pago_Mascota = 1200,
                Fecha_Adopcion = new DateTime(2019, 04, 5),
            });
            ListaMascotas.Add(new Mascota_Adoptada()
            {
                Nombre_Mascota = "paty",
                Edad = 7,
                Raza = "kuker",
                Sexo = "femenino",
                Nombre_Dueño = "Matilda",
                Pago_Mascota = 0,
                Fecha_Adopcion = new DateTime(2015, 12, 23),
            });
            ListaMascotas.Add(new Mascota_Adoptada()
            {
                Nombre_Mascota = "salchi",
                Edad = 5,
                Raza = "chiwawa",
                Sexo = "masculino",
                Nombre_Dueño = "Juaquin",
                Pago_Mascota = 250,
                Fecha_Adopcion = new DateTime(2018, 1, 28),
            });
            ListaMascotas.Add(new Mascota_Adoptada()
            {
                Nombre_Mascota = "Zapato",
                Edad = 3,
                Raza = "chapi",
                Sexo = "masculino",
                Nombre_Dueño = "Miguel",
                Pago_Mascota = 0,
                Fecha_Adopcion = new DateTime(2020, 04, 02),
            });
            ListaMascotas.Add(new Mascota_Adoptada()
            {
                Nombre_Mascota = "once",
                Edad = 1,
                Raza = "pastor aleman",
                Sexo = "masculino",
                Nombre_Dueño = "trump",
                Pago_Mascota = 1000,
                Fecha_Adopcion = new DateTime(2022, 11, 2),
            });
            ListaMascotas.Add(new Mascota_Adoptada()
            {
                Nombre_Mascota = "chelupin",
                Edad = 2,
                Raza = "chapi",
                Sexo = "masculino",
                Nombre_Dueño = "Anthony",
                Pago_Mascota = 0,
                Fecha_Adopcion = new DateTime(2021, 12, 01),
            });

            MostrarLista(ListaMascotas);
            Double Promedio = Prom_Mascotas(ListaMascotas);
            Console.WriteLine($"---------- PROMEDIO DE LA EDAD DE LAS MASCOTAS -----------\n Promedio: {Promedio}");
            double Prom_p = Prom_pago(ListaMascotas);
            Console.WriteLine($"---------- PROMEDIO DE PAGO MASCOTAS ---------- \n PROMEDIO: {Prom_p}");
            Raza_Chiwawa(ListaMascotas);
            EdadMascotas(ListaMascotas);
            Console.ReadKey();
        }

       

        private static double Prom_pago(List<Mascota_Adoptada> listaMascotas)
        {
            decimal suma = listaMascotas.Sum(x => x.Pago_Mascota);
            int Total = listaMascotas.Count;
            return (double)(suma/Total);
        }

        private static double Prom_Mascotas(List<Mascota_Adoptada> listaMascotas)
        {
            float sum = listaMascotas.Sum(x => x.Edad);
            int Total = listaMascotas.Count;
            return (double)(sum /Total);
        }

        private static void MostrarLista(List<Mascota_Adoptada> listaMascotas)
        {
            Console.WriteLine("------------------- LISTA DE MASCOTAS ----------------");
            foreach (Mascota_Adoptada item in listaMascotas)
            {
                Console.WriteLine(item.ToString());
                
            }
        }
        private static void Raza_Chiwawa(List<Mascota_Adoptada> listaMascotas)
        {
            Console.WriteLine("---- PERRROS DE RAZA CHIWAWA Y DE SEXO FEMENINO ----");
            var listaC = from d in listaMascotas
                         where d.Raza == "chiwawa" && d.Sexo=="femenino"
                         select d;
            foreach (var item in listaC)
            {
                Console.WriteLine(item.ToString());
            }
        }
        private static void EdadMascotas(List<Mascota_Adoptada> listaMascotas)
        {
            Console.WriteLine("------------ MASCOTAS CON MENOS DE DOS AÑOS ---------");
            var ListaE = from item in listaMascotas
                         where item.Edad < 2
                         select item;
            foreach (var item in ListaE)
            {
                Console.WriteLine(item.ToString()); 
            }

        }
    }
}

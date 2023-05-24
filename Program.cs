using Poo_Estructura.Entities;
using Poo_Estructura.Services;
using System;
using System.Net.Security;
using System.Transactions;

namespace Poo_Estructura
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            AlumnoServices servicio= new AlumnoServices();
            Alumno alumno1 = servicio.Agregar();
            servicio.imprimir(alumno1);
            Console.WriteLine("La calificacion es: "+servicio.ValidarProm(7));
            


        }
    }
}

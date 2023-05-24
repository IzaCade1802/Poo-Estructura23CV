using Poo_Estructura.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Poo_Estructura.Services
{
    public class AlumnoServices
    {
        public Alumno Agregar()
        {
            try
            {
                Alumno res = new Alumno()
                {
                    Id = 1,
                    Nombre = "Aaron",
                    Apellido = "Fermin Martinez",
                    FechaIngreso = DateTime.Now,
                    Grado = 3,
                    Promedio = 9.5,
                };
                return res;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                throw new Exception("susedio un error" + ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }



        }

        public void imprimir(Alumno request)
        {
            try
            {
                Console.WriteLine("El nombre es:" + request.Nombre);
                Console.WriteLine("El apellido es:" + request.Apellido);
                Console.WriteLine("El dia de ingreso es:" + request.FechaIngreso);
                Console.WriteLine("El grado es:" + request.Grado);
            }
            catch (Exception ex)
            {
                throw new Exception("sucfedio un error" + ex.Message);
            }


        }
        #region ------ Validar Aprovaciíon
        public bool ValidarProm(double num1)
        {
            bool validar = false;
            if (num1 > 7)
            {
                validar = true;
            }
            return validar;


        }
        #endregion
    }
}
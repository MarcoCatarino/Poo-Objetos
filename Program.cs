using System;
using Objetos.Clases;

namespace Objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INSTANCIAR = Crear algo "REAL" al mandarlo a llamar dentro del programa
            Persona persona = new Persona();

            persona.ImprmirDatos();

            /* Este es el codigo en caso de que lo hicieramos 1 por 1 con valores ya definidos
             
            persona1.Nombre = "Marco";
            persona1.Apellido = "Hernandez";
            persona1.Edad = 19;
            persona1.Salario = 121313.313D;

            persona1.ImprmirDatos();

            Console.WriteLine("\n");

            Persona persona2 = new Persona();


            persona2.Nombre = "johan";
            persona2.Apellido = "La puta";
            persona2.Edad = 18;
            persona2.Salario = 00000;

            persona2.ImprmirDatos();
            
            */
        }
    }
}

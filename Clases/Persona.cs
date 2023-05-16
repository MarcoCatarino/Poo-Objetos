using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Clases
{
    // Las CLASES son plantillas y dentro de estos se encuentran OBJETOS y METODOS
    // Se debe poner PUBLIC para poder usarlo de manera libre dentro del programa (otros objetos [clases])

    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public double Salario { get; set; }
    
    
        public void ImprmirDatos()
        {
            /* Este es la forma de pedir los DATOS AL USUARIO
             
            Console.Write("Nombre = ");
            Nombre = Console.ReadLine();

            Console.Write("Apellido = ");
            Apellido = Console.ReadLine();

            Console.Write("Edad = ");
            Edad = int.Parse(Console.ReadLine());

            Console.Write("Salario = ");
            Salario = double.Parse(Console.ReadLine());

            */

            //Console.WriteLine("\n");

            /* Esta es la forma de IMPRIMIR LOS DATOS (ya sea que ya esten declarados dentro del programa o el usuario sea quien los ingrese)
             
            // El "this" sirve pra poder usar de diversas manera una varieble u objeto previamente declarado de manera corracta. [Es una buena practica]

            Console.WriteLine("Tu nombre es: " + this.Nombre);
            Console.WriteLine("Tu apellido es: " + this.Apellido);
            Console.WriteLine("Tu edad es: " +this.Edad);
            Console.WriteLine("Tu salario es: " + this.Salario);

            */

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Nombre = ");
                Nombre = Console.ReadLine();

                Console.Write("Apellido = ");
                Apellido = Console.ReadLine();

                Console.Write("Edad = ");
                Edad = int.Parse(Console.ReadLine());

                Console.Write("Salario = ");
                Salario = double.Parse(Console.ReadLine());

                Console.WriteLine("\n");

                // El "this" sirve pra poder usar de diversas manera una varieble u objeto previamente declarado de manera corracta. [Es una buena practica]
                Console.WriteLine("Tu nombre es: " + this.Nombre);
                Console.WriteLine("Tu apellido es: " + this.Apellido);
                Console.WriteLine("Tu edad es: " + this.Edad);
                Console.WriteLine("Tu salario es: " + this.Salario);

                Console.WriteLine("\n");

            }

        }
    }
}

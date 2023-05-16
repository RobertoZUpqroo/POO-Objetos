using Objetos.Clases;
using System;

namespace Objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n");

            //instanciar es crear algo real

            Persona persona = new Persona();

            persona.Nombre = "Roberto";
            persona.Apellido = "Zetina";
            persona.Edad = 22;
            persona.Salario = 10;

            persona.ImprimirDatos();

            Console.WriteLine("-------------------\n");
            Persona persona2 = new Persona();

            persona2.Nombre = "Axel";
            persona2.Apellido = "Coutiño";
            persona2.Edad = 22;
            persona2.Salario = 10;

            persona2.ImprimirDatos();

            Console.WriteLine("------------------\n");

            Persona persona3 = new Persona();

            persona3.Nombre = "Adolf";
            persona3.Apellido = "Hitler";
            persona3.Edad = 45;

            persona3.Salario = 1100000;

            persona3.ImprimirDatos();
            persona3.ImprimirDatos();
            persona3.ImprimirDatos();
            persona3.ImprimirDatos();
            persona3.ImprimirDatos();
            persona3.ImprimirDatos();

        }
    }
}

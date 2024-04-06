using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public override string ToString()
        {
            return $"Personaf nombre = {Nombre}, Edad = {Edad}";
        }
    }

    static void Main(string[] args)
    {
        Persona[] personas = new Persona[3];
        personas[0] = new Persona("Carlos", 193);
        personas[1] = new Persona("Daniel", 30);
        personas[2] = new Persona("Maria", 25);

        foreach (var persona in personas)
        {
            Console.WriteLine(persona);
        }

        Console.WriteLine($"tamaño del arreglo {personas.Length}");
    }
}


using System;

class Animal
{
    // Atributos
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Especie { get; set; }

    // Constructor

    public Animal(string nombre, int edad, string especie)
    {
        Nombre = nombre;
        Edad = edad;
        Especie = especie;
    }

    // Métodos de la clase
    public void EmitirSonido()
    {
        Console.WriteLine("El animal emite un sonido.");
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad} años, Especie: {Especie}");
    }
}

class Program
{
    static void Main()
    {
        // Ejemplo de uso
        Animal perro = new Animal("Fido", 3, "Canino");

        perro.MostrarInformacion();
        perro.EmitirSonido();
       
    }
}

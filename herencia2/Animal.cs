using System;

class Animal
{
    public string Nombre { get; set; }

    public Animal(string nombre)
    {
        Nombre = nombre;
    }

    public void EmitirSonido()
    {
        Console.WriteLine("Haciendo algún sonido...");
    }
}

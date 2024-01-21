class Perro : Animal
{
    public string Raza { get; set; }

    public Perro(string nombre, string raza) : base(nombre)
    {
        Raza = raza;
    }

    public void Ladrar()
    {
        Console.WriteLine("¡Guau! ¡Guau!");
    }
}

class Program
{
    static void Main()
    {
        // Puedes crear instancias de tus clases y llamar a métodos aquí
        Perro miPerro = new Perro("Fido", "Labrador");
        miPerro.EmitirSonido();  // Heredado de la clase Animal
        miPerro.Ladrar();        // Propio de la clase Perro
    }
}
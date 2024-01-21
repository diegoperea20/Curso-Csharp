int miNumero=10;
int miNumero2=20;
string miString="Hola mundo";
float miFloat=10.5f;
char miChar='a';
bool miBool=true;
var variable="variable";
variable="otra variable";

const int constante=10;
//print
Console.WriteLine(miNumero);
Console.WriteLine($"Mi numero es: {miNumero}"); //interpolacion de cadenas (miNumero);
Console.WriteLine("Mi numero2 es: {0} y mi numero es: {1}", miNumero, miNumero2);

Console.WriteLine($"Mi string es: {miString}");
Console.WriteLine($"Mi Float es: {miFloat}");
Console.WriteLine($"Mi Char es: {miChar}");
Console.WriteLine($"Mi Bool es: {miBool}");
Console.WriteLine($"Mi variable es: {variable}");
Console.WriteLine($"Mi constante es: {constante}");

//Convertir enteros a string
string miString2=miNumero.ToString();
Console.WriteLine($"Mi int to string es: {miString2} , y de tipo es: {miString2.GetType()}");

//Convertir string a enteros
int miInt=int.Parse(miString2);
Console.WriteLine($"Mi string to int es: {miInt} , y de tipo es: {miInt.GetType()}");

//Convertir int a float
float miFloat2=miInt;
Console.WriteLine($"Mi int to float es: {miFloat2} , y de tipo es: {miFloat2.GetType()}");


//Convertir float a int
int miInt2=(int)miFloat;
Console.WriteLine($"Mi float to int es: {miInt2} , y de tipo es: {miInt2.GetType()}");


//input 
Console.WriteLine("Escribe tu nombre : ");
string miNombre=Console.ReadLine();
Console.WriteLine($"Tu nombre es: {miNombre}");
var edad=int.Parse(Console.ReadLine());
//var edad=Convert.ToInt32(Console.ReadLine());  
Console.WriteLine($"Tu edad es: {edad}");
//Forma mas simple
int[] enteros2 = { 1, 2, 3, 4, 5 };

Console.WriteLine($"enteros2[0] = {enteros2[0]}");
Console.WriteLine($"enteros2[1] = {enteros2[1]}");
Console.WriteLine($"enteros2[2] = {enteros2[2]}");
Console.WriteLine($"enteros2[3] = {enteros2[3]}");
Console.WriteLine($"enteros2[4] = {enteros2[4]}");


//iterar elementos
for(int i =0; i<enteros2.Length; i++)
{
    Console.WriteLine($"enteros2[{i}] = {enteros2[i]}");
}



Console.WriteLine("Forma no simple");
//Forma NO simple
int[] enteros;

enteros= new int[5];

//modificar valores de arreglo
enteros[0] = 1;
enteros[1] = 2;
enteros[2] = 3;
enteros[3] = 4;
enteros[4] = 5;

//print
Console.WriteLine($"enteros[0] = {enteros[0]}");
Console.WriteLine($"enteros[1] = {enteros[1]}");
Console.WriteLine($"enteros[2] = {enteros[2]}");
Console.WriteLine($"enteros[3] = {enteros[3]}");
Console.WriteLine($"enteros[4] = {enteros[4]}");


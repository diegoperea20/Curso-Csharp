var numero = 4;

// Operador condicional if
if (numero > 5)
{
    Console.WriteLine("El numero es mayor a 5");
}
else if(numero < 5)
{
    Console.WriteLine("El numero es menor 5");
}
else
{
    Console.WriteLine("El numero es igual a 5");
}


// Operador ternario
Console.WriteLine(numero > 5 ? "El numero es mayor a 5" : "El numero es menor a 5");


//operador while
int contador =0 , repeticiones =3;
while(contador < repeticiones)
{
    Console.WriteLine(contador);
    contador++;
}

//operador for
for (int i = 0; i < repeticiones; i++)
{
    Console.WriteLine(i);
}

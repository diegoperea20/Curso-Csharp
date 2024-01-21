
//Forma simple de hacer la matriz

int [,] matriz2 = {
    {
        1,2,3
    },
    {
        4,5,6
    }
};

Console.WriteLine(matriz2 [0, 0]);

//iterar matriz
for (int ren =0; ren < 2; ren++)
{
    for (int col = 0; col < 3; col++)
    {
        Console.WriteLine(matriz2 [ren, col]);
    }
}





//Forma NO simple de hacer la matriz

const int RENGLONES = 2;
const int COLUMNAS = 3;

//definir la matriz
int [,] matriz = new int [RENGLONES, COLUMNAS];

//llenar los elementos de la matriz

matriz [0, 0] = 1;
matriz [0, 1] = 2;
matriz [0, 2] = 3;
matriz [1, 0] = 4;
matriz [1, 1] = 5;
matriz [1, 2] = 6;

Console.WriteLine("forma no simple");
Console.WriteLine(matriz [0, 0]);




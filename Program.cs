
using System;

static void imprimirNotas(int[] notasx)
{
    for (int i = 0; i < notasx.Length; i++)
    {
    System.Console.WriteLine($"nota {i + 1}: {notasx[i]}");
    }
}

static double PromedioNotas(int[] notasx)
{
    int suma = 0;
    for (int i = 0; i < notasx.Length; i++)
    {
        suma += notasx[i];
    }
    return (double)suma / notasx.Length;
}

int [] notas = {15,18,12,17,20};
imprimirNotas(notas);

double promedio =  PromedioNotas(notas);
System.Console.WriteLine($"Promedio de las notas: {promedio:F2}");
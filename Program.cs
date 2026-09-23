
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

static int NotaMinima(int[] notasx)
{
    int min = notasx[0];
    for (int i = 0; i < notasx.Length; i++)
    {
        if (notasx[i] < min)
        {
            min = notasx[i];
        }
    }
    return min;
}

static int NotaMaxima(int[] notasx)
{
    int max = notasx[0];
    for (int i = 0; i < notasx.Length; i++)
    {
        if (notasx[i] > max)
        {
            max = notasx[i];
        }
    }
    return max;
}

int [] notas = {15,18,12,17,20};
imprimirNotas(notas);

double promedio = PromedioNotas(notas);
System.Console.WriteLine($"Promedio de las notas: {promedio:F2}");

int min = NotaMinima(notas);
int max = NotaMaxima(notas);
Console.WriteLine($"Mínimo: {min}");
Console.WriteLine($"Máximo: {max}");

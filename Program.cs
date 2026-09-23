
using System.Diagnostics.CodeAnalysis;

static void imprimirNotas(int[] notas)
{
    for (int i = 0; 0 < notas.Length; i++)
    {
    System.Console.WriteLine($"nota {i + 1}: {notas[i]}");
    }
}

int [] notas = {15,18,12,17,20};
imprimirNotas(notas);
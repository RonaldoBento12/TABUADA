using System;
using System.Collections.Generic;

class Tabuada
{
    public static List<int> CalcularTabuada(int numero)
    {
        List<int> tabuada = new List<int>();
        for (int i = 1; i <= 10; i++)
        {
            tabuada.Add(numero * i);
        }
        return tabuada;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int numeroDesejado = 18;
        List<int> tabuadaDezoito = Tabuada.CalcularTabuada(numeroDesejado);

        Console.WriteLine($"Tabuada do número {numeroDesejado}:");
        foreach (int resultado in tabuadaDezoito)
        {
            Console.WriteLine(resultado);
        }
    }
}
using System;
using System.Collections.Generic;
using TABUADA;
class Program
{
    static void Main(string[] args)
    {
        int numeroDesejado = 2;
        var tabuada = new Tabuada();
        List<int> tabuadaDezoito = Tabuada.CalcularTabuada(numeroDesejado);

        Console.WriteLine($"Tabuada do número {numeroDesejado}:");
        foreach (int resultado in tabuadaDezoito)
        {
            Console.WriteLine(resultado);
        }
    }
}
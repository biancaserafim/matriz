using System;
using MinhaBiblioteca;

class atv08

{
    static void Main()
    {
        int x, y, quantidadeRaios;
        int linhas, cols;

        Console.WriteLine("Digite a quantidade de linhas:");
        linhas = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quantidade de colunas:");
        cols = int.Parse(Console.ReadLine());

        int[,] mapa = new int[linhas, cols];

        Console.WriteLine("Quantos raios foram anotados?");
        quantidadeRaios = int.Parse(Console.ReadLine());

        for (int i = 0; i < quantidadeRaios; i++)
        {
            Console.WriteLine("Digite as coordenadas do raio (linha e coluna):");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x >= 0 && x < linhas && y >= 0 && y < cols)
            {
                mapa[x, y]++;
            }
        }

        Biblioteca.mostrarMatriz(mapa);
    }
}

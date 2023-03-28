using System;

class Program
{
    static void Main(string[] args)
    {
        // exemplo de matriz de entrada
        int[,] matriz = new int[,]
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int numLinhas = matriz.GetLength(0); // número de linhas da matriz
        int numColunas = matriz.GetLength(1); // número de colunas da matriz

        // chamando a função para contar os pares e ímpares
        int qtdMaiorOcorrencia = ContagemParesImpares(matriz, numLinhas, numColunas);

        Console.WriteLine("Quantidade do número com maior ocorrência: " + qtdMaiorOcorrencia);
    }

    public static int ContagemParesImpares(int[,] matriz, int numLinhas, int numColunas)
    {
        int qtdPares = 0;
        int qtdImpares = 0;

        for (int i = 0; i < numLinhas; i++)
        {
            for (int j = 0; j < numColunas; j++)
            {
                if (matriz[i, j] % 2 == 0)
                {
                    qtdPares++;
                }
                else
                {
                    qtdImpares++;
                }
            }
        }

        if (qtdPares > qtdImpares)
        {
            return qtdPares;
        }
        else
        {
            return qtdImpares;
        }
    }
}

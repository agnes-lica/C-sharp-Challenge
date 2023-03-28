using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Digite a posição desejada na sequência de Fibonacci: ");
        int posicao = int.Parse(Console.ReadLine());

        int numeroAnterior = 0;
        int numeroAtual = 1;
        int proximoNumero;

        if (posicao == 0) {
            Console.WriteLine("0");
        } else if (posicao == 1) {
            Console.WriteLine("1");
        } else {
            for (int i = 2; i <= posicao; i++) {
                proximoNumero = numeroAnterior + numeroAtual;
                numeroAnterior = numeroAtual;
                numeroAtual = proximoNumero;
            }
            Console.WriteLine(numeroAtual);
        }
    }
}

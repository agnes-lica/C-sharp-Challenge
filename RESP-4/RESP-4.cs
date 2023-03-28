using System;

public abstract class Carro {
    public int numeroChassi;
    public int numeroMotor;
    public double custoProducao;

    public Carro(int numeroChassi, int numeroMotor, double custoProducao) {
        this.numeroChassi = numeroChassi;
        this.numeroMotor = numeroMotor;
        this.custoProducao = custoProducao;
    }

    public abstract double calcularImposto();
    public abstract double calcularCustoVenda();
}

public class CarroFlex : Carro {
    public int numeroPortas;
    public int cilindrada;

    public CarroFlex(int numeroChassi, int numeroMotor, int numeroPortas, int cilindrada, double custoProducao) : base(numeroChassi, numeroMotor, custoProducao) {
        this.numeroPortas = numeroPortas;
        this.cilindrada = cilindrada;
    }

    public override double calcularImposto() {
        return custoProducao * 0.2;
    }

    public override double calcularCustoVenda() {
        return custoProducao + calcularImposto() + (custoProducao * 0.25);
    }
}

public class CarroDiesel : Carro {
    public int capacidadeCarga;
    public int volumeCacamba;

    public CarroDiesel(int numeroChassi, int numeroMotor, int capacidadeCarga, int volumeCacamba, double custoProducao) : base(numeroChassi, numeroMotor, custoProducao) {
        this.capacidadeCarga = capacidadeCarga;
        this.volumeCacamba = volumeCacamba;
    }

    public override double calcularImposto() {
        return custoProducao * 0.3;
    }

    public override double calcularCustoVenda() {
        return custoProducao + calcularImposto() + (custoProducao * 0.25);
    }
}

public class CarroEletrico : Carro {
    public int potencia;
    public int duracaoBateria;

    public CarroEletrico(int numeroChassi, int numeroMotor, int potencia, int duracaoBateria, double custoProducao) : base(numeroChassi, numeroMotor, custoProducao) {
        this.potencia = potencia;
        this.duracaoBateria = duracaoBateria;
    }

    public override double calcularImposto() {
        return custoProducao * 0.1;
    }

    public override double calcularCustoVenda() {
        return custoProducao + calcularImposto() - (custoProducao * 0.25);
    }
}

class Program {
    static void Main(string[] args) {
        CarroFlex carro1 = new CarroFlex(123, 456, 4, 1500, 20000);
        CarroDiesel carro2 = new CarroDiesel(789, 321, 1000, 200, 30000);
        CarroEletrico carro3 = new CarroEletrico(456, 987, 200, 1000, 40000);

        Console.WriteLine("Custo de venda do carro flex: " + carro1.calcularCustoVenda());
        Console.WriteLine("Custo de venda do carro diesel: " + carro2.calcularCustoVenda());
        Console.WriteLine("Custo de venda do carro elétrico: " + carro3.calcularCustoVenda());
    }
}


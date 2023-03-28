Esse repositório contem as respostas da prova de programação da Adisra em C#

As respostas estão cada uma em uma pasta e um arquivo específico juntamente com seu arquivo .exe

Cada pergunta terá o nome RESP-# e estará descrita abaixo de cada questão nesse README. Menos a da questão 3 que está descrita abaixo dela.

Nome:AGNES MARQUES ROGÉRIO Data: 28/03/23

1- Escreva um programa em que o usuário entre com um número, que é uma posição, e
obtenha como resposta qual é o número da sequência de Fibonacci na posição solicitada.

- A Sequência de Fibonacci é formada começando por 0 e 1 e os demais números são a
  soma dos dois precedentes. (0, 1, 1, 2, 3, 5 ...)

RESP-1

2- Uma função recebe por parâmetros uma matriz de entrada, o número de linhas e o
número de colunas, processa todos os números contando os pares e os ímpares e retorna
a quantidade do que tiver maior quantidade de ocorrências. Escreva essa função.

RESP-2

3- Qual o resultado em tela apresentado pelo programa abaixo?
int ff( int n)
{
if (n == 1) return 1;
if (n % 2 == 0) return ff( n/2);
return ff( (n-1)/2) + ff( (n+1)/2);
}
void main() {
printf( "%d", ff(7));
return;
}

A resposta é: 3

Isso acontece porque quando chamamos a função dando o valor impar 7 para ela, ele executa o segundo if e chama a função duas vezes. Na primeira chamada a função é executada novamente agora com o número impar 3 como parâmetro. E ele executa duas vezes novamente, dessa vez retornando o numero 1, que é o resultado base de n==1.

Na segunda chamada a função é executada com um número par, então ela executa o primeiro if e chama a função novamente com n/2=1. Como n agora é igual a 1, a função retorna 1.

Somando os valores retornados temos 1+1+1 = 3.

No arquivo RESP-3

4- Em uma fábrica de automóveis são fabricados carros flex (alcool e gasolina), diesel e
elétricos. Todos os carros fabricados levam em consideração uma série de fatores e cada
um tem dados a serem armazenados.

- Os carros flex tem ( número do chassi, número do motor, número de portas, cilindrada,
  custo de produção).
- Os carros diesel tem ( número do chassi, número do motor, capacidade de carga, volume
  da caçamba, custo de produção).
- Os carros elétricos tem ( número do chassi, número do motor, potência, duração da
  bateria, custo de produção).
  Todos os carros tem imposto de produção fixado em 20%. Os carros à diesel, por serem
  mais poluentes e utilizados para trabalho, tem um acréscimo de 10%, ficando seu imposto
  em 30%. Os carros elétricos tem um incentivo e seu imposto tem um decréscimo de 10%,
  ficando seu imposto em 10%.
  A fábrica tem sobre todos os automóveis um lucro de 25%.
  Modele as classes necessárias, com seus atributos e uma função para calcular o custo de
  venda de cada veículo. O custo de venda é obtido a partir da conta custo de produção +
  imposto + lucro da fábrica. Tanto o imposto quanto o lucro são calculados a partir do custo
  de produção e não são sobrepostos.

RESP-4

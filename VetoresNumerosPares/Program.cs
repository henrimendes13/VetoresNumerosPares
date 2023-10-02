/*Faça um programa que leia N números inteiros e armazene-os em um vetor. 
Em seguida, mostre na tela todos os números pares e a quantidade de números pares*/

Console.WriteLine("Escreva a quantidade de Numeros");
int N;
N = int.Parse(Console.ReadLine());

Console.WriteLine("Escreva os numeros");
int[] Vet = new int[N];

for (int i = 0; i < N; i++)
{
    Vet[i] = int.Parse(Console.ReadLine());
}

int qtdnumerospares = 0;

Console.WriteLine("Numeros pares:");
for (int i = 0; i < N; i++)
{
    if (Vet[i] % 2 == 0)
    {
       
        Console.WriteLine(Vet[i]); 
        qtdnumerospares++;
    }
}
Console.WriteLine($"Quantidade de números pares: {qtdnumerospares}");
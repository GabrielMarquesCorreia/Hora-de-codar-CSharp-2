Console.WriteLine("Soma de 10 números");

float soma = 0;

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Escreva o {i}° número: ");
    float num = float.Parse( Console.ReadLine() );
    soma += num;
};

Console.WriteLine($"A soma de todos esses números é igual a: {soma}");

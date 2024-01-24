Console.WriteLine("Maior, menor, soma");

double soma = 0;
int num = 0;
int n1 = 0;
int n2 = 0;
int n3 = 0;
int n4 = 0;
double maior = 0;
double menor = 0;

for (int i = 1; i <= 4; i++)
{
    Console.Write($"Informe o {i}° número: ");
    num = int.Parse( Console.ReadLine() );

    if (i == 1)
    {
        n1 = num;
    }
    if (i == 2)
    {
        n2 = num;
    }
    if (i == 3)
    {
        n3 = num;
    }
    if (i == 4)
    {
        n4 = num;
    }

    // Maior

    if (n1 > n2 & n1 > n3 & n1 > n4)
    {
        maior = n1;
    }
    if (n1 < n2 & n2 > n3 & n2 > n4)
    {
        maior = n2;
    }
    if (n1 < n3 & n2 < n3 & n3 > n4)
    {
        maior = n3;
    }
    if (n1 < n4 & n4 > n3 & n2 < n4)
    {
        maior = n4;
    }
    else
    {
        maior = n4;
    }

    // Menor

    if (n1 < n2 & n1 < n3 & n1 < n4)
    {
        menor = n1;
    }
    if (n1 > n2 & n2 < n3 & n2 < n4)
    {
        menor = n2;
    }
    if (n1 > n3 & n2 > n3 & n3 < n4)
    {
        menor = n3;
    }
    if (n1 > n4 & n4 < n3 & n2 > n4)
    {
        menor = n4;
    }
    else
    {
        menor = n4;
    }
}

soma = n1 + n2 + n3 + n4;


Console.WriteLine($"O maior número informado foi {maior}, o menor foi {menor} e a soma de todos é igual a: {soma}");

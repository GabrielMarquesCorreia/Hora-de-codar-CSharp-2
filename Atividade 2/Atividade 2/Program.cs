Console.WriteLine("Olá, esse programa irá dizer o maior número entre 3 que você escrever");

float cont = 1;
float maior = 0;

while (cont <= 3)
{
    Console.WriteLine("Por favor informe um número: ");
    float n1 = float.Parse(Console.ReadLine());

    if (n1 > maior)
    {
        maior = n1;
    }
    else if (n1 == maior)
    {
        Console.WriteLine("OPA! Por favor, informe um valor diferente!");
        cont--;
    }
    cont++;
};

Console.WriteLine($"O maior valor informado é... {maior}");

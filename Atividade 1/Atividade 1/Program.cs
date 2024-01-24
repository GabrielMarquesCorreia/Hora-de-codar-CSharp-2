Console.WriteLine("Maior, menor, igual a 0");

int cont = 0;

while (cont < 1)
{
    Console.WriteLine("Olá! Escreva um número e nós diremos se ele é maior, menor ou igual a 0");
    float n1 = float.Parse(Console.ReadLine()); 

    if (n1 > 0)
    {
        Console.WriteLine($"O número {n1} é maior que zero!");
    } 
    else if (n1 < 0)
    {
        Console.WriteLine($"O número {n1} é menor que zero!");
    }
    else
    {
        Console.WriteLine($"O número {n1} é igual que zero!");
    }

    cont++;
}
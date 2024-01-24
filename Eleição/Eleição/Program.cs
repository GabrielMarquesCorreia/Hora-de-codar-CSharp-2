Console.WriteLine("Eleição");

Console.Write("Olá! Digite o seu ano de nascimento: ");
float year = float.Parse(Console.ReadLine());

double age = 2024 - year;

if (age >= 18)
{
    Console.WriteLine($"Você nasceu no ano de {year}, isso significa que você tem {age} anos. Parabéns! Você já pode votar!");
} else if (age == 16)
{
    Console.WriteLine($"Você nasceu no ano de {year}, isso significa que você tem {age} anos. Você até tem idade para votar mas são necessárias as autorizações dos seus responsáveis.");
}
else
{
    Console.WriteLine($"Você nasceu no ano de {year}, isso significa que você tem {age} anos. Você ainda não tem idade para votar.");
}

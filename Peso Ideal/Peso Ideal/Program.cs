Console.WriteLine("Peso ideal");

Console.Write("Escreva qual o seu gênero biológico m(masculino) f(feminino): ");
string g = Console.ReadLine();

Console.Write("Agora escreva a sua altura (ex: 1,80): ");
float h = float.Parse(Console.ReadLine());

if (g == "m")
{
    double p = (72.7 * h) - 58;
    Console.WriteLine($"Você é biológicamente do gênero masculino e mede cerca de {h.ToString("N2")} metros de altura. Ou seja, o peso ideal para você é {p.ToString("N1")} quilos.");
}
if (g == "f")
{
    double p = (62.1 * h) - 44.7;
    Console.WriteLine($"Você é biológicamente do gênero feminino e mede cerca de {h.ToString("N2")} metros de altura. Ou seja, o peso ideal para você é {p.ToString("N1")} quilos.");
}


Console.WriteLine("Aprovado / Reprovado");

double soma = 0;
double media = 0;

for (int i = 1; i < 6; i++)
{
    Console.WriteLine($"Informe a sua {i}° nota: ");
    float nota = float.Parse( Console.ReadLine() );
    soma += nota;
    media = soma / 5;
}

if (media >= 6.0)
{
    Console.WriteLine($"A sua média é igual a: {media.ToString("N2")}. Parabéns! Você foi aprovado!");
}
else if (media < 6.0)
{
    Console.WriteLine($"A sua média é igual a: {media.ToString("N2")}. Você foi reprovado! Parabéns! Se esforce mais da próxima vez!");
}

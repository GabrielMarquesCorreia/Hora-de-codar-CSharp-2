Console.WriteLine($"Boletim");

Console.Write("Informe o nome do aluno: ");
string name = Console.ReadLine();

Console.Write("Escreva a nota do aluno em português: ");
float n1 = float.Parse( Console.ReadLine() );

Console.Write("Escreva a nota do aluno em matemática: ");
float n2 = float.Parse(Console.ReadLine());

Console.Write("Escreva a nota do aluno em inglês: ");
float n3 = float.Parse(Console.ReadLine());

Console.Write("Escreva a nota do aluno em filosofia: ");
float n4 = float.Parse(Console.ReadLine());

Console.Write("Escreva a nota do aluno em informática: ");
float n5 = float.Parse(Console.ReadLine());

double r = (n1 + n2 + n3 + n4 + n5) / 5;

if (r >= 6)
{
    Console.WriteLine($"A média final do aluno {name} é igual a: {r.ToString("N1")}. O aluno foi aprovado.");
}
else
{
    Console.WriteLine($"A média final do aluno {name} é igual a: {r.ToString("N2")}. O aluno foi reprovado.");
}

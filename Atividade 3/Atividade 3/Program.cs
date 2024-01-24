Console.WriteLine("Ola, esse programa irá pegar 10 valores e informar a média desses valores");

double cont = 1;
double soma = 0;
// double numb = 0;
double media = 0;

while (cont <= 10)
{
    Console.WriteLine($"Por favor informe um valor {cont}: ");
    float numb = float.Parse(Console.ReadLine());
    soma += numb;
    media = (soma) / 10;
    cont++;
};

Console.WriteLine($"A média deste valores somados é igual a: {media}");
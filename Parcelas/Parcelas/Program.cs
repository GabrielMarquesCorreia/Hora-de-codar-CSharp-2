Console.WriteLine("PROMOÇÃO NA LOJA REMI du FROMAGE! CADA PC GAMER POR APENAS R$3600. O GERENTE FICOU MALUCO! PODE PARCELAR EM ATÉ 15VEZES SEM JUROS!");

while (true)
{
    Console.Write("Informe em quantas vezes você gostaria de parcelar o produto: ");
    int p = int.Parse(Console.ReadLine());

    if (p > 1 & p <= 15)
    {
        double r = 3600 / p;
        Console.WriteLine($"Você decidiu parcelar o produto em {p}X, portanto você ficou R${r} por mês.");
        break;
    }
    else
    {
        Console.WriteLine("Por favor informe um valor diferente (lembrando que o máximo de parcelas é de 15X): ");
    } 
}


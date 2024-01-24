Console.WriteLine("Corinthians VS Palmeiras\r\n");

Console.Write("Escreva quantas vitórias o Corinthians tem no Derby Paulista: ");
int corV = int.Parse(Console.ReadLine());

Console.Write("Agora escreva quantas vitórias o Palmeiras tem no Derby Paulista: ");
int palV = int.Parse(Console.ReadLine());

if (corV > palV)
{
    Console.WriteLine($"O Sport Club Corinthians Paulista têm mais vitórias no Derby Paulista, um surpreendente total de {corV} vitórias! Por isso o Palmeiras é um grande freguês do Corinthians!\r\n");
}
else if (corV < palV)
{
    Console.WriteLine($"A Sociedade Esportiva Palmeiras têm mais vitórias no Derby Paulista, um surpreendente total de {palV} vitórias! Por isso o Corinthians é um grande freguês do Palmeiras!\r\n");
}
else
{
    Console.WriteLine($"Ambos os times tem um total de {corV} vitórias no Derby Paulista.\r\n");
}

Console.Write("Agora escreva quantos gols o Palmeiras tem no Derby Paulista: ");
int palG = int.Parse(Console.ReadLine());

Console.Write("Agora escreva quantos gols o Corinthians tem no Derby Paulista: ");
int corG = int.Parse(Console.ReadLine());

if (corG > palG)
{
    Console.WriteLine($"O Sport Club Corinthians Paulista têm mais gols no Derby Paulista, um surpreendente total de {corG} gols! Por isso o Palmeiras é um grande freguês do Corinthians no quesito gols!\r\n");
}
else if (corG < palG)
{
    Console.WriteLine($"A Sociedade Esportiva Palmeiras têm mais gols no Derby Paulista, um surpreendente total de {palG} gols! Por isso o Corinthians é um grande freguês do Palmeiras no quesito gols!\r\n");
}
else
{
    Console.WriteLine($"Ambos os times tem um total de {palG} gols no Derby Paulista.\r\n");
}

if (corV > palV & corG > palG )
{
    Console.WriteLine($"O Corinthias tem mais gols({corG}) e mais vitórias({corV}) no Derby Paulista, portanto o Sport Club Corinthians Paulista é o rei do clássico Derby Paulista!\r\n");
} 
else if (corV < palV & corG < palG)
{
    Console.WriteLine($"O Palmeiras tem mais gols({palG}) e mais vitórias({palV}) no Derby Paulista, portanto a Sociedade Esportiva Palmeiras é o rei do clássico Derby Paulista!\r\n");
}
else if (corV == palV & corG == palG)
{
    Console.WriteLine($"Tanto o Palmeiras quanto o Corinthias têm um total de {palV} vitórias e um total de {corG} gols no Derby Paulista, portanto não temos como dizer quem domina o clássico.\r\n");
}
else
{
    Console.WriteLine("Um time domina no quesito gol, o outro domina nas vitórias. Portanto não temos como dizer quem domina o clássico.\r\n ");
}

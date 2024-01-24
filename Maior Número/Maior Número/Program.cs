Console.WriteLine("Maior número\r\n");

int a = 0;
int b = 0;
int c = 0;

for (int i = 1; i <= 3; i++)
{
    Console.Write($"Informe o {i}° número: ");
    int num = int.Parse( Console.ReadLine() );
    if (i == 1)
    {
        a = num;
    }
    else if (i == 2)
    {
        b = num;
    }
    else
    {
        c = num;
    }

}

if (a > b && a > c)
{
    Console.WriteLine($"O maior número informado foi: {a}");
}
else if (a < b && b > c)
{
    Console.WriteLine($"O maior número informado foi: {b}");
}
else
{
    Console.WriteLine($"O maior número informado foi: {c}");
}
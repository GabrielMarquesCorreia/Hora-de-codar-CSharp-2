Console.Write("Digite a sua senha: ");

int senha = int.Parse(Console.ReadLine());

if (senha == 1234)
{
    Console.WriteLine("Senha correta, acesso permitido. Bem-Vindo ao servidor!");
}
else
{
    Console.WriteLine("SENHA INCORRETA!!! ACESSO NEGADO!!! CHAMANDO A POLÍCIA!!!!");
}

Console.WriteLine("Corrida\r\n");

Console.WriteLine("A equipe Mercedes deseja calcular o número mínimo de litros que deverá colocar no tanque de seu carro para que ele possa percorrer um determinado número de voltas até o primeiro reabastecimento.\r\n");

Console.Write("Escreva o tamanho da pista de corrida: ");
float pista = float.Parse(Console.ReadLine());

Console.Write("Agora escreva quantas voltas o carro de corrida tem que percorrer ganhar o grande premio : ");
float voltas = float.Parse(Console.ReadLine());

Console.Write("Agora escreva quantas vezes o corredor e a equipe desejam reabester o tanque do carro : ");
float tanque = float.Parse(Console.ReadLine());

Console.Write("Agora escreva quantos litros de gasolina o carro gastou : ");
float gasosa = float.Parse(Console.ReadLine());

double totalKm = (pista * voltas) * 1000;
double lMinimo = (totalKm / tanque) * gasosa;
double lTotal = totalKm * gasosa;

Console.WriteLine($"O tamanho total desse circuito é : {totalKm}km\r\n");
Console.WriteLine($"O minimo de litos de gasolina que o carro pode gastar ate o primeiro reabastecimento\r\n (Considerando que o carro reabastece depois de cada volta) é : {lMinimo} litros\r\n");
Console.WriteLine($"O total de litros necessarios para o carro completar o circuito é : {lTotal} litros\r\n");

using System.Security.Cryptography;

Console.WriteLine("----QuenteFrio----");
Console.WriteLine("\nTente acertar o número sorteado pelo jogo de 1 A 100");
Console.WriteLine("Você terá 7 tentativas para acertar!\n");

int sorteado;
sorteado = RandomNumberGenerator.GetInt32(1, 101);
Console.WriteLine($"{sorteado}");

Console.Write("De seu palpite...: ");
int palpite = Convert.ToInt32(Console.ReadLine());

int erro = palpite - sorteado;
int distanciaErro = Math.Abs(erro);

// Console.WriteLine($"{distanciaErro}");

// while(palpite == sorteado)
// {
//     Console.Write("De seu palpite...: ");
// palpite = Convert.ToInt32(Console.ReadLine());

// int erro = palpite - sorteado;
// int distanciaErro = Math.Abs(erro);

// Console.WriteLine($"{distanciaErro}");
// }
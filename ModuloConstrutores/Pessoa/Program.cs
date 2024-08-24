
using Exemplo.Models;

Pessoa p1 = new();

Console.WriteLine("Insira seu Nome: ");
p1.Nome = Console.ReadLine();
Console.WriteLine("Insira sua Idade: ");
p1.Idade = Convert.ToInt16(Console.ReadLine());

p1.Apresentar();

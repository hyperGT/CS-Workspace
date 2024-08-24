using System.Data.Common;
using MyGameList.Common.Models;


GamesLinks game = new();

var rnd = new Random();

int i = 1;
while(i<=2){
    
    Console.WriteLine("Insira o nome do Jogo");

    game.GamesList.Add(Console.ReadLine() ?? "Entrada inválida"); // list 
    game.IdList.Append(rnd.Next()); // array
    
    i++;
}

game.GetGamesList();
using Facade;

ScoreClienteFacade facade = new();
var score = facade.Score("99999999999", "565245865");

Console.WriteLine("O Score do cliente é: " + score);
// See https://aka.ms/new-console-template for more information


using Exercism_football_Match;

var football = PlayeAnalyzer.AnalyzeOffField(10);
Console.WriteLine(football);

var player = PlayeAnalyzer.AnalyzeOffField(new Manager("José Mário dos Santos Mourinho Félix", null));
Console.WriteLine(player);
var p = PlayeAnalyzer.AnalyzeOffField(new Manager("Jürgen Klopp", "Liverpool"));
Console.WriteLine(p);
var foul = PlayeAnalyzer.AnalyzeOffField(new Foul());
Console.WriteLine(foul);
Console.ReadKey();

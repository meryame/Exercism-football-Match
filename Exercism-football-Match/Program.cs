// See https://aka.ms/new-console-template for more information


using Exercism_football_Match;

var football = PlayAnalyzer.AnalyzeOffField(10);
Console.WriteLine(football);

var player = PlayAnalyzer.AnalyzeOffField(new Manager("José Mário dos Santos Mourinho Félix", null));
Console.WriteLine(player);
var p = PlayAnalyzer.AnalyzeOffField(new Manager("Jürgen Klopp", "Liverpool"));
Console.WriteLine(p);
var foul = PlayAnalyzer.AnalyzeOffField(new Foul());
Console.WriteLine(foul);
Console.ReadKey();

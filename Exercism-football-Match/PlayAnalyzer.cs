using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism_football_Match
{
    public class PlayAnalyzer
    {
        public static string AnalyzeOnField(int shirtNum)
       => (shirtNum) switch
       {
           1 => "goalie",
           2 => "left back",
           3 or 4 => "center back",
           5 => "right back",
           6 or 7 or 8 => "midfielder",
           9 => "left wing",
           10 => "striker",
           11 => "right wing",
           _ => throw new ArgumentException("invalid info for player"),
       };

        public static string AnalyzeOffField(object report) => (report) switch
        {
            int player => AnalyzeOnField(player),
            string str => str,
            Foul foul => foul.GetDescription(),
            Incident incident => incident.GetDescription(),
            Manager manager => (manager.Name == string.Empty) ? "the manager" : manager.Name,
            _ => throw new ArgumentException("Invalid object"),
        };
    }
    public class Manager
    {
        public string Name { get; }
        public string Activity { get; }
        public Manager(string name, string activity)
        {
            this.Name = name;
            this.Activity = activity;
        }
    }
    public class Incident
    {
        public virtual string GetDescription() => "An incident happened.";
    }
    public class Foul : Incident
    {
        public override string GetDescription() => "The referee deemed a foul.";
    }
    public class Injury : Incident
    {
        public override string GetDescription() => "A player is injured.";
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal abstract class Treasure : Collectable
    {
        public int Score { get; set; }
        public Treasure(string description, int score):base(description)
        {
            Score = score;
        }
        public void UpdateTotalScore()
        {
            Board.TotalScore += Score;
            Console.WriteLine($"Total Score is updated to: {Board.TotalScore}");
        }

        public override void AddMe(List<Collectable> collectables)
        {
            base.AddMe(collectables);
            Console.WriteLine($"{Description} Collected, Congrats!!!!");
            UpdateTotalScore();
        }
    }
}

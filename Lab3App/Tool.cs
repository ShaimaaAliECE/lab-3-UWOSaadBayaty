using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal abstract class Tool : Collectable
    {
        public Tool(string description) : base(description) { }
        public override void AddMe(List<Collectable> collectables) 
        { 
            collectables.Add(this);
            Console.WriteLine($"{Description} Collected, Congrats!!!!");
            DoAction();
        }

        public abstract void DoAction();
    }
}

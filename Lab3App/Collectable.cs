using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    internal abstract class Collectable:Displayable
    {
        public CollectionBoard Board { get; set; }

        public string Description { get; set; }
        public Collectable(string description) { this.Description = description; }

        public virtual void AddMe(List<Collectable> collectables) { }

        public abstract void Display();
    }
}

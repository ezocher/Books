using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Reference
{
    public class Container
    {
        public string Name { get; private set; }
        private static int nextIdNumber = 1;        // Used to uniquely name a Container when a name is not specified

        public double Amount { get; private set; }

        HashSet<Container> group;

        public Container()
        {
            group = new HashSet<Container>();
            group.Add(this);
            Name = nextIdNumber++.ToString();
        }

        public Container(string name)
        {
            group = new HashSet<Container>();
            group.Add(this);
            Name = name;
        }

        public void ConnectTo(Container other)
        {
            Display.Connect(this, other);

            // Check to see if these containers are already connected
            if (this.group == other.group) return;

            double newAmount = ((Amount * group.Count) + (other.Amount * other.group.Count)) / (group.Count + other.group.Count);
            group.UnionWith(other.group);

            foreach (Container container in other.group)
                container.group = this.group;

            foreach (Container container in group)
                container.Amount = newAmount;
        }

        public void AddOrRemoveWater(double amount)
        {
            Display.AddOrRemoveWater(amount, this);

            double newAmount = (amount + (Amount * group.Count))/ group.Count;
            if (newAmount < 0.0) newAmount = 0.0;

            foreach (Container container in group)
                container.Amount = newAmount;
        }
    }
}

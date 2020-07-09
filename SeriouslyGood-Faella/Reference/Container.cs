using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Reference
{
    public class Container
    {
        private string name;
        private static int nextIdNumber = 1;        // Used to uniquely name a Container when a name is not specified
        private double amount;
        HashSet<Container> group;

        public Container()
        {
            group = new HashSet<Container>();
            group.Add(this);
            name = nextIdNumber++.ToString();
        }

        public Container(string name)
        {
            group = new HashSet<Container>();
            group.Add(this);
            this.name = name;
        }

        public string getName() => name;

        public double getAmount() => amount;

        public void connectTo(Container other)
        {
            Display.Connect(this, other);

            // Check to see if these containers are already connected
            if (this.group == other.group) return;

            double newAmount = ((amount * group.Count) + (other.amount * other.group.Count)) / (group.Count + other.group.Count);
            group.UnionWith(other.group);

            foreach (Container container in other.group)
                container.group = this.group;

            foreach (Container container in group)
                container.amount = newAmount;
        }

        public void addOrRemoveWater(double amount)
        {
            Display.AddOrRemoveWater(amount, this);

            double newAmount = (amount + (this.amount * group.Count))/ group.Count;
            if (newAmount < 0.0) newAmount = 0.0;

            foreach (Container container in group)
                container.amount = newAmount;
        }
    }
}

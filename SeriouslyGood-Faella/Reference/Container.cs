using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Reference
{
    public class Container
    {
        private double amount;
        HashSet<Container> group;

        public Container()
        {
            group = new HashSet<Container>();
            group.Add(this);
        }

        public double getAmount() => amount;

        public void connectTo(Container other)
        {
            // Check to see if these containers are already connected
            if (this.group == other.group) return;

            double newAmount = ((amount * group.Count) + (other.amount * other.group.Count)) / (group.Count + other.group.Count);
            group.UnionWith(other.group);

            foreach (Container container in group)
            {
                container.amount = newAmount;
                container.group = this.group;
            }
        }

        public void addOrRemoveWater(double amount)
        {
            double newAmount = (amount + (this.amount * group.Count))/ group.Count;
            if (newAmount < 0.0) newAmount = 0.0;

            foreach (Container container in group)
                container.amount = newAmount;
        }
    }
}

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
            if (group.Contains(other)) return;

            double newAmountPerContainer = ((amount * group.Count) + (other.amount * other.group.Count)) / (group.Count + other.group.Count);
            foreach (Container container in other.group)
                this.group.Add(container);

            foreach (Container container in group)
            {
                container.amount = newAmountPerContainer;
                container.group = this.group;
            }
        }

        public void addOrRemoveWater(double amount)
        {
            double newAmountPerContainer = (amount + (this.amount * group.Count))/ group.Count;
            if (newAmountPerContainer < 0.0) newAmountPerContainer = 0.0;

            foreach (Container container in group)
                container.amount = newAmountPerContainer;
        }
    }
}

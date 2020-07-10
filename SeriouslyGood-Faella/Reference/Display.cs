using System;
using System.Collections.Generic;
using System.Text;

namespace Reference
{
    public static class Display
    {
        private const string indent = "   ";    // 3 spaces

        public static void Containers(string label, params Container[] containers)
        {
            Console.Write(label);
            foreach (Container container in containers)
                Console.Write(container.Amount + "  ");
            Console.WriteLine();
        }

        public static void AddOrRemoveWater(double amount, Container container)
        {
            string verb = (amount >= 0.0) ? "Adding" : "Removing";
            Console.WriteLine("{0}{1} {2} to container '{3}'", indent, verb, amount, container.Name);
        }

        public static void Connect(Container container1, Container container2)
        {
            Console.WriteLine("{0}Connecting containers: '{1}' <==> '{2}'", indent, container1.Name, container2.Name);
        }
    }
}

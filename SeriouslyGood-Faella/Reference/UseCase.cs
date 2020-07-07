using System;
using System.Collections.Generic;
using System.Text;

namespace Reference
{
    public class UseCase
    {
        public static void RunUseCase()
        {
            Container a = new Container();
            Container b = new Container();
            Container c = new Container(); 
            Container d = new Container();
            PrintContainers("Part 1: ", a, b, c, d);

            a.addOrRemoveWater(12);
            d.addOrRemoveWater(8);
            a.connectTo(b);
            PrintContainers("Part 2: ", a, b, c, d);

            b.connectTo(c);
            PrintContainers("Part 3: ", a, b, c, d);

            b.connectTo(d);
            PrintContainers("Part 4: ", a, b, c, d);
        }

        public static void PrintContainers(string label, params Container[] containers)
        {
            Console.Write(label);
            foreach (Container container in containers)
                Console.Write(container.getAmount() + "  ");
            Console.WriteLine();
        }
    }
}

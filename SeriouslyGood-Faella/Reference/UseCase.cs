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
            DisplayContainers("Part 1: ", a, b, c, d);

            a.addOrRemoveWater(12);
            d.addOrRemoveWater(8);
            a.connectTo(b);
            DisplayContainers("Part 2: ", a, b, c, d);

            b.connectTo(c);
            DisplayContainers("Part 3: ", a, b, c, d);

            b.connectTo(d);
            DisplayContainers("Part 4: ", a, b, c, d);
        }

        public static void RunUseCaseMultipleConnections()
        {
            Container a = new Container(), b = new Container(), c = new Container();
            Container d = new Container(), e = new Container(), f = new Container();
            DisplayContainers("Step 1: ", a, b, c, d, e, f);

            a.addOrRemoveWater(12);
            d.addOrRemoveWater(18);
            DisplayContainers("Step 2: ", a, b, c, d, e, f);

            a.connectTo(b);
            b.connectTo(c);
            d.connectTo(e);
            DisplayContainers("Step 3: ", a, b, c, d, e, f);

            e.connectTo(d);
            c.connectTo(a);
            DisplayContainers("Step 4, multiple connections, should == Step 3: ", a, b, c, d, e, f);

            f.connectTo(b);
            DisplayContainers("Step 5: ", a, b, c, d, e, f);

            d.connectTo(f);
            DisplayContainers("Step 6: ", a, b, c, d, e, f);

            a.connectTo(e);
            a.connectTo(a);
            DisplayContainers("Step 7, multiple connections, should == Step 6: ", a, b, c, d, e, f);
        }

        public static void DisplayContainers(string label, params Container[] containers)
        {
            Console.Write(label);
            foreach (Container container in containers)
                Console.Write(container.getAmount() + "  ");
            Console.WriteLine();
        }
    }
}

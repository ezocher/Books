using System;
using System.Collections.Generic;
using System.Text;

namespace Reference
{
    public class UseCase
    {
        public static void RunUseCase()
        {
            Container a = new Container("a");
            Container b = new Container("b");
            Container c = new Container("c"); 
            Container d = new Container("d");
            Display.Containers("Part 1: ", a, b, c, d);

            a.addOrRemoveWater(12);
            d.addOrRemoveWater(8);
            a.connectTo(b);
            Display.Containers("Part 2: ", a, b, c, d);

            b.connectTo(c);
            Display.Containers("Part 3: ", a, b, c, d);

            b.connectTo(d);
            Display.Containers("Part 4: ", a, b, c, d);
        }

        public static void RunUseCaseMultipleConnections()
        {
            Container a = new Container(), b = new Container(), c = new Container();
            Container d = new Container(), e = new Container(), f = new Container();
            Display.Containers("Step 1: ", a, b, c, d, e, f);

            a.addOrRemoveWater(12);
            d.addOrRemoveWater(18);
            Display.Containers("Step 2: ", a, b, c, d, e, f);

            a.connectTo(b);
            b.connectTo(c);
            d.connectTo(e);
            Display.Containers("Step 3: ", a, b, c, d, e, f);

            e.connectTo(d);
            c.connectTo(a);
            Display.Containers("Step 4, multiple connections, should == Step 3: ", a, b, c, d, e, f);

            f.connectTo(b);
            Display.Containers("Step 5: ", a, b, c, d, e, f);

            d.connectTo(f);
            Display.Containers("Step 6: ", a, b, c, d, e, f);

            a.connectTo(e);
            a.connectTo(a);
            Display.Containers("Step 7, multiple connections, should == Step 6: ", a, b, c, d, e, f);
        }


    }
}

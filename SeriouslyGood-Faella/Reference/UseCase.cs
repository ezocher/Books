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

            a.AddOrRemoveWater(12);
            d.AddOrRemoveWater(8);
            a.ConnectTo(b);
            Display.Containers("Part 2: ", a, b, c, d);

            b.ConnectTo(c);
            Display.Containers("Part 3: ", a, b, c, d);

            b.ConnectTo(d);
            Display.Containers("Part 4: ", a, b, c, d);
        }

        public static void RunUseCaseMultipleConnections()
        {
            Container a = new Container(), b = new Container(), c = new Container();
            Container d = new Container(), e = new Container(), f = new Container();
            Display.Containers("Step 1: ", a, b, c, d, e, f);

            a.AddOrRemoveWater(12);
            d.AddOrRemoveWater(18);
            Display.Containers("Step 2: ", a, b, c, d, e, f);

            a.ConnectTo(b);
            b.ConnectTo(c);
            d.ConnectTo(e);
            Display.Containers("Step 3: ", a, b, c, d, e, f);

            e.ConnectTo(d);
            c.ConnectTo(a);
            Display.Containers("Step 4, multiple connections, should == Step 3: ", a, b, c, d, e, f);

            f.ConnectTo(b);
            Display.Containers("Step 5: ", a, b, c, d, e, f);

            d.ConnectTo(f);
            Display.Containers("Step 6: ", a, b, c, d, e, f);

            a.ConnectTo(e);
            a.ConnectTo(a);
            Display.Containers("Step 7, multiple connections, should == Step 6: ", a, b, c, d, e, f);
        }


    }
}

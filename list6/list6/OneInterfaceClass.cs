using System;
using System.Collections.Generic;
using System.Text;

namespace list6
{
    public class OneInterfaceClass : IFigure
    {
        public void moveTo(double x, double y)
        {
            Console.WriteLine("inside moveTo method in OneInterfaceClass");
        }
    }
}

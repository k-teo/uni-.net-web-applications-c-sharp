using System;
using System.Collections.Generic;
using System.Text;

namespace list6
{
    public class TwoInterfacesClass : IFigure, IHasInterior
    {
        String IHasInterior.Color { get; set; } = "white";

        public void moveTo(double x, double y)
        {
            Console.WriteLine("inside moveTo method in TwoInterfacesClass");
        }
    }
}

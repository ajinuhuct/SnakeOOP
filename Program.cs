using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3,'*');            
            Point p2 = new Point(4, 5, '#');

            HorizintalLine line = new HorizintalLine(5, 70, 8, '+');
            VerticalLine vLine = new VerticalLine(5, 70, 8, '+');
            line.Drow();
            vLine.Drow();






            Console.ReadLine();
        }

    }
}

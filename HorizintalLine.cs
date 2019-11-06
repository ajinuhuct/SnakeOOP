using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeOOP
{
    class HorizintalLine
    {
        List<Point> pList;

        public HorizintalLine(int xLeft, int xRigth, int y, char sym)
        {
            pList = new List<Point>();
            for (int x = xLeft; x <= xRigth; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }

        }

        public void Drow()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}

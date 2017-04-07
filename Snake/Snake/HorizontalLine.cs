using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine : Figure
    {
        //List<Point> pList;

        public HorizontalLine ( int xLeft, int xRight, int y, char symbol )
        {
            pList = new List<Point>();
            for( int x = xLeft; x <= xRight; x++ )
            {
                Point p = new Point(x, y, symbol);
                pList.Add(p);
            }
        }

        //public void Draw()
        //{
        //    foreach(Point p in pList)
        //    {
        //        p.drawPoint();
        //    }
        //}
    }
}

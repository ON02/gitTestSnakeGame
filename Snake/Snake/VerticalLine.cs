using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Figure
    {
        //List<Point> pList;

        public VerticalLine( int yUp, int yDown, int x, char symbol )
        {
            pList = new List<Point>();

            for( int y = yUp; y <= yDown; y++ )
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

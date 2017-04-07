using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char symbol;

        public Point(int x, int y, char symbol)
        {
            this.x = x;
            this.y = y;
            this.symbol = symbol;
        }

        public Point(Point p)
        {
            this.x = p.x;
            this.y = p.y;
            this.symbol = p.symbol;
        }

        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)
                x += offset;
            else if (direction == Direction.LEFT)
                x -= offset;
            else if (direction == Direction.UP)
                y -= offset;
            else if (direction == Direction.DOWN)
                y += offset;
        }

        public void DrawPoint()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }

        public void Clear()
        {
            this.symbol = ' ';
            this.DrawPoint();
        }

        public bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }

    }
}

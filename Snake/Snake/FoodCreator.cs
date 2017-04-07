using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator : Figure
    {
        int MapWidth;
        int MapHight;
        char symbol;

        Random random = new Random();

        public FoodCreator(int MapWidth, int MapHight, char symbol)
        {
            this.MapWidth = MapWidth;
            this.MapHight = MapHight;
            this.symbol = symbol;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, MapWidth - 2);
            int y = random.Next(2, MapHight - 2);
            return new Point(x, y, symbol);
        }
    }
}

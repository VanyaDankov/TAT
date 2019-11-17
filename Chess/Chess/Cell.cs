using System;


namespace Chess
{
    class Cell
    {
        private int x=0, y=0;
        public Cell(int X, int Y)
        {
            x = X;
            y = Y;
            while (CheckCoordinate()==false)
            {
                Console.WriteLine("enter coordinate");
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void Move(int X, int Y)
        {
            x += X;
            y += Y;
         
        }
        public string Color()
        {
            if (x + y % 2 == 0)
            {
                return "Black";
            }
            else
            {
                return "White";
            }
        }
        public bool CheckCoordinate()
        {
            if(x <= 8 && y <= 8 && x > 0 && y > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckDiaganale(Cell abc)
        {
            if (abc.x - x == abc.y - y || abc.x - x == y - abc.y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckVertical(Cell abc)
        {
            if (abc.x == x)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckHorizontal(Cell abc)
        {
            if (abc.y == y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

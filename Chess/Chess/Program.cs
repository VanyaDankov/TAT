using System;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {

            Figure abc = new Figure(8, 1);
            Figure cde = new Figure(5, 4);
            if (cde.CheckDiaganale(abc))
            {
                Console.WriteLine("Diaganale");
            }
            if (cde.CheckHorizontal(abc))
            {
                Console.WriteLine("Horizontale");
            }
            if (cde.CheckVertical(abc))
            {
                Console.WriteLine("Diaganale");
            }
            Console.WriteLine("Cell was " + abc.Color());
        }
    }
}

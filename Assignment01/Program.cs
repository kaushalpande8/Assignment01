using System;

namespace Assignment01
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            int userChoose;
            do
            {

                Console.WriteLine("Please Enter Valid Input From Below Option:");
                Console.WriteLine("1.Get Rectangle Lenght");
                Console.WriteLine("2.Change Rectangle Lenght");
                Console.WriteLine("3.Get Rectangle Width");
                Console.WriteLine("4.Change Rectangle Width");
                Console.WriteLine("5.Get Rectangle Perimeter");
                Console.WriteLine("6.Get Rectangle Area");
                Console.WriteLine("7.Exit");
                userChoose = int.Parse(Console.ReadLine());
                

            } while (true);
         }
    }
}

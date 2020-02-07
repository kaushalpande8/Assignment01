using System;

namespace AssignmentQ01
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            int userChoice;
            while (true)
            {
                int length = 0;
                Console.WriteLine("Please Provide the Value of Length:");
                if(!Int32.TryParse(Console.ReadLine(), out length)|| length <= 0)
                {
                    Console.WriteLine("ops!!! wrong input.. Please Provide suitable Input");
                    continue;
                }
                else
                {
                    r.SetLenght(length);
                    break;
                }
            }
            while (true)
            {
                int width = 0;
                Console.WriteLine("Please Provide the Value of Width:");
                if (!Int32.TryParse(Console.ReadLine(), out width) || width <= 0)
                {
                    Console.WriteLine("ops!!! wrong input.. Please Provide suitable Input");
                    continue;
                }
                else
                {
                    r.SetLenght(width);
                    break;
                }
            }
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
                userChoice = int.Parse(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        int changeLength = r.GetLenght();
                        Console.WriteLine("Length is {0}", changeLength);
                        break;
                    case 2:
                        int newLength;
                        Console.WriteLine("Set the Rectangle length");
                        newLength = int.Parse(Console.ReadLine());
                        if (newLength > 0)
                        {

                            int returedLength = r.SetLenght(newLength);
                        }
                        else
                        {
                            Console.WriteLine("Sorry!!!.....Input is not Valid");
                        }
                        break;
                    case 3:
                        int changeWidth = r.GetWidth();
                        Console.WriteLine(" Width is {0}", changeWidth);
                        break;
                    case 4:
                        int newWidth;
                        Console.WriteLine("Set the Rectangle Width");
                        newWidth = int.Parse(Console.ReadLine());
                        if (newWidth > 0)
                        {

                            int returedLength = r.SetWidth(newWidth);
                        }
                        else
                        {
                            Console.WriteLine("Please enter a valid input");
                        }
                        break;
                    case 5:
                        int perimeterValue = r.GetPerimeter();
                        Console.WriteLine("Perimeter is {0}", perimeterValue);
                        break;
                    case 6:
                        int areaValue = r.GetArea();
                        Console.WriteLine("Your Area is {0}", areaValue);
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Sorry!!!!.... Wrong Input Enter Valid Option");
                        break;
                }

            } while (true);

        }
    }
}

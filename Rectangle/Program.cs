using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int lgnt = 0, width = 0, choice;
            do
            {
                Console.WriteLine("Enter the Length of the Rectangle:");
                lgnt = Convert.ToInt32(Console.ReadLine());
            } while (lgnt <= 0);

            do
            {
                Console.WriteLine("Enter the Width of the Rectangle:");
                width = Convert.ToInt32(Console.ReadLine());
            } while (width <= 0);

            Rectangle obj = new Rectangle(lgnt, width);
            obj.SetLength(lgnt);
            obj.SetWidth(width);
            string ch = "y";

            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Get Rectangle Length");
                Console.WriteLine("2.Change Rectangle Length");
                Console.WriteLine("3.Get Rectangle Width");
                Console.WriteLine("4.Change Rectangle Width");
                Console.WriteLine("5.Get Rectangle Perimeter");
                Console.WriteLine("6.Get Rectangle Area");
                Console.WriteLine("7.Exit");

                Console.WriteLine("Enter your Choice:");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine(obj.GetLength());
                        break;
                    case 2:
                        {
                            do
                            {
                                Console.WriteLine("Enter the Length of the Rectangle:");
                                lgnt = Convert.ToInt32(Console.ReadLine());
                            } while (lgnt <= 0);
                            Console.WriteLine(obj.SetLength(lgnt));
                            break;
                        }
                    case 3:
                        Console.WriteLine(obj.GetWidth());
                        break;
                    case 4:
                        {
                            do
                            {
                                Console.WriteLine("Enter the Width of the Rectangle:");
                                width = Convert.ToInt32(Console.ReadLine());
                            } while (width <= 0);
                            Console.WriteLine(obj.SetWidth(width));
                            break;
                        }
                    case 5:
                        Console.WriteLine(obj.GetPerimeter());
                        break;
                    case 6:
                        Console.WriteLine(obj.GetArea());
                        break;
                    default: break;

                }
                if (choice == 7)
                {
                    break;
                    ch = "n";
                }
                
            } while (ch == "y" || ch == "Y");

        }
    }
}

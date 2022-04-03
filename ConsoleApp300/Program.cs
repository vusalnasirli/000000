using ConsoleApp300.MODELS;
using System;

namespace ConsoleApp300
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel hilton = new Hotel("Hilton");
            Room rm1 = new Room("10", 10.5, 2);
            Room rm2 = new Room("11", 12.5, 6);
            Room rm3 = new Room("12", 14.5, 10);

            Hotel Absheron = new Hotel("Absheron");

            Absheron.AddRoom(rm1);
            Console.WriteLine(rm1.ID);
            Absheron.AddRoom(rm2);
            Console.WriteLine(rm2.ID);
            Absheron.AddRoom(rm3);
            Console.WriteLine(rm3.ID);
            Console.WriteLine(rm1);
            Console.WriteLine(rm2);
            Console.WriteLine(rm3);
            Console.WriteLine();
            Console.Write("Enter ID : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Absheron.Reserve(number);
            Console.WriteLine();
            Console.WriteLine(Absheron[number - 1]);
            Console.ReadLine();
        }
    }
}

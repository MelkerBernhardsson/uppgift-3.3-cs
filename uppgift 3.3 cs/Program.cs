using System;

namespace uppgift33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många timmar tänker du hyra bilen?");
            int timmar = int.Parse(Console.ReadLine());
            int timmpris = timmar * 80;

            if (timmpris > 950) 

            Console.WriteLine("du får inte hyra så länge");

            else
            Console.WriteLine("att hyra bilen i "+timmar+" timmar kommer att kosta "+timmpris+" kr");
        }
    }
}

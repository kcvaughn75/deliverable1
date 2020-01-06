using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What kind of trip would you like to go on, musical, tropical, or adventurous? ");

            string vacationType = (Console.ReadLine());

            Console.WriteLine("How many are in your group? ");

            int groupSize = int.Parse(Console.ReadLine());

            string travel = ("");
            string destination = ("");

            if (groupSize >= 1 && groupSize <= 2)
            {
                travel = ("first class");
            }

            if (groupSize >= 3 && groupSize <= 5)
            {
                travel = ("by helicopter");
            }

            if (groupSize >= 6)
            {
                travel = ("by charter flight");
            }

            if (vacationType == "musical")
            {
                destination = ("New Orleans");
            }

            if (vacationType == "tropical")
            {
                destination = ("Mexico for a beach vacation");
            }

            if (vacationType == "adventurous")
            {
                destination = ("the Grand Canyon for whitewater rafting");
            }

            string result = ("Since you're a group of " + groupSize + " going on a " + vacationType + " vacation, you should travel " + travel + " to " + destination + ".");

            Console.WriteLine(result);
        }
    }
}

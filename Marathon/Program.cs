using System;

namespace Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Heather";
            string eventType = GetRandEvent();
            int days = GetTrainingDays(eventType);

            LogEvent(name, eventType);
            LogTime(name, days);

            Console.ReadKey();
        }

        public static string GetRandEvent()
        {
            Random Rnd = new Random(Guid.NewGuid().GetHashCode());
            int randomNum = Rnd.Next(0, 3);
            if (randomNum == 0)
            {
                return "Marathon";
            }
            else if (randomNum == 1)
            {
                return "Triathlon";
            }
            else if (randomNum == 2)
            {
                return "Pentathon";
            }
            else
            {
                return "There was an error!";
            }
        }

        public static int GetTrainingDays(string eventType)
        {

            if (eventType == "Marathon")
            {
                return 50;
            }
            else if (eventType == "Triathlon")
            {
                return 100;
            }
            else
            {
                return 200;
            }
        }

        public static void LogEvent(string name, string eventType)
        {
            Console.WriteLine($"{name}'s event is : {eventType}");
        }

        public static void LogTime(string name, int days)
        {
            Console.WriteLine($"{name}'s time to train is: {days} days");
        }
    }
}

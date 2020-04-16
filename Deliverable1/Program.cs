using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            string question1 = "What kind of trip would you like to go on," +
                " musical, tropical, or adventurous?";
            string destination = null;
            string vacationType = null;

            while (destination == null)
            {
                Console.WriteLine(question1);
                vacationType = Console.ReadLine();
                if (vacationType == "musical")
                    destination = "New Orleans";
                else if (vacationType == "tropical")
                    destination = "beach vacation in Mexico";
                else if (vacationType == "adventurous")
                    destination = "whitewater rafting the Grand Canyon";
                else // try again
                    question1 = "I'm sorry I didn't understand your response.\n" +
                        "What kind of trip would you like to go on, musical, tropical, " +
                        "or adventurous? ";
            }

            string question2 = "How many are in your group?";
            string suggestion = null;
            int groupSize = 0;

            while (suggestion == null)
            {
                Console.WriteLine(question2);
                groupSize = int.Parse(Console.ReadLine());
                if (groupSize >= 6)
                    suggestion = "charter flight";
                else if (groupSize >= 3) // groupSize is 3, 4, or 5
                    suggestion = "helicopter";
                else if (groupSize >= 1) // groupSize is 1 or 2
                    suggestion = "first class";
                else // try again
                    question2 = "I'm sorry I didn't understand your response.\n" +
                        "How many are in your group?";
            }

            string result = "Since you’re a group of " + groupSize + 
                " going on a " + vacationType + " vacation," +
                " you should take a " + suggestion + " to " + destination;

            Console.WriteLine(result);
        }
    }
}

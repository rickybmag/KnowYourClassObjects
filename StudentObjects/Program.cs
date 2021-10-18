using System;
using System.Collections.Generic;

namespace StudentObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Info> students = new List<Info>();
            students.Add(new Info("Erin", "Troy, MI", "Tacos"));
            students.Add(new Info("Richard", "Canton, MI", "Sushi"));
            students.Add(new Info("Cortez", "Detroit, MI", "Chicken Fettuccine"));
            students.Add(new Info("Cullin", "Fowlerville, MI", "Pad Thai"));
            students.Add(new Info("Anu", "Rochester Hills, MI", "Tacos"));
            students.Add(new Info("James", "YAP, FSM", "Katsu"));
            students.Add(new Info("Andy", "Berkley, MI", "French Fries"));
            students.Add(new Info("Cassly", "Detroit, MI", "Steak"));
            students.Add(new Info("Ese", "Detroit, MI", "Shrimp"));
            students.Add(new Info("Huy", "Lansing, MI", "Korean BBQ"));

            bool studentInfo = true;
            bool studentCheck = true;
            bool moreInfo = true;
            bool goOn = true;

            while (goOn == true)
            {
                Console.WriteLine("Please select a student you'd like to learn more about? (Enter a number 1-10)");                

                for (int i = 0; i < students.Count; i++)
                {
                    Console.WriteLine($"{i + 1}: {students[i].Name}");                   
                }

                int classmate = int.Parse(Console.ReadLine())-1;

                while(studentCheck)
                {
                    if(classmate >= 0 && classmate <= 10)
                    {
                        studentCheck = false;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a number between 1-10");
                        studentCheck = true;
                    }
                }

                while (studentInfo)
                {
                    Console.WriteLine($"What more would you like to know about {students[classmate].Name}? Please enter hometown or favorite food to continue");
                    string response = Console.ReadLine().ToLower();

                    //while (moreInfo)
                    //{
                        if (response == "hometown")
                        {
                            Console.WriteLine($"{students[classmate].Name} is from {students[classmate].Hometown}");
                            moreInfo = true;
                            break;
                        }
                        else if (response == "favorite food")
                        {
                            Console.WriteLine($"{students[classmate].Name}'s favorite food is {students[classmate].FavoriteFood}");
                            moreInfo = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("That wasn't a proper response\n");
                            moreInfo = false;
                        //}
                    }
                }


                goOn = Continue();
            }
        }

        public static string GetInput(string prompt)
        {
            Console.WriteLine(prompt);
            string output = Console.ReadLine();
            return output;
        }

        //public static bool StudentCheck(int student)
        //{

        //    if (student <= 0 && student > students.Count)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Please enter a number between 1-10");
        //        return false;
        //    }
        //}

        public static bool Continue()
        {
            string answer = GetInput("Would you like to continue? (Y/N)");
            Console.WriteLine();

            if (answer == "y")
            {
                return true;
            }
            else if (answer == "n")
            {
                Console.WriteLine("See you soon!");
                return false;
            }
            else
            {
                Console.WriteLine("Please Try again");
                Console.WriteLine();
                return Continue();
            }
        }
    }
}

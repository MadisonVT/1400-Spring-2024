using System;

namespace Challenge1a
{
    public class Challenge1a
    {
        public void Main(string[] args)
        {
            int myAge = 21;
            float piNum = 3.41f;

            Console.WriteLine("What is your Name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Welcome " + yourName + "!");
            Console.WriteLine("What is your age?");
            int yourAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(yourAge);
            if (yourAge > myAge)
            {
                Console.WriteLine("You're older than me!");
            }
            else if (yourAge < myAge)
            {
                Console.WriteLine("You're younger than me!");
            }
            else
            {
                Console.WriteLine("You're the same age as me!");
            }
            Console.WriteLine("You like pie. True or False?");
            bool likePi = Convert.ToBoolean(Console.ReadLine());
            if (likePi)
            {
                Console.WriteLine("Here you go! " + piNum);
            }
            else
            {
                Console.WriteLine("Fair enough.");
            }

        }
    }
}

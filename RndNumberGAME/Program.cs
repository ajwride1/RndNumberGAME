using System;

namespace RndNumberGAME
{
    class Program
    {
        static void Main(string[] args)
        {
            int guesslimit = 10;


            Console.WriteLine("Please pick a random number");
            string guess = Console.ReadLine();
            
            int guessint = Int32.Parse(guess);

            Random random = new Random();

            int random1 = random.Next(1, 10);


            if (guessint == random1)
            {
                Console.WriteLine("You picked the correct number");
            }
            else if (guessint > random1)
            {
                Console.WriteLine("You Number was to High.");
            }
            else if (guessint < random1)
            {
                Console.WriteLine("You Number was to Low.");
            }



            Console.WriteLine(random1);



        }
    }
}

using ConvertHandler;

namespace Collatz_Conjecture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Prompts user
            Console.WriteLine("What function do you want to run?\nInput Collatz = 0\tLooped Collatz = 1");
            int input = Handle.Int16(Console.ReadLine());

            //Checks input
            if (input == 0)
            {
                Console.Clear();
                InputCollatz();
            }
            else
            {
                Console.Clear();
                LoopedCollatz();
            }
            
        }

        //Loops the "Collatz()" function for a long time
        static void LoopedCollatz()
        {
            for (long i = 1; i < 1844674407370955161;  i++)
            {
                Console.WriteLine("The length of " + i + " is " + Collatz(i));
                Console.ReadKey();
            }
            Console.WriteLine("\nI literally can\'t get past this (without fiddling with integers)");
        }

        //Asks what number you want to find the collatz of
        static void InputCollatz()
        {
            Console.WriteLine("What number do you want to enter in Collatz Conjecture?");
            long input = Handle.Int64(Console.ReadLine());
            Console.WriteLine("The length of " + input + " is " + Collatz(input));
        }


        //Algorithm for Collatz Conjecture
        private static long Collatz(long startNum)
        {
            long result = 0;
            long colNum = startNum;

            for (int i = 0; colNum != 1; i++)
            {
                if(colNum % 2 == 0)
                {
                    //When the number is even
                    colNum /= 2;
                }
                else
                {
                    //When the number is odd
                    colNum = colNum * 3 + 1;
                }
                result++;
            }

            return result;
        }
    }
}

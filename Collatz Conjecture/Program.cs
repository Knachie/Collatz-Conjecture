namespace Collatz_Conjecture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Collatz(27));
        }

        private static int Collatz(int startNum)
        {
            int result = 0;
            int colNum = startNum;

            for (int i = 0; colNum != 1; i++)
            {
                if(colNum % 2 == 0)
                {
                    colNum /= 2;
                }
                else
                {
                    colNum = colNum * 3 + 1;
                }
                result++;
            }

            return result;
        }
    }
}

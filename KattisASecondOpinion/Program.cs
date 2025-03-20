 // https://open.kattis.com/problems/secondopinion

namespace KattisASecondOpinion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of seconds: ");
            try
            {
                int input = int.Parse(Console.ReadLine());
                int hours = input / (60 * 60);
                int minutes = (input / 60) % 60;
                int seconds = input % 60;
                Console.WriteLine();
                Console.WriteLine("{0}:{1}:{2}", hours, minutes, seconds);
            }
            catch 
            {
                Console.WriteLine("Input is invalid");             
            }
            
            Console.ReadLine();
        }
    }
}

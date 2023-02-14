namespace Swap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            Console.WriteLine(" Before swapping a: " + a);
            Console.WriteLine("Brfore swapping b: " +b );
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine(" After swapping a: "+ a);
            Console.WriteLine("After swapping b: " + b );
            Console.WriteLine("Bye");

        }
    }
}
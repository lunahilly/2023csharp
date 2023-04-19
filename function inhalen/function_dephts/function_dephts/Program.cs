namespace function_dephts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            First("Hello");
            Second("My age is: ", 18);
            Third("I give this assignment an ", 8, true);
        }

        //string function
        static void First(string text)
        {
            Console.WriteLine(text);
        }

        static void Second(string text , int number)
        {
            Console.WriteLine(text);
            Console.WriteLine(number);
        }

        static void Third(string text , int number, bool maybe)
        {
            Console.WriteLine(text);
            Console.WriteLine(number);
            Console.WriteLine(maybe);
        }
    }
}
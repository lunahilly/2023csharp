namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] getallen = { 10 ,20 , 30, 40, 50, 60 };
            int som = berekenen(getallen);
            Console.WriteLine($"De som van de array is: {som}");
            Console.WriteLine($"Is het correct? {som == 210}");
        }

        static int berekenen(int[] arr) { 
            int som = 0;
            foreach (int getal in arr)
            {
                som += getal;
            }
            return som;
        }
    }
}
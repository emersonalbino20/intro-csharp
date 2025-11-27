namespace Exercise
{
    class Program
    {
        private static int Atoi(string s)
        {
            if (int.TryParse(s, out int value))
                return (int.Parse(s));
            return (0);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Insert an integer value:");
            Console.WriteLine(Atoi(Console.ReadLine()));
        }
    }
    
}
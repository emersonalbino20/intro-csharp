namespace Exercise
{
    class Program
    {
        public static int Atoi(string s)
        {
            if (int.TryParse(s, out int value))
                return (int.Parse(s));
            return (0);
        }

        private static void Task(int value)
        {
            switch (value)
            {
                case 113 :
                    Console.WriteLine("Calling to the police...");
                    break;
                case 111 :
                    Console.WriteLine("Calling to the general emergency...");
                    break;
                case 119 :
                    Console.WriteLine("Calling to the ambulance...");
                    break;
                default:
                    Console.WriteLine("That's not a emergency number!");
                    Console.WriteLine("=======Emergency Number======");
                    Console.WriteLine("Police 113\nGeneral emergency 111\nAmbulance 119");
                    break;
            }    
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Tell the emergency number:");
            Task(Atoi(Console.ReadLine()));
        }
    }
    
}
namespace  ClassesBasics
{
    class Program
    {
        public static void Main(string[] args)
        {
            Human ealbino = new Human("Emerson J.T Albino", "Ealbino", "Brown", 18);
            Human anders = new Human("Anders Hejlsberg", "aHejlsberg", "Blue", 65);
            ealbino.GetInfo();
            anders.GetInfo();
        }
    }
} 
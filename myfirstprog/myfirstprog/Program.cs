public class MyFirstProg
{
    
    private static int Add(int a, int b)
    {
        return (a + b);
    }

    private static int Minus(int a, int b)
    {
        return (a - b);
    }

    private static int Multiply(int a, int b)
    {
        return (a * b);
    }

    private static double Divide(double a, double b)
    {
        return (a / b);
    }

    private static void PrintResult(int a, int b)
    {
        Console.WriteLine("{0} + {1} = {2}", a, b, Add(a, b));
        Console.WriteLine("{0} - {1} = {2}", a, b, Minus(a, b));
        Console.WriteLine("{0} x {1} = {2}", a, b, Multiply(a, b));
        Console.WriteLine("{0} / {1} = {2}", a, b, Divide(a, b));
    }
    private static void Calculate()
    {
        //this comment is just as example
        Console.WriteLine("Insert the first number:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Insert the second number:");
        int b = int.Parse(Console.ReadLine());
        PrintResult(a, b);
    }
    
    public static void Main(string[] args)
    {
        Calculate();
    }
}
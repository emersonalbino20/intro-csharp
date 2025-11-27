namespace TwoDArray;

class Program
{
    static void Main(string[] args)
    {
        string[,] matrix;
        matrix = new string[2,2]
        {
            { "A", "B" },
            { "C", "D" },
        };
        
        int[,] array2D = new int[,]
        {
            { 1, 2, 3 }, 
            { 4, 5, 6 }, 
            { 7, 8, 9 } 
        };

        int[,] array2D2 = {{ 1, 2 },{ 3, 4 }}; 
        
        Console.WriteLine($"Central value is {array2D[1, 1]}");
    }
}
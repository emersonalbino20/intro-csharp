namespace Array;

class Program
{
    private static int max = 0;

    private static int Max
    {
        get => max;
        set => max = value;
    }

    private static void FillArray(int[] array)
    {
        string input;
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"Tell the grade number {i}");
            input = Console.ReadLine();
            if (!int.TryParse(input, out array[i]))
                array[i] = 0;
            if (array[i] > Max)
                Max = array[i];
        }
    }
    
    static void Main(string[] args)
    {
        int[] grades = new int[5];
        FillArray(grades);        
        for (int i = 0; i < grades.Length; i++)
            Console.WriteLine($"grades at index {i} : {grades[i]}");
        Console.WriteLine($"Major grade is {Max}");
    }
}
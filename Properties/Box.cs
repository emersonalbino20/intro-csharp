using System.Runtime.CompilerServices;

namespace Properties;

public class Box
{
    private int length = 3;
    public int height;
    public int width;

    public void SetterLength(int length)
    {
        if (length < 0)
            throw new Exception("Length cannot be negative");
        this.length = length;
    }

    public int GetLength()
    {
        return (this.length);
    }

    private int GetVolume()
    {
        return (length * height * width);
    }
    
    public void DisplayInfo()
    {
        Console.WriteLine($"Length: {length}\nHeight: {height}");
        Console.WriteLine($"Width: {width}\nVolume: {GetVolume()}");
    }
}
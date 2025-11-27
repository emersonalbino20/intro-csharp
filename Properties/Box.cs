using System.Runtime.CompilerServices;

namespace Properties;

public class Box
{
    private int length = 3;
    private int height;
    private int width;

    public int Width
    {
        get => width;
        set => width = value;
    }

    public int Height
    {
        get => this.length;
        set
        {
            if (value < 0)
                throw new Exception("Height cannot be negative");
            this.height = value;
        }
    }
    
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

    public Box(int length, int height, int width)
    {
        this.length = length;
        this.height = height;
        this.width = width;
    }
}
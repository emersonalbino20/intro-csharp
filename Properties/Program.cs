using System.Runtime.CompilerServices;

namespace  Properties;

class Program
{ 
    public static void Main(string[] args)
    { 
        Box box = new Box();
        box.height = 4;
        box.width = 5;
        box.SetterLength(5);
        box.DisplayInfo();
    }
}
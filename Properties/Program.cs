using System.Runtime.CompilerServices;

namespace  Properties;

class Program
{ 
    public static void Main(string[] args)
    { 
        Box box = new Box(5, 2147483647, 5);
        box.DisplayInfo();
    }
}

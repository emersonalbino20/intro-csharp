namespace ClassesBasics;

public class Human
{
    public string name;
    public string nickname;
    public void hello()
    {
        if (name == null || nickname == null)
        {
            Console.Write("Invalid information!");
            return;
        }
        Console.WriteLine("======Information about you======");
        Console.WriteLine($"Full Name: {name}");
        Console.WriteLine($"Nickname: {nickname}");
    }
}
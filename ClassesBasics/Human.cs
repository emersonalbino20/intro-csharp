namespace ClassesBasics;

public class Human
{
    private string _name;
    private string _nickname;
    private string _eyeColor;
    private int _age;
    
    public void GetInfo()
    {
        if (_name == null || _nickname == null
                          || _eyeColor == null || _age == null)
        {
            Console.Write("Invalid information!");
            return;
        }
        Console.WriteLine($"======Information about {_nickname}======");
        Console.WriteLine($"Full Name: {_name}\nNickName: {_nickname}");
        Console.WriteLine($"Eye Color: {_eyeColor}\nAge: {_age}");
    }

    //Constructor
    public Human(string name, string nickname,  string eyeColor, int age)
    {
        this._name = name;
        this._nickname = nickname;
        this._eyeColor = eyeColor;
        this._age = age;
    }
}
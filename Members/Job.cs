using System.Diagnostics;

namespace Members;

public class Job
{
    private string memberName;
    private string jobTitle;
    private int age;
    private double salary;

    public string JobTitle
    {
        get => jobTitle;
        set => jobTitle = value ?? throw new Exception("invalid job title");
    }

    public void introducingMember(bool isFriend)
    {
        if (isFriend)
        {
            SharingPrivateInfo();
            return;
        }
        Console.WriteLine($"Hi my name is {memberName}, and my job title is {jobTitle}. I am {age} years old.");
    }

    private void SharingPrivateInfo()
    {
        Console.WriteLine($"My salary is {salary}");
    }

    public Job()
    {
        this.memberName = "John Doe";
        this.jobTitle = "Developer";
        this.age = 20;
        this.salary = 150;
        Console.WriteLine("Object is created");
    }

    // member - finalizer - destructor
    ~Job()
    {
        Console.WriteLine($"Job {this.JobTitle} has been destroyed");
        Debug.WriteLine("Object has been destroyed");
    }
}

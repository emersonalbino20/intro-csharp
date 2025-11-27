namespace Members;

public class Members
{
    private string memberName;
    private string jobTitle;
    private int age;

    public string JobTitle
    {
        get => jobTitle;
        set => jobTitle = value ?? throw new Exception("invalid job title");
    }

    public Members()
    {
        this.memberName = "John Doe";
        this.jobTitle = "Job Title";
        this.age = 20;
    }

    ~Members()
    {
    }
}
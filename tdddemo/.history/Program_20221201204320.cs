class Person
{
    private string _name;
    public string Name 
    {
        get { return _name; } 
        set { this._name = value; }
    }
    
    public int birthYear;
    public string genre;

    public Person()
    {

    }

    public Person(string Name)
    {
        this._name = Name;
    }
}


class Program
{
    public void Main(string[] args)
    {
        Person myObj = new Person("Samet");
        Console.WriteLine(myObj.Name);
    }
}

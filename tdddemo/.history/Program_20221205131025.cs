class Person
{
    private string _name;
    public string Name 
    {
        get { return _name; } 
        set 
        { 
            if (value.Length > 5)
            {
                this._name = value;
            }

        }
    }
    
    public int birthYear;
    public string genre;

    public Person()
    {

    }

    public void Disp()
    {
        Console.WriteLine(Name);
    }
}


class Program
{
    public static void Main(string[] args)
    {
        Person myObj = new Person();
        myObj.Name = "Samet";
        myObj.Disp()
    }
}

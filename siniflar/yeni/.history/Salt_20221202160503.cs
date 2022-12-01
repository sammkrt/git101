namespace yeni;
public class Salt
{
    public string name, sinif;
    public int grade;

    public Salt(string personName, string personSinif, int personGrade)
    {
        name = personName;
        sinif = personSinif;
        grade = personGrade;
    }

    public void disp()
    {
        Console.WriteLine($"{name}, {sinif}, {grade} ");
    }


}

class Program
{
    static void Main(string[] args)
    {
        Salt firstStudent = new Salt("Samet", ".Net Develepor", 95);
        firstStudent.disp();
    }
}

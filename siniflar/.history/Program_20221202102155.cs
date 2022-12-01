// See https://aka.ms/new-console-template for more information
class Ogrenci
{
    //we can reach all of threats from everywhere
    public string AdSoyad;
    public int Numara;
    public int Sinif;

    // We can reach Bilgi() method from the other classes
    public void Bilgi()
    {
        Console.WriteLine("Ogrencinin adi:{0}", AdSoyad);
        Console.WriteLine("Ogrencinin Numarasi:{0}", Numara);
        Console.WriteLine("Ogrencinin Sinifi:{0}", Sinif);
    }

    static void Main(string[] args)
    {
        //create an object from class Ogrenci
        Ogrenci ogr1 = new Ogrenci();

        // assigned some values in the object
        ogr1.AdSoyad ="Serdar Yilmaz";
        ogr1.Numara = 134;
        ogr1.Sinif = 4;

        // call Bilgi() method print assigned value
        ogr1.Bilgi();

        Console.WriteLine(new string('-', 30));

        // create an another object from class Ogrenci
        Ogrenci ogr2 = new Ogrenci();
        ogr2.AdSoyad = "Samet Kurt";
        ogr2.Numara = 136;
        ogr2.Sinif = 5;
        ogr2.Bilgi();

        Console.WriteLine(new string('-', 30));

        // create an another object from class Ogrenci
        Ogrenci ogr3 = new Ogrenci();
        ogr3.AdSoyad = "Rase Kurt";
        ogr3.Numara = 456;
        ogr3.Sinif = 3;
        ogr3.Bilgi();
    }
}

class Car
{
    string color = "Red";

    static void Main(string[] args)
    {
        Car myobj = new Car();
        Console.WriteLine(myobj.color);
    }
}


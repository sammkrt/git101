namespace CheckNums
{
    class example3
    {
        public static void Main()
        {
            int ivar = 100;
            double dvar = 100.0;
            Console.WriteLine("Original value of ivar" + ivar);
            Console.WriteLine("Original value of dvar" + dvar);    
            
            Console.WriteLine();

            ivar = ivar / 3;
            dvar = dvar / 3;
            Console.WriteLine("Original value of ivar" + ivar);
            Console.WriteLine("Original value of dvar" + dvar);    
            
        }
    }
}
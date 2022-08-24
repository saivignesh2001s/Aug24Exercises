using ReusableCodeLibrary;

namespace Myapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s, p;
            Console.WriteLine("Enter the strings");
           s= Console.ReadLine();
            p= Console.ReadLine();
            Class1.PrintString(s);
            Class1.PrintString(s);
            Class2.StringEquals(s, p);
            string k;
            Console.WriteLine("copied string");
            Class3.Copy(s);
            
            Class4.index(s);
            Console.WriteLine("Split");
            string g = Console.ReadLine();
            Class5.spled(g);
            Class6.Upper();
            Class7.create();
            Class8.day();


            Console.ReadLine();
        }
    }
}
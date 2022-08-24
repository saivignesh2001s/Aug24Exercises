using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReusableCodeLibrary
{

    public class Class1
    {
        public static void PrintString(string s)
        {
            
            Console.WriteLine(s);
        }
    }
    public class Class2
    {
        public static void StringEquals(string s,string p)
        {
            int k = s.Length;
            int t = p.Length;
            if (k == t)
                Console.WriteLine("Strings are equal in length");
            else
                Console.WriteLine("Strings are not equal");

        }
    }
    public class Class3
    {
        public static void Copy(string s)
        {
            string k;
            k = s.Substring(0, s.Length);
            Console.WriteLine(k);
        }
    }
    public class Class4
    {
        public static void index(string s)
        {
            Console.WriteLine("Enter character");
            string p=Console.ReadLine();
            int k=s.IndexOf(p);
            Console.WriteLine(k);

        }
    }
    public class Class5
    {
        public static void spled(string g)
        {
            char[] sep = {'#'};
            int cnt=1;
            for(int i = 0; i < g.Length; i++)
            {
                if (g[i] == '#')
                {
                    cnt++;
                }

            }
            Console.WriteLine(cnt);
            string[] res = g.Split(sep,cnt,StringSplitOptions.RemoveEmptyEntries); 
           for(int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }

        }
    }
    public class Class6
    {
        public static void Upper()
        {
            string j=Console.ReadLine();
            Console.WriteLine(j.ToUpper());

        }

    }
    public class Class7
    {
        public static void create()
        {
            string s = @"C:\Users\saivignesh\source\repos\Myapp\firstfile.txt";
            File.Create(s);

        }

    }
    public class Class8
    {
        public static void day()
        {
            DateTime dt=DateTime.Now;
            Console.WriteLine("Today's Properties");
            Console.WriteLine(dt.Date);
            Console.WriteLine(dt.Month);
                Console.WriteLine(dt.Year);
            Console.WriteLine(dt.Hour);
            Console.WriteLine(dt.Minute);
            Console.WriteLine(dt.Second);
            Console.WriteLine(dt.Millisecond);
            Console.WriteLine(dt.dayOfWeek);

        }

    }
}

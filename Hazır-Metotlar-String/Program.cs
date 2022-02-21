using System;

namespace Hazır_Metotlar_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string degişken = "Dersimiz CSharp, Hoşgeldiniz";
            string degişken2 = " CSharp";

            //length
            Console.WriteLine(degişken.Length);

            //ToUpper,ToLower
            Console.WriteLine(degişken.ToUpper());
            Console.WriteLine(degişken.ToLower());

            //Concat
            Console.WriteLine(String.Concat(degişken, "Merhaba"));

            //Compare,CompareTo
            Console.WriteLine(degişken.CompareTo(degişken2));
            Console.WriteLine(String.Compare(degişken, degişken2,true));
            Console.WriteLine(String.Compare(degişken, degişken2,false));

            //Contains
            Console.WriteLine(degişken.Contains(degişken2));
            Console.WriteLine(degişken.EndsWith("Hoşgeldiniz"));
            Console.WriteLine(degişken.StartsWith("Merhaba"));

            //IndexOf,LastIndexOf
            Console.WriteLine(degişken.IndexOf("CS"));
            Console.WriteLine(degişken.IndexOf("Özlem"));
            Console.WriteLine(degişken.LastIndexOf("i"));

            //Insert
            Console.WriteLine(degişken.Insert(0, "Merhaba "));


            //PadLeft,PadRigth
            Console.WriteLine(degişken+degişken2.PadLeft(30));
            Console.WriteLine(degişken+degişken2.PadLeft(30,'*'));
            Console.WriteLine(degişken.PadRight(50) + degişken2);
            Console.WriteLine(degişken.PadRight(50,'-') + degişken2);

            //Remove
            Console.WriteLine(degişken.Remove(10));
            Console.WriteLine(degişken.Remove(5,3));
            Console.WriteLine(degişken.Remove(0,1));

            //Replace
            Console.WriteLine(degişken.Replace("CSharp", "C#"));
            Console.WriteLine(degişken.Replace(" ", "*"));

            //Split
            Console.WriteLine(degişken.Split(' ')[1]);

            //SubString
            Console.WriteLine(degişken.Substring(4));
            Console.WriteLine(degişken.Substring(4,6));
        }
    }
}

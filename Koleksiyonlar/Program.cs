using System.Collections.Generic;

namespace Koleksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {   // Array Yöntem (Gerçek Hayatta Kullanılmaz)
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);


            // List Yöntemi ** 
            List<string> isimler2 = new List<string> { "Engin","Murat","Kerem","Halil"};
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            // isimler2 adlı stringin sonunda 4.obje olarak İlkeri ekler.
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        

        }
    }
}
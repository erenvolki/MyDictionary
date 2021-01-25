using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> kelimeler = new MyDictionary<string, string>();
            kelimeler.Add("Bilgisayar", "Computer");
            kelimeler.Add("Ürün", "Product");
            kelimeler.Add("Maaş", "Salary");
            kelimeler.Add("İşçi", "Worker");

            Console.WriteLine("Basit bir Türkçe İngilizce sözlük uygulaması");
            Console.WriteLine("****************************************");

            for (int i = 0; i < kelimeler.anahtar.Length; i++)
            {
                Console.WriteLine(kelimeler.anahtar[i] + " : " + kelimeler.deger[i]);
            }
        }
    }
    
}

using System;
using System.Collections.Generic;

namespace DictionaryGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> ogrenciler = new MyDictionary<int, string>();

            Console.WriteLine("Ekleme işlemi: \n");
            ogrenciler.Add(1, "Enes");
            Console.WriteLine(ogrenciler.TryGetValue(1));
            ogrenciler.Add(1, "Esra"); // bu değeri eklemeyecektir

            ogrenciler.Remove(1);

            ogrenciler.Add(2, "Gülben");
            ogrenciler.Add(3, "Serdar");
            Console.WriteLine(ogrenciler.TryGetValue(1));


            foreach (var item in ogrenciler.dictionary)
            {
                Console.WriteLine(item.Value);
            }

        }
    }
}

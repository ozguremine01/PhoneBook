using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook
{
    class Sort
    {
        static public void SortNo()
        {
            Console.WriteLine(" (1)  Sıralama ölçütü: A-Z");
            Console.WriteLine(" (2)  Sıralama ölçütü: Z-A");
            List<string> advesoyad = new List<string>();
            for (int x = 0; x <= CRUD.results.Count - 1; x++)
            {
                advesoyad.Add(CRUD.results[x].adi.ToString() + " " + CRUD.results[x].soyadi.ToString());
            }
            advesoyad.Sort();
            string selected = Console.ReadLine().ToString();
            if (selected == "1")
            {               
                
                for (int x = 0; x <= CRUD.results.Count - 1; x++)
                {
                    Console.WriteLine("Adi ve soyad: " + advesoyad[x].ToString());
                }
                
                
            }
            else if (selected == "2")
            {                             
                for (int y = advesoyad.Count-1; y >= 0; y--)
                {
                    Console.WriteLine("Adi ve soyad: " + advesoyad[y].ToString());
                }
            }
            else
            {
                Console.WriteLine("Yanlış veri girdiniz...");
                new CRUD();
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook
{
    class Result
    {
        public string adi;
        public string soyadi;
        public string telno;
        public static int kisiSayisi = 0;

        
        public Result() { }
        public Result(string Adi, string Soyadi, string TelNo)
        {
            this.adi = Adi;
            this.soyadi = Soyadi;
            this.telno = TelNo;
            Result.kisiSayisi++;
            
        }
        public static int KisiSayisi()
        {
            return Result.kisiSayisi;
        }

        public static void Remove(int index1)
        {
            CRUD.results[index1].adi = "";
            CRUD.results[index1].soyadi = "";
            CRUD.results[index1].telno = "";
            Result.kisiSayisi--;
        }
       
        public static void Update(int index, string udata)
        {
            CRUD.results[index].adi = udata;
        }

        public static void WriteList()
        {
            for (int i = 0; i <= CRUD.results.Count - 1; i++)
            {
                Console.WriteLine("isim: " + CRUD.results[i].adi.ToString());
                Console.WriteLine("Soyisim: " + CRUD.results[i].soyadi.ToString());
                Console.WriteLine("Telefon Numarasi: " + CRUD.results[i].telno.ToString());
            }


        }
    }
}

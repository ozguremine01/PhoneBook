using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook
{
    class CRUD
    {
        public static List<Result> results = new List<Result>();
       
        public CRUD()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine(" *******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Siralamak");
            Console.WriteLine("(5) Rehberde Arama Yapmak");           
        }
        public int OpenPage()
        {
            int selectedchoose = Convert.ToInt32(Console.ReadLine());
            return selectedchoose;
        }

        public void Insert()
        {
            Console.WriteLine("Lütfen isim giriniz             :");
            string adi1 = Console.ReadLine().ToString();
            Console.WriteLine("Lütfen soyisim giriniz             :");
            string soyadi1 = Console.ReadLine().ToString();
            Console.WriteLine("Lütfen telefon numarası giriniz             :");
            string newtelephoneno1 = Console.ReadLine();           
            results.Add(new Result(adi1, soyadi1, newtelephoneno1));
            int sayi = Result.KisiSayisi();
            Console.WriteLine(sayi);
            Result.WriteList();
        }
       
        public void Delete()
        {

            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            string adveyasoyad = Console.ReadLine().ToString();
            for (int i = 0; i <= results.Count - 1; i++)
            {
                if (results[i].adi.Contains(adveyasoyad) == true || results[i].soyadi.Contains(adveyasoyad) == true)
                {
                    Console.WriteLine("{} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                    string selected = Console.ReadLine().ToString();

                    if (selected == "y")
                    {
                        Result.Remove(i);
                        Result.WriteList();

                    }
                    else if (selected == "n")
                    {
                        new CRUD();
                        OpenPage();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış veri girdiniz. Tekrar deneyin...");
                        DeleteNo();
                    }
                }
                else
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                    Console.WriteLine("* Yeniden denemek için      : (2)");
                    int selected = Convert.ToInt32(Console.ReadLine());
                    switch (selected)
                    {
                        case 1:
                            new CRUD();
                            break;
                        case 2:
                            DeleteNo();
                            break;

                        default:
                            Console.WriteLine("Yanlış veri girdiniz...");
                            new CRUD();
                            break;
                    }
                }

            }


        }

        public void Update()
        {
            
            Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
            string adsoyad = Console.ReadLine().ToString();
            for (int i = 0; i <= results.Count - 1; i++)
            {
                if (results[i].adi.Contains(adsoyad) == true || results[i].soyadi.Contains(adsoyad) == true)
                {
                    Console.WriteLine("{} isimli kişi rehberden güncellemek üzere, onaylıyor musunuz ?(y/n)");
                    string selected = Console.ReadLine().ToString();

                    if (selected == "y")
                    {
                        Console.WriteLine("Güncel kullanıcı adi soyadi: ");
                        string updated_adsoyad = Console.ReadLine().ToString();
                        Result.Update(i, updated_adsoyad);
                        Result.WriteList();
                        
                    }
                    else if (selected == "n")
                    {
                        new CRUD();
                        OpenPage();
                    }
                    else
                    {
                        Console.WriteLine("Yanlış veri girdiniz. Tekrar deneyin...");
                        UpdateNo();
                    }
                }
                else
                {
                    Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                    Console.WriteLine("* Güncellemeyi sonlandırmak için : (1)");
                    Console.WriteLine("* Yeniden denemek için      : (2)");
                    int selected = Convert.ToInt32(Console.ReadLine());
                    switch (selected)
                    {
                        case 1:
                            OpenPage();
                            break;
                        case 2:
                            UpdateNo();
                            break;

                        default:
                            Console.WriteLine("Yanlış veri girdiniz...");
                            OpenPage();
                            break;
                    }
                }
            }
        }
            
        public void Search()
        {
            Console.WriteLine(" Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine(" **********************************************");
            Console.WriteLine(" İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine(" Telefon numarasına göre arama yapmak için: (2)");
            string selected = Console.ReadLine().ToString();
           
            if (selected == "1")
            {
                Console.WriteLine("Lütfen kişinin adını ve soyadını giriniz:");
                string adsoyad = Console.ReadLine().ToString();
                for (int i = 0; i <= results.Count - 1; i++)
                {
                    if (results[i].adi.Contains(adsoyad) == true || results[i].soyadi.Contains(adsoyad) == true)
                    {
                        Console.WriteLine("isim: " + CRUD.results[i].adi.ToString());
                        Console.WriteLine("Soyisim: " + CRUD.results[i].soyadi.ToString());
                        Console.WriteLine("Telefon Numarasi: " + CRUD.results[i].telno.ToString());
                    }
                    else
                    {
                        Console.WriteLine("Böyle bir kullanıcı bulunamadı....");
                        break;
                    }
                }

            }
            else if (selected == "2")
            {               
                Console.WriteLine("Lütfen telefon numarası giriniz             :");
                string no = Console.ReadLine().ToString();
                for (int i = 0; i <= results.Count - 1; i++)
                {
                    if (results[i].telno.Contains(no) == true)
                    {
                        Console.WriteLine("isim: " + CRUD.results[i].adi.ToString());
                        Console.WriteLine("Soyisim: " + CRUD.results[i].soyadi.ToString());
                        Console.WriteLine("Telefon Numarasi: " + CRUD.results[i].telno.ToString());
                    }
                    else
                    {
                        Console.WriteLine("Böyle bir kullanıcı bulunamadı....");
                        break;
                    }
                }

            }
            else
            {
                Console.WriteLine("Böyle bir kullanici bulunamadi...");
                new CRUD();

            }           
        }
    }
}

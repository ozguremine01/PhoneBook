using System;
using System.Collections.Generic;
using System.Collections;
namespace PhoneBook
{
    
    class Program
    {

        static void Main(string[] args)
        {
            CRUD.results.Add(new User("zdeneme", "deneme", "05555555550"));
            CRUD.results.Add(new User("adeneme", "deneme", "05555555551"));
            CRUD.results.Add(new User("sdeneme", "deneme", "05555555552"));
            CRUD.results.Add(new User("bdeneme", "deneme", "05555555553"));
            CRUD.results.Add(new User("hdeneme", "deneme", "05555555554"));
          
            CRUD telephoneNoProcess = new CRUD();
            int selected = telephoneNoProcess.OpenPage();
            switch (selected)
            {
                case 1:
                    telephoneNoProcess.InsertNo();
                    break;
                    
                case 2:
                    telephoneNoProcess.DeleteNo();
                    break;
                case 3:
                    telephoneNoProcess.UpdateNo();
                    break;
                case 4:
                    Sort.SortNo();
                    break;
                case 5:
                    telephoneNoProcess.Searching();
                    break;
                default:
                    Console.WriteLine("Yanlış seçim yaptınız. Tekrar deneyin...");
                    new CRUD();
                    telephoneNoProcess.OpenPage();
                    break;
            }
        }
    }

   

    

}

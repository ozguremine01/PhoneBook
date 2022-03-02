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
                    telephoneNoProcess.Insert();
                    break;
                    
                case 2:
                    telephoneNoProcess.Delete();
                    break;
                case 3:
                    telephoneNoProcess.Update();
                    break;
                case 4:
                    Sort.Sort();
                    break;
                case 5:
                    telephoneNoProcess.Search();
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

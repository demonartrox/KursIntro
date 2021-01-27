using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            //GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer 
            { 
                Id = 1, 
                BirthYear = 1985, //bura 85 olmazsa başarısız olur.
                FistName = "ENGİN", 
                LastName = "DEMİROĞ", 
                IdentityNumber = 12345
            });

            Console.WriteLine("Hello World!");
        }
    }
}

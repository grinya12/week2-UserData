using System;

namespace UserPIN
{
    class Program
    {
        static void Main(string[] args)
        {
            //приложение просит пользователя ввести PIN-код.
            //Если введенный PIN-код "1234", то приложение приветствует пользователя
            //*и спрашивает его имя. А затем, приветствует пользователя по имени.
            //В ином случае, консоль выводит на экран сообщение об ошибке Invalid PIN.


            Console.WriteLine("Please enter your PIN:");
            string PIN = Console.ReadLine();
            if (PIN == "1234")

            {
                Console.WriteLine("Welcome!");
                Console.WriteLine("What is your name?");
                string userFirstName = Console.ReadLine();
                if (userFirstName == "admin")
                Console.WriteLine("Hello, " + "admin" + "!");

            } else
            
            
            {
                Console.WriteLine("Invalid PIN!");
            }

            Console.WriteLine("Have a nice day!");
        }
    }
}

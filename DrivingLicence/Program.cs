using System;

namespace DrivingLicence
{
    class Program
    {
        static void Main(string[] args)
        {
            //приложение просит пользователя ввести его год рождения
            //приложение вычисляет возраст пользователя (2022 - год рождения пользователя)
            //если пользователь моложе 18 лет, то в консоли выводится "too young to drive"
            //если пользователь старше 18 лет, то в консоли выводится "drive carefully"
            //а если пользователю 18 лет, то в консоли выводится "Congratulations, you may apply
            //"for your driving licence now"

            //*int result = 2022 - yearOfBirth;

            Console.WriteLine("Please enter your year of Birth:");
            int result = 2022 - Convert.ToInt32(Console.ReadLine());


            if (result < 18)
            {
                Console.WriteLine("You are too young to Drive.");

            }
            else if (result > 18)
            {
                Console.WriteLine("Drive carefully.");
            }
            else
            {
                Console.WriteLine("Congratulations, you may apply for your driving licence now.");
            }

            Console.WriteLine("Have a nice day!");

        }
    }
}

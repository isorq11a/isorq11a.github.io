using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Frågesport");
            Console.WriteLine("Vilken kategori vill du spela?");
            Console.WriteLine("1 För Mat, 2 För Tal");

            int kategori = int.Parse(Console.ReadLine());
            switch(kategori)


            {
                case 1:
                    Console.WriteLine("Skriv ett tal större än 100!");
                    int tal1 = int.Parse(Console.ReadLine());

                    if (tal1 > 100)
                    {
                        Console.WriteLine("Rätt Svar!");
                        Thread.Sleep(2000);
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Fel svar!");
                    }

                    Console.WriteLine("Skriv ett tal mindre än 100!");
                    int tal2 = int.Parse(Console.ReadLine());

                    if (tal2 < 100)
                    {
                        Console.WriteLine("Rätt Svar!");
                        Thread.Sleep(2000);
                        Console.Clear();
                    }

                    else
                    {
                        Console.WriteLine("Fel svar!");
                    }

                    Console.WriteLine("Skriv en av två siffror som blir den andra om man vänder på den!");
                    Console.WriteLine("Matta in siffran!");
                    int tal4 = int.Parse(Console.ReadLine());

                    if (tal4 == 6 || tal4 == 9)
                    {
                        Console.WriteLine("Rätt Svar!");
                    }

                    else
                    {
                        Console.WriteLine("Fel Svar!");
                    }
                    break;

                case 2:
                    Console.WriteLine("Vilka är dom två mest kända kebabrätterna?");
                    Console.WriteLine("Svara först med en av rätterna");
                    string kebabrätt1 = Console.ReadLine();
                    Console.WriteLine("Svara nu med den andra rätten");
                    string kebabrätt2 = Console.ReadLine();

                    if ((kebabrätt1 == "kebabrulle" && kebabrätt2 == "kebabpizza") || (kebabrätt2 == "kebabrulle" && kebabrätt1 == "kebabpizza"))
                    {

                        Console.WriteLine("Du klarade frågorna med två rätta svar!");
                    }

                    else
                    {
                        Console.WriteLine("Fel Svar!");
                    }

                    break;
                    







            }



          
            







            












        }
    }
}

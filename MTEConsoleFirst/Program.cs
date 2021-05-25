using System;

namespace MTEConsoleFirst
{
    /*
    Frågar om “Vad heter du”
    matar in värde -> strängvariabel
    Frågar om “Hur gammal är du”
    matar in värde -> intvariabel
    Skriver ut “Tjena hejsan Stefan” (eller vad man matade in som namn)
    Om åldern > 48 så skriv ut “Du är så gammal” annars skriv ut “Du är fortfarande
    ung”
    Kör en loop från 1 tillochmed ålder och skriver ut “År 1” osv osv 
     */


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vad heter du?");
            string namn = Console.ReadLine();

            Console.WriteLine("Hur gammal är du?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tjena hejsan " + namn);

            if (age > 48)
            {
                Console.WriteLine("Du är så gammal");
            }
            else
            {
                Console.WriteLine("Du är fortfarande ung");
            }


        }
    }
}

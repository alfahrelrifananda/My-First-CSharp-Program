using System;

public class Program
{
    public static void Main(string[] args)
    {
        // ! This is a comments
        /*
            This is a comments
            This is a comments
            This is a comments
            */
        string nama = "Fahrel";
        int umur = 20;
        bool mhs = true;
        double money = 1000.50;
        char initial = 'F';

        System.Console.WriteLine("Hallo, Welt!");
        System.Console.WriteLine("Ich heiße " + nama);
        System.Console.WriteLine("Mein Anfangsbuchstabe ist " + initial);
        System.Console.WriteLine("Ich bin " + umur + " Jahre alt");
        System.Console.WriteLine("Ich bin Student: " + mhs);
        System.Console.WriteLine("Ich habe " + money + " Rupiah");
        System.Console.WriteLine();
        System.Console.Write("Say your name : ");
        string input = Console.ReadLine();
        System.Console.WriteLine("Hallo " + input);
    }
}

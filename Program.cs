using System;

public class Program
{
    public static void Main(string[] args)
    {
        // ! Praktikum 1
        // * Variabel
        /*
        System.Console.Write("Masukkan Nama : ");
        string nama = Console.ReadLine();

        System.Console.Write("Masukkan Umur : ");
        int umur = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("Masukkan Jenis Kelamin (L/P) : ");
        char jenisKelamin = Convert.ToChar(Console.ReadLine());

        System.Console.Write("Apakah Sudah Lulus Sekolah? (True/False) : ");
        bool isLulus = Convert.ToBoolean(Console.ReadLine());

        System.Console.Write("Kota Asal : ");
        string kotaAsal = Console.ReadLine();

        System.Console.WriteLine("===============================================");
        System.Console.WriteLine("DATA PENGGUNA");
        System.Console.WriteLine("-----------------------------------------------");
        System.Console.WriteLine("Nama Lengkap   : " + nama);
        System.Console.WriteLine("Umur           : " + umur + " Tahun");
        System.Console.WriteLine("Jenis Kelamin  : " + jenisKelamin);
        System.Console.WriteLine("Lulus Sekolah  : " + isLulus);
        System.Console.WriteLine("Kota Asal      : " + kotaAsal);
        System.Console.WriteLine("===============================================");
        */

        // ? Materi 2
        // * Operator Aritmatika
        /*
        int a = 10, b = 3;

        System.Console.WriteLine(a + b); // Penjumlahan
        System.Console.WriteLine(a - b); // Pengurangan
        System.Console.WriteLine(a * b); // Perkalian
        System.Console.WriteLine(a / b); // Pembagian
        System.Console.WriteLine(a % b); // Modulus
        */
        // * Operator Perbandingan
        /*
        int x = 5, y = 10;

        System.Console.WriteLine(x < y); // Kurang Dari = True
        System.Console.WriteLine(x == y); // Sama Dengan = False
        System.Console.WriteLine(x != y); // Tidak Sama Dengan = True
        System.Console.WriteLine(x >= 5); // Lebih Dari Sama Dengan = True
        */
        // * Operator Logika
        /*
        bool a = true, b = false;

        System.Console.WriteLine(a && b); // AND (True jika keduanya True) = False
        System.Console.WriteLine(a || b); // OR (True jika salah satu True) = True
        System.Console.WriteLine(!a); // NOT (Kebalikan) = False
        System.Console.WriteLine(!b); // NOT (Kebalikan) = True

        int x = 5, y = 10, z = 3;
        System.Console.WriteLine((x < y) && (y > z)); // AND (True jika keduanya True)
        System.Console.WriteLine((x == y) || (z < x)); // OR (True jika salah satu True)
        */

        // * Operator Penugasan
        /*
        int x = 10;
        x += 5; // x = x + 5
        x -= 3; // x = x - 3
        x *= 2; // x = x * 2
        x /= 4; // x = x / 4
        x %= 3; // x = x % 3
        System.Console.WriteLine(x);
        */

        // * Operator Increament dan Decremeant
        int x = 5;
        x++; // x = x + 1
        x--; // x = x - 1
        System.Console.WriteLine(x);
    }
}

using System;
using System.Text;

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
        /*
        int x = 5;
        x++; // x = x + 1
        x--; // x = x - 1
        System.Console.WriteLine(x);
        */

        // ? Materi 3
        // * Percabangan If, Else If, Else
        /*
        int umur = 18;

        if (umur >= 17)
        {
            System.Console.WriteLine("Anda boleh membuat KTP");
        }
        else
        {
            System.Console.WriteLine("Anda belum boleh membuat KTP");
        }
        */
        // * Percabangan bertingkat
        /*
        int nilai = 75;

        if (nilai >= 85)
        {
            System.Console.WriteLine("Nilai A");
        }
        else if (nilai >= 70)
        {
            System.Console.WriteLine("Nilai B");
        }
        else if (nilai >= 55)
        {
            System.Console.WriteLine("Nilai C");
        }
        else
        {
            System.Console.WriteLine("Nilai D");
        }
        */
        // * Switch-case
        /*
        int hari = 3;
        switch (hari)
        {
            case 1:
                System.Console.WriteLine("Senin");
                break;
            case 2:
                System.Console.WriteLine("Selasa");
                break;
            case 3:
                System.Console.WriteLine("Rabu");
                break;
            case 4:
                System.Console.WriteLine("Kamis");
                break;
            case 5:
                System.Console.WriteLine("Jum'at");
                break;
            case 6:
                System.Console.WriteLine("Sabtu");
                break;
            case 7:
                System.Console.WriteLine("Minggu");
                break;
            default:
                System.Console.WriteLine("Invalid");
                break;
        }
        */

        /*
        System.Console.Write("Masukkan nama buah : ");
        string buah = System.Console.ReadLine().ToLower();

        switch (buah)
        {
            case "mangga":
                System.Console.WriteLine("Buah warna oranye");
                break;
            case "pisang":
                System.Console.WriteLine("Buah warna kuning");
                break;
            case "apel":
            case "strawberry":
                System.Console.WriteLine("Buah warna merah");
                break;
            default:
                System.Console.WriteLine("Invalid");
                break;
        }
        */

        // ? Materi 4
        // * Perulangan
        // * For
        /*
        for (int i = 1; i <= 33; i++)
        {
            System.Console.WriteLine($"Perulangan ke {i}");
        }
        */

        // * While
        /*
        int j = 1;
        while (j <= 33)
        {
            System.Console.WriteLine($"Perulangan ke {j}");
            j++;
        }
        */

        // * Do While
        /*
        int k = 1;
        do
        {
            System.Console.WriteLine($"Perulangan ke {k}");
            k++;
#        } while (k <= 33);
        */

        // * Break dan Continue
        /*
        for (int i = 1; i <= 33; i++)
        {
            if (i == 13)
            {
                // Skip
                continue;
            }
            if (i == 15)
            {
                // Berhenti
                break;
            }
            System.Console.WriteLine($"Perulangan ke {i}");
        }
        */

        // ? Materi Pertemuan 7 - Prosedur dan Fungsi
        // * Prosedur tanpa Parameter
        /*
        Halo();
        Halo();
        Halo();
        */
        // * Prosedur dengan Parameter
        /*
        Sapa("Fahrel");
        Sapa("Indra");
        Sapa("Abi");
        Sapa("Rizky");
        */
        //  * Fungsi dengan parameter integer
        /*
        KelipatanDua(5);
        KelipatanTiga(5);
        */

        // * Double Parameter
        /*
        int panjang;
        int lebar;

        System.Console.Write("Masukkan Panjang : ");
        panjang = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("Masukkan Lebar : ");
        lebar = Convert.ToInt32(Console.ReadLine());

        LuasPersegiPanjang(panjang, lebar);
        */

        // ? Materi 7 : Fungsi
        // Fungsi mereturn nilai dengan tipe data
        // Prosedur tidak mereturn nilai (void)
        /*
        System.Console.WriteLine($"Hasil tambah : {tambah(5, 10)}");
        System.Console.WriteLine($"Hasil Angka Random : {angkaRandom()}");
        System.Console.Write("Masukkan alas : ");
        double alas = Convert.ToDouble(Console.ReadLine());
        System.Console.Write("Masukkan tinggi : ");
        double tinggi = Convert.ToDouble(Console.ReadLine());
        System.Console.WriteLine($"Hasil Luas Segitiga : {luasSegitiga(alas, tinggi)}");
        System.Console.WriteLine($"Hasil Luas Persegi : {hasilLuasPersegi(alas, tinggi)}");
        
        */

        // ? Materi 8
        // * Array
        /*
        int[] nilai = new int[5];

        for (int i = 0; i < nilai.Length; i++)
        {
            System.Console.WriteLine("Masukkan Nilai : ");
            nilai[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < nilai.Length; i++)
        {
            System.Console.Write(nilai[i] + " ");
        }
        */

        // * 2D Array
        /*
        int[,] nilai2d = { { 1, 2, 3 },
                           { 4, 5, 6 },
                           { 7, 8, 9 } };
                           
        for (int i = 0; i < nilai2d.GetLength(0); i++)
        {
            for (int j = 0; j < nilai2d.GetLength(1); j++)
            {
                System.Console.Write(nilai2d[i, j] + " ");
            }
            System.Console.WriteLine();
        }
        */

        int[,] matrix = { { 1, 2, 3 },
                          { 4, 5, 6 },
                          { 7, 8, 9 } };

        // Kolom   : 0 1 2
        // Baris 0 = 1 2 3
        // Baris 1 = 4 5 6
        // Baris 2 = 7 8 9

        /*
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                System.Console.Write(matrix[i, j] + " ");
            }
            System.Console.WriteLine();
        }
        */

        int[,] nilai = new int[2, 3];
        int panjangBaris = nilai.GetLength(0);
        int panjangKolom = nilai.GetLength(1);

        for (int i = 0; i < panjangBaris; i++)
        {
            for (int j = 0; j < panjangKolom; j++)
            {
                System.Console.Write("Masukkan Nilai "  + i + "," + j + " : ");
                nilai[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        System.Console.WriteLine("Hasil input : ");
        for (int i = 0; i < nilai.GetLength(0); i++)
        {
            for (int j = 0; j < nilai.GetLength(1); j++)
            {
                System.Console.Write(nilai[i, j] + " ");
            }
            System.Console.WriteLine();
        }
                          
   }
















    static double hasilLuasPersegi(double a, double b)
    {
        return luasPersegi(a, b);
    }

    static double luasPersegi(double a, double b)
    {
        return a * b;
    }

    static double luasSegitiga(double alas, double tinggi)
    {
        return 0.5 * alas * tinggi;
    }

    static int angkaRandom()
    {
        Random rand = new Random();
        return rand.Next(1, 101);
    }

    static int tambah(int a, int b)
    {
        return a + b;
    }

    public static void Halo()
    {
        System.Console.WriteLine("Halo Semua");
    }

    public static void Sapa(String nama)
    {
        System.Console.WriteLine("Halo " + nama);
    }

    public static void KelipatanDua(int angka)
    {
        System.Console.WriteLine("Kelipatan dua dari " + angka + " adalah " + (angka * 2));
    }

    public static void KelipatanTiga(int angka)
    {
        System.Console.WriteLine("Kelipatan tiga dari " + angka + " adalah " + (angka * 3));
    }

    public static void LuasPersegiPanjang(int panjang, int lebar)
    {
        int luas = panjang * lebar;
        System.Console.WriteLine("Luas Persegi Panjang adalah " + luas);
    }
}

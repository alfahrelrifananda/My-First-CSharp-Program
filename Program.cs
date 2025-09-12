using System;
public class Program
{
    public static void Main(string[] args)
    {
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

        if (kotaAsal == "Solo")
        {
            System.Console.WriteLine("Wah, kamu dari kota yang sama denganku!");
        }

        if (isLulus == true)
        {
            System.Console.WriteLine("Selamat ya, semoga sukses di masa depan!");
        }

        System.Console.WriteLine("===============================================");
        System.Console.WriteLine("DATA PENGGUNA");
        System.Console.WriteLine("-----------------------------------------------");
        System.Console.WriteLine("Nama Lengkap   : " + nama);
        System.Console.WriteLine("Umur           : " + umur + " Tahun");
        System.Console.WriteLine("Jenis Kelamin  : " + jenisKelamin);
        System.Console.WriteLine("Lulus Sekolah  : " + isLulus);
        System.Console.WriteLine("Kota Asal      : " + kotaAsal);
        System.Console.WriteLine("===============================================");
    }
}

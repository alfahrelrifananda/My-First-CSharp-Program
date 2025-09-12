System.Console.WriteLine("Masukkan Nama : ");
string nama = Console.ReadLine();

System.Console.WriteLine("Masukkan Umur : ");
int umur = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Masukkan Jenis Kelamin (L/P) : ");
char jenisKelamin = Convert.ToChar(Console.ReadLine());

System.Console.WriteLine("Apakah Sudah Lulus Sekolah? (True/False) : ");
bool isLulus = Convert.ToBoolean(Console.ReadLine());

System.Console.WriteLine("Kota Asal : ");
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

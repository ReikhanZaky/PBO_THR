using System;

class Karyawan
{
    private string nama;
    private string id;
    private double gajiPokok;


    public Karyawan(string nama, string id, double gajiPokok)
    {
        this.nama = nama;
        this.id = id;
        this.gajiPokok = gajiPokok;
    }

    
    public string Nama
    {
        get { return nama; }
        set { nama = value; }
    }

    public string ID
    {
        get { return id; }
        set { id = value; }
    }

    public double GajiPokok
    {
        get { return gajiPokok; }
        set { gajiPokok = value; }
    }

    public virtual double HitungGaji()
    {
        return gajiPokok;
    }
    //Menggunakan metode virtual dan override untuk memberikan implementasi yang berbeda pada setiap kelas turunan.
}

//Pertama buat parent class Karyawan dengan atribut privat nama, id, gajiPokok dengan method HitungGaji untuk soal nomer 3,
//dan buat constructor untuk menginisialisasi atribut-atribut tersebut.

class KaryawanTetap : Karyawan
{
    public KaryawanTetap(string nama, string id, double gajiPokok)
        : base(nama, id, gajiPokok) { }

    public override double HitungGaji()
    {
        return GajiPokok + 500000;
    }
}

//Kedua buat subclass KaryawanTetap yang mewarisi dari Karyawan dengan menambahkan gaji tetap 500000 pada method HitungGaji.

class KaryawanKontrak : Karyawan
{
    public KaryawanKontrak(string nama, string id, double gajiPokok)
        : base(nama, id, gajiPokok) { }

    public override double HitungGaji()
    {
        return GajiPokok - 200000;
    }
}

//Ketiga buat subclass KaryawanKontrak yang mewarisi dari Karyawan dengan mengurangi gaji pokok 200000 pada method HitungGaji.

class KaryawanMagang : Karyawan
{
    public KaryawanMagang(string nama, string id, double gajiPokok)
        : base(nama, id, gajiPokok) { }

    public override double HitungGaji()
    {
        return GajiPokok;
    }
}

//Keempat buat subclass KaryawanMagang yang mewarisi dari Karyawan tanpa mengubah gaji pokok pada method HitungGaji.

class Program
{
    static void Main()
    {
        Console.WriteLine("+++++ Sistem Manajemen Karyawan +++++");
        Console.WriteLine("1. Karyawan Tetap");
        Console.WriteLine("2. Karyawan Kontrak");
        Console.WriteLine("3. Karyawan Magang");

        Console.Write("Pilih jenis karyawan (1/2/3): ");
        string pilihan = Console.ReadLine();

        Console.Write("Masukkan Nama: ");
        string nama = Console.ReadLine();

        Console.Write("Masukkan ID: ");
        string id = Console.ReadLine();

        Console.Write("Masukkan Gaji Pokok: ");
        double gajiPokok = Convert.ToDouble(Console.ReadLine());
        //Input gaji pokok menggunakan Convert.ToDouble untuk mengkonversi string ke double.

        Karyawan karyawan;

        switch (pilihan)
        {
            case "1":
                karyawan = new KaryawanTetap(nama, id, gajiPokok);
                break;
            case "2":
                karyawan = new KaryawanKontrak(nama, id, gajiPokok);
                break;
            case "3":
                karyawan = new KaryawanMagang(nama, id, gajiPokok);
                break;
            default:
                Console.WriteLine("Pilihan tidak valid.");
                return;
        }

        Console.WriteLine("\n+++++ Informasi Gaji +++++");
        Console.WriteLine($"Nama: {karyawan.Nama}");
        Console.WriteLine($"ID: {karyawan.ID}");
        Console.WriteLine($"Gaji Akhir: Rp {karyawan.HitungGaji():N0}");
    }
}

//Program ini adalah sistem manajemen karyawan sederhana.
//Program ini menggunakan konsep pewarisan dan polimorfisme untuk menghitung gaji karyawan berdasarkan jenisnya.
//Program ini meminta input dari pengguna untuk jenis karyawan, nama, id, dan gaji pokok, lalu menampilkan informasi gaji akhir berdasarkan jenis karyawan yang dipilih.
//KaryawanTetap menambahkan gaji tetap 500000, KaryawanKontrak mengurangi gaji pokok 200000, dan KaryawanMagang tidak mengubah gaji pokok.
//Program ini juga menangani beberapa kesalahan input dari pengguna.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Responsi02
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahMahasiswa();
                        break;

                    case 2:
                        HapusMahasiswa();
                        break;

                    case 3:
                        TampilMahasiswa();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            Console.WriteLine("");

            Console.WriteLine("Silahkan Pilih: ");
            Console.WriteLine("1. Tambah Mahasiswa");
            Console.WriteLine("2. Hapus Mahasiswa ");
            Console.WriteLine("3. Tampilkan Mahasiswa ");
            Console.WriteLine("4. Keluar ");

            Console.WriteLine("");
        }

        static void TambahMahasiswa()
        {
            Mahasiswa mahasiswa = new Mahasiswa();
            Console.Clear();

            Console.WriteLine("Tambah Data Mahasiswa");
            Console.Write("\nNIM  :");
            mahasiswa.Nim = Console.ReadLine();

            Console.Write("Nama  :");
            mahasiswa.Nama = Console.ReadLine();

            Console.Write("Jenis Kelamin [L/P]  :");
            string jenis = Console.ReadLine();

            mahasiswa.JenisKelamin = (jenis == "L" || jenis == "P") ? "LakiLaki" : "Perempuan";
           

            Console.Write("IPK  :");
            mahasiswa.Ipk = Console.ReadLine();

            daftarMahasiswa.Add(mahasiswa);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusMahasiswa()
        {
            Console.Clear();

            Console.WriteLine("Hapus Data Mahasiswa");

            bool found = true;

            string NIM;
            Console.Write("\nNIM  :");
            NIM = Console.ReadLine();

            for (int i = 0; i < daftarMahasiswa.Count; i++)
            {
                if (NIM == daftarMahasiswa[i].Nim)
                {
                    daftarMahasiswa.Remove(daftarMahasiswa[i]);
                    found = true;
                    break;
                }
                else
                {
                    found = false;
                }
            }
            if (!found)
            {
                Console.WriteLine("NIIM tidak ditemukan");
            }
            else
            {
                Console.WriteLine("Data Mahasiswa Berhasil Di Hapus");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilMahasiswa()
        {
            Console.Clear();

            Console.WriteLine("Data Mahasiswa");

            if (daftarMahasiswa.Count > 0)
            {
                for (int i = 0; i < daftarMahasiswa.Count; i++)
                {
                    Console.WriteLine("{0}. {1}, {2}, {3}", i + 1, daftarMahasiswa[i].Nim, daftarMahasiswa[i].JenisKelamin, daftarMahasiswa[i].Ipk);
                }
            }
            else
            {
                Console.WriteLine(" Tidak Ada Daftar Mahasiswa");
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}

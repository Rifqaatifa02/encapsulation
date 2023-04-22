using System;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa mhs1 = new Mahasiswa("Budi", 21);
            Mahasiswa mhs2 = new Mahasiswa("Asep", 20);
            Mahasiswa mhs3 = new Mahasiswa("Yanto", 23);

            Console.WriteLine("Total Mahasiwa : {0}", Mahasiswa.jumlahMahasiswa);
            Console.WriteLine("Nama mahasiswa 1 : {0} berusia {1} tahun.", mhs1.NamaMahasiswa, mhs1.UmurMahasiswa);
            Console.WriteLine("Nama mahasiswa 2 : {0} berusia {1} tahun.", mhs2.NamaMahasiswa, mhs2.UmurMahasiswa);
            Console.WriteLine("Nama mahasiswa 3 : {0} berusia {1} tahun.", mhs3.NamaMahasiswa, mhs3.UmurMahasiswa);
            Console.ReadKey();
        }
    }
}
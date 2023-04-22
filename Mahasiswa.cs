using System;
namespace Encapsulation
{
    internal class Mahasiswa
    {
        public static int jumlahMahasiswa = 0;
        public string nama;
        public int umur;

        public Mahasiswa(string Nama, int Umur)
        {
            this.nama = Nama;
            this.umur = Umur;
            jumlahMahasiswa++;
        }
        public string NamaMahasiswa
        {
            get { return nama; }
            set { nama = value; }
        }
        public int UmurMahasiswa
        {
            get { return umur; }
            set { umur = value; }
        }
    }
}


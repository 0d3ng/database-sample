//
//  Mahasiswa.cs
//
//  Author:
//       Noprianto <lepengdados@gmail.com>
//
//  Copyright (c) 2018 Always Free
//
// Program ini bebas digunakan, terutama untuk kepentingan pendidikan 
// atau perorangan yang ingin belajar pemrograman C# dari awal.
// Semoga bermanfaat, selamat belajar C#.
//
// Happy coding,
// Noprianto
using System;
namespace DatabaseDemo
{
    public class Mahasiswa
    {

        private string nim;
        private string nama;
        private float ipk;

        public Mahasiswa()
        {
        }

        public Mahasiswa(string nim, string nama, float ipk)
        {
            this.nim = nim;
            this.nama = nama;
            this.ipk = ipk;
        }

        public string Nim { get => nim; set => nim = value; }
        public string Nama { get => nama; set => nama = value; }
        public float Ipk { get => ipk; set => ipk = value; }

        public override string ToString()
        {
            return string.Format("[Mahasiswa: Nim={0}, Nama={1}, Ipk={2}]", Nim, Nama, Ipk);
        }
    }
}

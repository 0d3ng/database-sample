//
//  Main.cs
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
    public class Program
    {
        public Program()
        {
        }

        public static void Main(String[] ar)
        {
            Query query = new Query();
            Mahasiswa mahasiswa = new Mahasiswa("07540099", "Noprianto", 4F);
            try
            {
                //Console.WriteLine(query.InsertMahasiswa(mahasiswa));
                foreach (Mahasiswa item in query.GetAllMahasiswa())
                {
                    Console.WriteLine(item);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

        }
    }
}

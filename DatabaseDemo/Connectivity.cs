//
//  Connectivity.cs
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
using MySql.Data.MySqlClient;
namespace DatabaseDemo
{
    class Connectivity
    {
        private MySqlConnection conn;
        private string conString;

        public Connectivity()
        {
            conString = "Server=localhost;Database=pemrograman_terstruktur;Uid=root;Pwd=;";
            // You might have to manually add in the password field in the connection string.

            Conn = new MySqlConnection(conString);
        }

        public MySqlConnection Conn { get => conn; set => conn = value; }

        public bool OpenConnection()
        {
            try
            {
                Conn.Open(); //open the connection
                Console.WriteLine(" Connection Status: " + Conn.Ping());
                return true;
                // Ping() returns true if connection has been successfully established
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

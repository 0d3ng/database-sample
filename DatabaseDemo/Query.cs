//
//  Query.cs
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
using System.Collections.Generic;
using System.Collections;
namespace DatabaseDemo
{
    public class Query
    {

        private Connectivity connectivity;
        private MySqlCommand command;

        public Query()
        {
            this.connectivity = new Connectivity();
            this.command = new MySqlCommand();
        }

        public bool InsertMahasiswa(Mahasiswa mahasiswa)
        {
            try
            {
                if (connectivity.OpenConnection())
                {
                    string q = "INSERT INTO mahasiswa(nim,nama,ipk) VALUES('" + mahasiswa.Nim + "','" + mahasiswa.Nama + "'," + mahasiswa.Ipk + ")";
                    Console.WriteLine("{0}", mahasiswa);
                    Console.WriteLine("query: {0}",q);
                    command.CommandText = q;
                    command.Connection = connectivity.Conn;
                    return command.ExecuteNonQuery() > 0 ? true : false;
                }
            }
            catch(Exception e)
            {
                throw e;
            }
            return true;
        }

        public bool DeleteMahasiswa(Mahasiswa mahasiswa)
        {
            try
            {
                if (connectivity.OpenConnection())
                {
                    string q = "DELETE FROM mahasiswa WHERE nim='"+mahasiswa.Nim+"'";
                    Console.WriteLine("{0}", mahasiswa);
                    Console.WriteLine("query: {0}", q);
                    command.CommandText = q;
                    return command.ExecuteNonQuery() > 0 ? true : false;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return true;
        }


        public bool UpdateMahasiswa(Mahasiswa mahasiswa)
        {
            try
            {
                if (connectivity.OpenConnection())
                {
                    string q = "UPDATE mahasiswa SET nama='"+mahasiswa.Nama+"',ipk='"+mahasiswa.Ipk+"' WHERE nim='" + mahasiswa.Nim + "'";
                    Console.WriteLine("{0}", mahasiswa);
                    Console.WriteLine("query: {0}", q);
                    command.CommandText = q;
                    command.Connection = connectivity.Conn;
                    return command.ExecuteNonQuery() > 0 ? true : false;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return true;
        }

        public List<Mahasiswa> GetAllMahasiswa()
        {
            List<Mahasiswa> mahasiswas = new List<Mahasiswa>();
            try
            {
                if (connectivity.OpenConnection())
                {
                    string q = "SELECT nim,nama,ipk FROM mahasiswa";
                    Console.WriteLine("query: {0}", q);
                    command.CommandText = q;
                    command.Connection = connectivity.Conn;
                    MySqlDataReader dataReader = command.ExecuteReader();
                    while(dataReader.Read())
                    {
                        Mahasiswa mahasiswa = new Mahasiswa();
                        mahasiswa.Nim = dataReader["nim"].ToString();
                        mahasiswa.Nama = dataReader["nama"].ToString();
                        mahasiswa.Ipk = float.Parse(dataReader["ipk"].ToString());
                        mahasiswas.Add(mahasiswa);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return mahasiswas;
        }
    }
}

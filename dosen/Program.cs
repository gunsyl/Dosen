using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Dosen
{
    class program
    {
        static void Main(string[] args)
        {

            DosenKu dosen = new DosenKu(1,"Dosen pengampu", "12345", "Male", "Pemrograman Berorientasi Objek");

            Console.WriteLine("Default Dosen Pengampu: \n");

            dosen.display();

            Console.WriteLine("\nMasukkan Nama dan NIK Dosen Baru: ");   

            //Console.WriteLine("\nMasukkan Mata Kuliah Baru: ");            

            Console.WriteLine();
        }
    } 
}
using System;
namespace Dosen
{
    class program
    {
        static void Main(string[] args)
        {
            DosenKu dosen = new DosenKu("Dosen pengampu", "12345", "Male", "OOP");

            Console.WriteLine("Default Dosen Pengampu: ");       

            Console.WriteLine("\nMasukkan Nama dan NIK Dosen Baru: ");   

            Console.WriteLine("\nMasukkan Mata Kuliah Baru: ");            

            Console.WriteLine();
        }
    } 
}
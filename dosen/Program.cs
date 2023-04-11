using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Dosen
{
    class program
    {
        static void Main(string[] args)
        {
            int id = 1;
            string name = "Dosen Pengampu";
            string nik = "1442245";
            string gender = "Male";
            string course = "Pemrograman Berorientasi Objek";

            DosenKu dosen = new DosenKu(id, name, nik, gender, course);

            Console.WriteLine("Default Dosen Pengampu: \n");
            dosen.display();

            Console.WriteLine("\nMasukkan Nama dan NIK Dosen Baru: ");
            Console.Write("Nama\t: ");            
            name = Console.ReadLine();
            Console.Write("NIK\t: ");
            nik = Console.ReadLine();

            dosen.attDosen(name, nik);
            Console.WriteLine("\nTAMPILKAN DATA:");
            dosen.display();

            Console.WriteLine("\nMasukkan mata kuliah baru: ");
            course = Console.ReadLine();
            dosen.addCourse(course);    
            Console.WriteLine("\nTAMPILKAN DATA:");
            dosen.display();
        }
    } 
}
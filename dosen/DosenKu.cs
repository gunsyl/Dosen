using System;

namespace Dosen {
    public class DosenKu
    
    {
        public int id;
        public string nama;
        public string nik;
        public string gender;
        public string course;

        

        public DosenKu(int id,string nama, string nik, string gender, string course)
        {
            this.id = id;
            this.nama = nama;
            this.nik = nik;
            this.gender = gender;
            this.course = course;
        }

        public void display()
        {
            Console.WriteLine($"ID : {this.id}");
            Console.WriteLine($"Nama : {this.nama}");
            Console.WriteLine($"NIK : {this.nik}");
            Console.WriteLine($"Gender : {this.gender}");
            Console.WriteLine($"Course : {this.course}");
        }

        public void addCourse(string course) 
        {
            course += "," + course;
        }
    }

}

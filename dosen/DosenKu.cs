using System;

namespace Dosen {
    public class DosenKu
    
    {
        private int id;
        public string nama, nik;        
        private string gender;
        private string course;

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
            Console.WriteLine($"ID \t: {this.id}");
            Console.WriteLine($"Nama \t: {this.nama}");
            Console.WriteLine($"NIK \t: {this.nik}");
            Console.WriteLine($"Gender \t: {this.gender}");
            Console.WriteLine($"Course \t: {this.course}");
        }

        public void attDosen(string name, string nik)
        {
            this.nama = name;
            this.nik = nik;
        }

        public void addCourse(string course) 
        {
            this.course += ", " + course;
        }
    }

}

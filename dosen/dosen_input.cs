using System;
using System.Reflection.Metadata.Ecma335;

private string nama;
private int Nik;
private string gender;
private string course;

public Dosen()
{
    id = 1;
    nama = "Dosen Pengampu";
    Nik = 167098;
    gender = "Male";
    course = "Pemrograman berorientasi objek";
}

pubic void attDosen(string name, int nik)
    {
    nama = name;
    Nik = nik;
    }

public void addCourse(string newCourse)
{
    addCourse += ", " + newCourse;
}

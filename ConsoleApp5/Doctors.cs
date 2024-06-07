using System;
using System.Collections.Generic;

namespace ConsoleApp3;
public class Doctor
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Experience { get; set; }
    public Dictionary<string, bool> AcceptionTime { get; set; }
    public Doctor(string name, string surname, int experince)
    {
        Name = name;
        Surname = surname;
        Experience = experince;
        AcceptionTime = new Dictionary<string, bool>
        {
            {"9:00-11:00",false},
            {"12:00-14:00",false},
            {"15:00-17:00",false }


        };
    }
    public void ShowAcceptionTime()
    {
        foreach (var time in AcceptionTime)
        {
            string fullorfree = time.Value ? "Rezerv olunub" : "Rezerv olunmayib";
            Console.WriteLine($"{time.Key}-{fullorfree}");
        }
    }
}

public class Pediatr : Doctor
{
    public Pediatr(string name, string surname, int experince) : base(name, surname, experince)
    {
    }
}

public class Travmatolog : Doctor
{
    public Travmatolog(string name, string surname, int experince) : base(name, surname, experince)
    {
    }
}

public class Stamatolog : Doctor
{
    public Stamatolog(string name, string surname, int experince) : base(name, surname, experince)
    {
    }
}
public class Department
{
    public string DName { get; set; }
    public List<Doctor> Doctors { get; set; }

    public Department(string dname)
    {
        DName = dname;
        Doctors = new List<Doctor>();
    }
}

public class Acception
{
    public string UserName { get; set; }
    public string UserSurname { get; set; }
    public string Mail { get; set; }
    public string Phone { get; set; }
    public Doctor ChoisenDoctor { get; set; }
    public string ChoisenTime { get; set; }

    public Acception(string userName, string userSurname, string mail, string phone, Doctor choisenDoctor, string choisenTime)
    {
        UserName = userName;
        UserSurname = userSurname;
        Mail = mail;
        Phone = phone;
        ChoisenDoctor = choisenDoctor;
        ChoisenTime = choisenTime;

    }

    public void showAccept()
    {
        Console.WriteLine($"{UserName} {UserSurname} siz saat {ChoisenTime} da {ChoisenDoctor.Name}{ChoisenDoctor.Surname} qebuluna yazildiz");
    }
}

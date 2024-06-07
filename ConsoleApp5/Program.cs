using ConsoleApp3;

class Program
{
    static void Main(string[] args)
    {
        List<Department> departments = new List<Department>();

        Department pediatre = new Department("Pediatr sobesi");
        pediatre.Doctors.Add(new Pediatr("Aygun", "Bayramov", 10));
        pediatre.Doctors.Add(new Pediatr("Munevver", "-", 10));

        Department travmatologiya = new Department("Travmatologiya sobesi");
        travmatologiya.Doctors.Add(new Travmatolog("Rubab", "Huseynova", 10));
        travmatologiya.Doctors.Add(new Travmatolog("Revan", "-", 10));

        Department stamatologiya = new Department("Stamatologiya sobesi");
        stamatologiya.Doctors.Add(new Stamatolog("Sabina", "Shakiyeva", 10));
        stamatologiya.Doctors.Add(new Stamatolog("Nizami", " -", 10));

        departments.Add(pediatre);
        departments.Add(travmatologiya);
        departments.Add(stamatologiya);



        while (true)
        {
            Console.Write("Adinizi daxil edin: ");
            string userName = Console.ReadLine();
            Console.Write("Soyadinizi daxil edin: ");
            string userSurname = Console.ReadLine();
            Console.Write("Emailinizi daxil edin: ");
            string email = Console.ReadLine();
            Console.Write("Telefonunuzu daxil edin: ");
            string phone = Console.ReadLine();

            Console.WriteLine("Sobeni secin:");
            int departmentIndex = 0;
            int departmentCount = departments.Count;
            while (departmentIndex < departmentCount)
            {
                Console.WriteLine($"{departmentIndex + 1}. {departments[departmentIndex].DName}");
                departmentIndex++;
            }

            departmentIndex = int.Parse(Console.ReadLine()) - 1;
            Department selectedDepartment = departments[departmentIndex];

            Console.WriteLine("Hekimi secin:");
            int doctorIndex = 0;
            int doctorCount = selectedDepartment.Doctors.Count;
            while (doctorIndex < doctorCount)
            {
                Console.WriteLine($"{doctorIndex + 1}. {selectedDepartment.Doctors[doctorIndex].Name} {selectedDepartment.Doctors[doctorIndex].Surname}, Experience: {selectedDepartment.Doctors[doctorIndex].Experience} years");
                doctorIndex++;
            }

            doctorIndex = int.Parse(Console.ReadLine()) - 1;
            Doctor selectedDoctor = selectedDepartment.Doctors[doctorIndex];

            string selectedTime = "";
            while (true)
            {
                Console.WriteLine("Rezerv elemek istediyiniz saati secin:");
                selectedDoctor.ShowAcceptionTime();
                selectedTime = Console.ReadLine();

                if (selectedDoctor.AcceptionTime.ContainsKey(selectedTime) && !selectedDoctor.AcceptionTime[selectedTime])
                {
                    selectedDoctor.AcceptionTime[selectedTime] = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Hemen vaxt artiq rezerv olunub, zehmet olmasa basqa bir vaxt secin.");
                }
            }

            Acception acception = new Acception(userName, userSurname, email, phone, selectedDoctor, selectedTime);
            acception.showAccept();

        }

    }
}


using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Holding Object
            Holding holding = new Holding()
            {
                Id = 1,
                Name = "Pasha Holding",
            };
            // Company Object
            Company company = new Company()
            {
                Id=1,
                Name="Pasha Sigorta",
            };
            // Department Objects
            Department department1 = new Department()
            {
                Id = 1,
                Name = SpecialtyEnum.Marketing.ToString(),
            };
            Department department2 = new Department()
            {
                Id = 2,
                Name = SpecialtyEnum.Maliyye.ToString(),
            };
            Department department3 = new Department()
            {
                Id = 3,
                Name = SpecialtyEnum.İnformasiyaTexnologiyalari.ToString(),
            };
            // Vacancy Objects
            Vacancy vacancy1 = new Vacancy() {
                Id = 1,
                Name = SpecialtyEnum.Marketing.ToString(),
                DepartmentId = 1,
                Interview = false,
                Requirement = "Hansi namizedin ish staji choxdursa ve hemin muddetlerde oz mehsuldarligi ile sechilmishse onlara ustunluk verilecek",
            };
            company.Announcment(vacancy1);
            Vacancy vacancy2 = new Vacancy()
            {
                Id = 2,
                Name = SpecialtyEnum.Maliyye.ToString(),
                DepartmentId = 2,
                Interview = false,
                Requirement = "Hansi namizedin ish staji choxdursa ve hemin muddetlerde oz mehsuldarligi ile sechilmishse onlara ustunluk verilecek",
            };
            company.Announcment(vacancy2);
            Vacancy vacancy3 = new Vacancy()
            {
                Id = 3,
                Name = SpecialtyEnum.İnformasiyaTexnologiyalari.ToString(),
                DepartmentId = 3,
                Interview = false,
                Requirement = "Hansi namizedin ish staji choxdursa ve hemin muddetlerde oz mehsuldarligi ile sechilmishse onlara ustunluk verilecek",
            };
            company.Announcment(vacancy3);
            Candidate candidate1 = new Candidate()
            {
                Id = 1,
                Name = "Aydan",
                Experience = 2,
                Progress = true,
            };


            vacancy1.HireCandidate(candidate1);
            vacancy1.ChangeRequirement(true);
            vacancy1.HireCandidate(candidate1);

            Console.ReadLine();


        }
    }
}

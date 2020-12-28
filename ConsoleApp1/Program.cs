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
                Id = 1,
                Name = SpecialtyEnum.Maliyye.ToString(),
            };
            Department department3 = new Department()
            {
                Id = 1,
                Name = SpecialtyEnum.İnformasiyaTexnologiyalari.ToString(),
            };
            // Vacancy Objects
            Vacancy vacancy1 =new Vacancy() {
                Id = 1,
                Name = SpecialtyEnum.Marketing.ToString(),
            };
            company.Announcment(vacancy1);
            Vacancy project_vacany = new Vacancy()
            {
                id = 1,
                job_name = "Project Developer",
                require_ms_certificate = true,
            };
            company.vacancies.Add(project_vacany);
            company.Declaration(project_vacany);
            Vacancy product_vacany = new Vacancy()
            {
                id = 1,
                job_name = "Product Developer",
                require_ms_certificate = true,
            };
            company.vacancies.Add(product_vacany);
            company.Declaration(product_vacany);
            Candidate candidate1 = new Candidate()
            {
                id = 1,
                name = "Aydan",
                ms_certificate = true,
                location = true,
            };
            bool accepted=soft_vacany.CheckCandidate(candidate1);
            if (accepted)
            {
                candidate1.CheckLocation();
            }
        }
    }
}

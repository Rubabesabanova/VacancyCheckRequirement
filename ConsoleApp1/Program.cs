using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company()
            {
                id=1,
                name="Azerfon",
            };
            Vacancy soft_vacany=new Vacancy() { 
            id=1,
            job_name="Software Developer",
            require_ms_certificate=true,
            };
            company.vacancies.Add(soft_vacany);
            company.Declaration(soft_vacany);
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

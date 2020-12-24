using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Company
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<Vacancy> vacancies = new List<Vacancy>();

        public void Declaration(Vacancy vacany)
        {
            Console.WriteLine($"{vacany.job_name} adli vakansiya elan olundu.");
        }

    }
}

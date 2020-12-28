using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Holding : CommonModel
    {
        public int EmployeeCount { get; set; }
        public void Declaration(Company company)
        {
            Console.WriteLine($"{Name} ishcilerin say hesabini artirmaq uchun oz nezdinde olan {company.Name} vakansiyalar elan olunmasi barede gosterish verilir. ");
        }
    }
}

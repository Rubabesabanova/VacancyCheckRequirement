using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Position : CommonModel
    {
        public bool HrQA(Candidate candidate)
        {
            Console.WriteLine($"{Name} sual-cavab kecirilir");
            if (candidate.Experience > 0 & candidate.Progress)
            {
                Console.WriteLine($"Siz {Name} ile intervyunu kecdiniz");
                return true;
            }
            Console.WriteLine($"Siz {Name} ile intervyunu kecmediniz");
            return false;
        }
        public bool EmployeeQA(Candidate candidate)
        {
            if (HrQA(candidate)){
                Console.WriteLine($"{Name} ile sual-cavab kecirilir");
                Console.WriteLine($"Siz {Name} ile intervyunu kecdiniz");
                return true;
            }
            return false;
            
        }
        public bool HireEmployee(Candidate candidate)
        {
            if (EmployeeQA(candidate))
            {
                Console.WriteLine("Siz ise qebul olundunuz");
                return true;
            }
            Console.WriteLine("Siz ise qebul olunmadiniz. Sizi bir nece ilden sonra gormeye sad olariq");
            return false;

        }
    }
}

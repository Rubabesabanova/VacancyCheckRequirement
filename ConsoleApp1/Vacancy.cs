using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Vacancy : CommonModel
    {
        public int DepartmentId { get; set; }
        public string Requirement { get; set; }

        public bool Interview { get; set; }

        public void ChangeRequirement(bool interview)
        {
            Interview = interview;
            if (interview)
            {
                Console.WriteLine("Intervyu qaydalari deyisdi! Artiq bir intervyu olacaq");
            }
        }

        

        public void HireCandidate(Candidate candidate)
        {
            Position HR = new Position()
            {
                Id = 1,
                Name = "HR",
            };

            Position Employee = new Position()
            {
                Id = 2,
                Name = "Employee",
            };

            Employee.HireEmployee(candidate, this);
        }
            
    }
        
 }

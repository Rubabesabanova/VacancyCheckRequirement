using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Vacancy
    {
        public int id { get; set; }
        public string job_name { get; set; }
        public bool require_ms_certificate { get; set; }
        
        public bool CheckCandidate(Candidate candidate)
        {
            if (candidate.ms_certificate == require_ms_certificate)
            {
                Console.WriteLine("ZOOM meeting ve ya real ofis daxilinde intervyu teshkil etmek mumkundur");
                return true;
            }
            Console.WriteLine("ZOOM meeting ve ya real ofis daxilinde intervyu teshkil etmek mumkun deyil");
            return false;
        }
    }
}

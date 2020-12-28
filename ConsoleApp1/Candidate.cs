using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Candidate : CommonModel
    {
        public string Surname { get; set; }
        public float Experience { get; set; }
        public bool Progress { get; set; }

        #region full name 
        public string FullName => $"{Name} {Surname}";
        #endregion

        public bool CheckCandidate()
        {
            if (Experience > 0 | Progress)
            {
                Console.WriteLine("Sizi intervyuya devet edirik");
                return true;
            }
            Console.WriteLine("Sizi bir nece ilden sonra gormeye sad olariq");
            return false;
        }
    }
}

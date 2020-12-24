using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Candidate
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool ms_certificate;
        public bool location;//Eger shirketin addresi sene rahat deyilse False

        public bool CheckLocation()
        {
            if (location == true)
            {
                Console.WriteLine("Sizinle real ofis daxilinde intervyu teskil edeceyik");
                return true;
            }
            Console.WriteLine("Sizinle ZOOM meeting intervyu teskil edeceyik");
            return false;
        }
    }
}

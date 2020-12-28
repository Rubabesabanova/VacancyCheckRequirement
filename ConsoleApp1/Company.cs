using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Company : CommonModel
    {
        public int HoldingId { get; set; }

        public void Announcment(Vacancy vacany)
        {
            Console.WriteLine($"{vacany.Name} adli vakansiya elan olundu. Vakansiya telebleri : {vacany.Requirement}");
        }
        
    }
}

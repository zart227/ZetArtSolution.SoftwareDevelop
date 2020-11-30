using System;
using System.Collections.Generic;
using System.Text;

namespace ZetArtSolution.SoftwareDevelop.Domain.Persons
{
    public class Employee : Staff
    {
        public Employee(string name, List<TimeRecord> timeRecords) : base(name, 120000, timeRecords)
        {

        }
    }
}

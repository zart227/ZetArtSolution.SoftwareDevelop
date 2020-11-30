using System;
using System.Collections.Generic;
using System.Text;

namespace ZetArtSolution.SoftwareDevelop.Domain
{
    public class Staff : Person
    {
        public decimal MonthSalary { get; }
        public Staff(string name, decimal monthSalary, List<TimeRecord> timeRecords) : base(name, timeRecords)
        {
            MonthSalary = monthSalary;
        }


    }
}

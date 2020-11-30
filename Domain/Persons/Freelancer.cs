using System;
using System.Collections.Generic;
using System.Text;

namespace ZetArtSolution.SoftwareDevelop.Domain
{
    public class Freelancer : Person
    {
        public Freelancer(string name, List<TimeRecord> timeRecords) : base(name, timeRecords)
        {
        }
    }
}

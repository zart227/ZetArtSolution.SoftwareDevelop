using System;
using System.Collections.Generic;

namespace ZetArtSolution.SoftwareDevelop.Domain
{
    public class Person
    {
        public string Name { get; }

        public List<TimeRecord> TimeRecords { get; set; }

        public Person(string name, List<TimeRecord> timeRecords)
        {
            Name = name;
            TimeRecords = timeRecords;
        }
    }
}

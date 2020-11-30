using System;
using System.Collections.Generic;
using System.Text;

namespace ZetArtSolution.SoftwareDevelop.Domain
{
    public class TimeRecord
    {
        public DateTime Date { get; }
        public string Name { get; }
        public byte Hours { get; }
        public string Message { get; }
        public TimeRecord(DateTime date, string name, byte hours, string message)
        {
            Date = date;
            Name = name;
            Hours = hours;
            Message = message;
        }
    }
}

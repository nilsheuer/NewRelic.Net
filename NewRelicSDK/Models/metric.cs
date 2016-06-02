using System;
using System.Collections.Generic;

namespace NewRelicSDK.Models
{
    public class Metric
    {
        public string Name { get; set; }
        public List<Timeslice> Timeslices { get; set; }
    }

    public class Timeslice
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public Dictionary<string, double> Values { get; set; }
    }
}
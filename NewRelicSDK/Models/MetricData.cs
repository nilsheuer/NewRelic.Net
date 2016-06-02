using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRelicSDK.Models
{
    public class MetricData
    {
        public metric_data metric_data { get; set; }
    }

        public class metric_data
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        [JsonProperty("metrics_not_found")]
        public List<string> MetricsNotFound {get;set;}
        [JsonProperty("metrics_found")]
        public List<string> MetricsFound { get; set; }
        [JsonProperty("metrics")]
        public List<Metric> Metrics { get; set; }


    }
}

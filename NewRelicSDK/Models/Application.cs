using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRelicSDK.Models
{
    public class Application
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Language { get; set; }
        [JsonProperty("health_status")]
        public string HealthStatus { get; set; }
        public bool Reporting { get; set; }
        [JsonProperty("last_reported_at")]
        public DateTime LastReportedAt { get; set; }
        [JsonProperty("application_summary")]
        public ApplicationSummary ApplicationSummary { get; set; }
        [JsonProperty("end_user_summary")]
        public EndUserSummary EndUserSummary { get; set; }
        [JsonProperty("settings")]
        public ApplicationSettings Settings { get; set; }
        [JsonProperty("links")]
        public ApplicationLinks Links { get; set; }


    }

    public class ApplicationSummary
    {
        [JsonProperty("response_time")]
        public float ResponseTime { get; set; }
        [JsonProperty("throughput")]
        public float ThroughPut { get; set; }
        [JsonProperty("error_rate")]
        public float ErrorRate { get; set; }
        [JsonProperty("apdex_target")]
        public float ApdexTarget { get; set; }
        [JsonProperty("apdex_score")]
        public float ApdexScore { get; set; }
        [JsonProperty("host_count")]
        public int HostCount { get; set; }
        [JsonProperty("instance_count")]
        public int InstanceCount { get; set; }
        [JsonProperty("concurrent_instance_count")]
        public int ConcurrentInstanceCount { get; set; }


    }


    public class EndUserSummary
    {
        [JsonProperty("response_time")]
        public float ResponseTime { get; set; }
        [JsonProperty("throughput")]
        public float ThroughPut { get; set; }
        [JsonProperty("error_rate")]
        public float ErrorRate { get; set; }
        [JsonProperty("apdex_target")]
        public float ApdexTarget { get; set; }
        [JsonProperty("apdex_score")]
        public float ApdexScore { get; set; }
    }

    public class ApplicationSettings
    {
        [JsonProperty("app_apdex_threshold")]
        public float AppApdexThreshold { get; set; }
        [JsonProperty("end_user_apdex_threshold")]
        public float EndUserApdexThreshold { get; set; }
        [JsonProperty("enable_real_user_monitoring")]
        public bool EnableRealUserMonitoring { get; set; }
        [JsonProperty("use_server_side_config")]
        public bool UserServerSideConfig { get; set; }

    }

    public class ApplicationLinks
    {
        [JsonProperty("servers")]
        public List<int> ServerIds { get; set; }
        [JsonProperty("application_hosts")]
        public List<int> ApplicationHostIds { get; set; }
        [JsonProperty("application_instances")]
        public List<int> ApplicationInstanceIds { get; set; }
        [JsonProperty("alert_policy")]
        public int AlertPolicyId { get; set; }
    }

}

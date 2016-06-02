using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRelicSDK.Models
{
    public class ApplicationUpdate
    {
        public ApplicationUpdate(Application application)
        {
            this.Name = application.Name;
            this.Settings = new ApplicationUpdateSettings();
            this.Settings.AppApdexThreshold = application.Settings.AppApdexThreshold;
            this.Settings.EnableRealUserMonitoring = application.Settings.EnableRealUserMonitoring;
            this.Settings.EndUserApdexThreshold = application.Settings.EndUserApdexThreshold;
        }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("settings")]
        public ApplicationUpdateSettings Settings { get; set; }
    }
    public class ApplicationUpdateSettings
    {
        [JsonProperty("app_apdex_threshold")]
        public float AppApdexThreshold { get; set; }
        [JsonProperty("end_user_apdex_threshold")]
        public float EndUserApdexThreshold { get; set; }
        [JsonProperty("enable_real_user_monitoring")]
        public bool EnableRealUserMonitoring { get; set; }


    }
}

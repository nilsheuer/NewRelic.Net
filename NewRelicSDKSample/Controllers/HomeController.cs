using Microsoft.ServiceBus.Messaging;
using NewRelicSDK;
using NewRelicSDK.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace NewRelicSDKSample.Controllers
{
    public class HomeController : Controller
    {
        public async System.Threading.Tasks.Task<ActionResult> Index()
        {
            /*
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("X-Api-Key", "19d96252176c86a550aeb0587db5cca8a81217404f3366d");
                string response =  await httpClient.GetStringAsync("https://api.newrelic.com/v2/applications/6080786/metrics/data.json?names[]=Agent/MetricsReported/count&summarize=false&raw=true");

            var eventHubClient = EventHubClient.CreateFromConnectionString("Endpoint=sb://nreventhub-ns.servicebus.windows.net/;SharedAccessKeyName=send;SharedAccessKey=a02n8662gTNgzlEuV3678SIpSn9htWLBwMbF31+t5Ko=;EntityPath=nreventhub");

            MetricData myMetricData = JsonConvert.DeserializeObject<MetricData>(response);

            foreach (Metric myMetric in myMetricData.metric_data.Metrics)
            {
                foreach (Timeslice myTimeslice in myMetric.Timeslices)
                {
                    string timesliceJson = JsonConvert.SerializeObject(myTimeslice);
                    eventHubClient.Send(new EventData(Encoding.UTF8.GetBytes(timesliceJson)));
                }
            }
            */
            NewRelicClient myClient = new NewRelicClient("19d96252176c86a550aeb0587db5cca8a81217404f3366d");
            List<Application> myApps = await myClient.ListApplications();

            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
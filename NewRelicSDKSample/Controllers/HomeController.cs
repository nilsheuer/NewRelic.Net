using Microsoft.ServiceBus.Messaging;
using NewRelicSDK;
using NewRelicSDK.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
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

            string newRelicApiKey = ConfigurationManager.AppSettings["NewRelicApiKey"];

             NewRelicClient myClient = new NewRelicClient(newRelicApiKey);
            List<Application> myApps = await myClient.ListApplications();

            Application myApp1 = await myClient.GetApplication(myApps[1]);
            Application appToUpdate = await myClient.GetApplication(myApps.First());
            //Application appToUpdate = myApps.Where(a => a.Id == 6080226).Single();
            appToUpdate.Name = "Origami Portal Staging";
            Application updatedApp = await myClient.UpdateApplication(appToUpdate);
            //Application myApp3 = await myClient.GetApplication(23472434);


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
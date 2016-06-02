using NewRelicSDK.Models;
using NewRelicSDK.Models.Dto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewRelicSDK
{
    public partial class NewRelicClient
    {



        public virtual async Task<List<Application>> ListApplications()
        {

            string queryString = "applications.json";

            string response = await this.MakeRequest(queryString);

            ApplicationListDto applicationsDto = JsonConvert.DeserializeObject<ApplicationListDto>(response);

            List<Application> applications = applicationsDto.applications;

            return applications;


        }
    }
}


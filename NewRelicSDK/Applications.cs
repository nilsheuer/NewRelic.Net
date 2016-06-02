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

        public virtual async Task<Application> GetApplication (int applicationId)
        {
            string queryString = String.Format("applications/{0}.json",applicationId.ToString());
            
                string response = await this.MakeRequest(queryString);
                ApplicationDto applicationDto = JsonConvert.DeserializeObject<ApplicationDto>(response);

                Application application = applicationDto.application;

                return application;
            
        
           
        }
        public virtual async Task<Application> GetApplication(Application application)
        {

            Application myApplication = await GetApplication(application.Id);

            return myApplication;
        }

        public virtual async Task<Application> UpdateApplication (Application application)
        {
            string queryString = String.Format("applications/{0}.json", application.Id.ToString());
            ApplicationUpdateDto applicationUpdateDto = new ApplicationUpdateDto();
            ApplicationUpdate applicationUpdate = new ApplicationUpdate(application);
            applicationUpdateDto.application = applicationUpdate;

            string payload = JsonConvert.SerializeObject(applicationUpdateDto);
            string response = await this.MakeRequest(queryString,"PUT",payload);
            ApplicationDto applicationDto = JsonConvert.DeserializeObject<ApplicationDto>(response);

            Application updatedApplication = applicationDto.application;

            return updatedApplication;
        }
    }
}


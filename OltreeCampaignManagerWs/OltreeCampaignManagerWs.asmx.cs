using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using OltreeCampaignManagerBdd;
using OltreeCampaignManagerBdd.Models;

namespace OltreeCampaignManagerWs
{
    /// <summary>
    /// Summary description for OltreeCampaignManagerWs
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class OltreeCampaignManagerWs : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string TestEF6()
        {
            string result = "";
            using (var context = new OltreeCampaignManagerDbContext())
            {
                Campaign campaign = new Campaign();
                campaign.Description = "Toto";
                campaign.Id = 1;
                campaign.Name = " Toto Test";
                context.Campaigns.Add(campaign);
                context.SaveChanges();
            }
            return result;
        }
    }
}

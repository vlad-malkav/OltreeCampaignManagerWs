using System.Collections.Generic;

namespace OltreeCampaignManagerBdd.Models
{
    public class CampaignSession : BaseElement
    {
        public CampaignSession()
        {
            this.CampaignDayInteractions = new HashSet<CampaignDayInteraction>();
        }

        public System.DateTime Date { get; set; }

        public string Players { get; set; }

        public Campaign Campaign { get; set; }

        public virtual ICollection<CampaignDayInteraction> CampaignDayInteractions { get; set; }
    }
}

using System.Collections.Generic;

namespace OltreeCampaignManagerBdd.Models
{
    public class CampaignDay : BaseElement
    {
        public CampaignDay()
        {
            this.CampaignDayInteractions = new HashSet<CampaignDayInteraction>();
        }

        public long UsableRessourcesCapacity { get; set; }

        public long UsableRessourcesCarried { get; set; }

        public long ImmobilisedRessourcesCarried { get; set; }

        public string GoodsCarried { get; set; }

        public string Weather { get; set; }

        public long Day { get; set; }

        public long Week { get; set; }

        public long Month { get; set; }

        public int Year { get; set; }

        public string RessourcesEvolution { get; set; }

        public virtual ICollection<CampaignDayInteraction> CampaignDayInteractions { get; set; }
    }
}

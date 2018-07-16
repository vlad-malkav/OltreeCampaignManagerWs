namespace OltreeCampaignManagerBdd.Models
{
    public class CampaignDayInteraction : BaseElement
    {
        public long TypeInteraction { get; set; }

        public string Card { get; set; }

        public virtual CampaignDay CampaignDay { get; set; }

        public virtual CampaignSession CampaignSession { get; set; }
    }
}

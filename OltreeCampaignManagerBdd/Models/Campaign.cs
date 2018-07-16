using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OltreeCampaignManagerBdd.Models
{
    public class Campaign
    {
        public Campaign()
        {
            this.CampaignSessions = new HashSet<CampaignSession>();
        }

        public virtual ICollection<CampaignSession> CampaignSessions { get; set; }

        [Key]
        public long Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}

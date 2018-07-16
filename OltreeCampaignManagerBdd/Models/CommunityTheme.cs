using System.Collections.Generic;

namespace OltreeCampaignManagerBdd.Models
{
    public class CommunityTheme : BaseElement
    {
        public CommunityTheme()
        {
            this.Factions = new HashSet<Faction>();
        }

        public string Name { get; set; }

        public string Base { get; set; }

        public virtual Community Community { get; set; }

        public virtual ICollection<Faction> Factions { get; set; }
    }
}

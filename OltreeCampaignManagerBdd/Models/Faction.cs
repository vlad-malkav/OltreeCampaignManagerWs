using System.Collections.Generic;

namespace OltreeCampaignManagerBdd.Models
{
    public class Faction : BaseElement
    {
        public Faction()
        {
            this.CommunityThemes = new HashSet<CommunityTheme>();
        }

        public string Base { get; set; }

        public int Objectif { get; set; }

        public int Dynamique { get; set; }

        public string Chronique { get; set; }

        public int Motivation { get; set; }

        public virtual ICollection<CommunityTheme> CommunityThemes { get; set; }
    }
}

using System.Collections.Generic;

namespace OltreeCampaignManagerBdd.Models
{
    public class Community : Place
    {
        public Community()
        {
            this.CommunityThemes = new HashSet<CommunityTheme>();
        }

        public long RelationPatrolLevel { get; set; }

        public int Size { get; set; }

        public int PeopleMainType { get; set; }

        public string PlaceType { get; set; }

        public string AdditionalTypeData { get; set; }

        public virtual ICollection<CommunityTheme> CommunityThemes { get; set; }
    }
}

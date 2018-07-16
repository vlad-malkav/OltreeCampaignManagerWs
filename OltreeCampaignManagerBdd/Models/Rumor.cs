using System.Collections.Generic;

namespace OltreeCampaignManagerBdd.Models
{
    public class Rumor : BaseElement
    {
        public Rumor()
        {
            this.Hexagons = new HashSet<Hexagon>();
        }

        public long Veracity { get; set; }

        public virtual ICollection<Hexagon> Hexagons { get; set; }
    }
}

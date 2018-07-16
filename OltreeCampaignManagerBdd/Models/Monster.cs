using System.Collections.Generic;

namespace OltreeCampaignManagerBdd.Models
{
    public class Monster : BaseElement
    {
        public Monster()
        {
            this.Hexagons = new HashSet<Hexagon>();
        }

        public string Name { get; set; }

        public virtual ICollection<Hexagon> Hexagons { get; set; }
    }
}

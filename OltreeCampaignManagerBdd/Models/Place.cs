using System.Collections.Generic;

namespace OltreeCampaignManagerBdd.Models
{
    public class Place : BaseElement
    {
        public Place()
        {
            this.Hexagons = new HashSet<Hexagon>();
            this.Npcs = new HashSet<Npc>();
            this.Rumors = new HashSet<Rumor>();
            this.Monsters = new HashSet<Monster>();
            this.Places = new HashSet<Place>();
        }

        public int TypePlace { get; set; }

        public virtual ICollection<Hexagon> Hexagons { get; set; }

        public virtual ICollection<Npc> Npcs { get; set; }

        public virtual ICollection<Rumor> Rumors { get; set; }

        public virtual ICollection<Monster> Monsters { get; set; }

        public virtual ICollection<Place> Places { get; set; }
    }
}

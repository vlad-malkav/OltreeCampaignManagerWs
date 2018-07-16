namespace OltreeCampaignManagerBdd.Models
{
    using System.Collections.Generic;

    public class Hexagon : BaseElement
    {
        public Hexagon()
        {
            this.Npcs = new HashSet<Npc>();
            this.Rumors = new HashSet<Rumor>();
            this.Monsters = new HashSet<Monster>();
            this.Places = new HashSet<Place>();
        }

        public long Column { get; set; }

        public long Row { get; set; }

        public long ExplorationLevel { get; set; }

        public long IdLandType { get; set; }

        public virtual ICollection<Npc> Npcs { get; set; }

        public virtual ICollection<Rumor> Rumors { get; set; }

        public virtual ICollection<Monster> Monsters { get; set; }

        public virtual ICollection<Place> Places { get; set; }
    }
}

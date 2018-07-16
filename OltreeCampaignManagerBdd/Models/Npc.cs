using System.Collections.Generic;

namespace OltreeCampaignManagerBdd.Models
{
    public class Npc : BaseElement
    {
        public Npc()
        {
            this.Places = new HashSet<Place>();
        }

        public string Name { get; set; }

        public virtual ICollection<Place> Places { get; set; }
    }
}


using OltreeCampaignManagerBdd.Models;

namespace OltreeCampaignManagerBdd
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class OltreeCampaignManagerDbContext : DbContext
    {
        public OltreeCampaignManagerDbContext()
            : base("alwaysdata")
        {
            Database.SetInitializer<OltreeCampaignManagerDbContext>(new System.Data.Entity.DropCreateDatabaseAlways<OltreeCampaignManagerDbContext>());
            Database.Initialize(true);
        }

        public virtual DbSet<BaseElement> BaseElements { get; set; }
        public virtual DbSet<Campaign> Campaigns { get; set; }
        public virtual DbSet<CampaignDay> CampaignDays { get; set; }
        public virtual DbSet<CampaignDayInteraction> CampaignDayInteractions { get; set; }
        public virtual DbSet<CampaignSession> CampaignSessions { get; set; }
        public virtual DbSet<Community> Communities { get; set; }
        public virtual DbSet<CommunityTheme> CommunityThemes { get; set; }
        public virtual DbSet<Faction> Factions { get; set; }
        public virtual DbSet<Hexagon> Hexagons { get; set; }
        public virtual DbSet<Monster> Monsters { get; set; }
        public virtual DbSet<Npc> Npcs { get; set; }
        public virtual DbSet<Place> Places { get; set; }
        public virtual DbSet<Rumor> Rumors { get; set; }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OltreeCampaignManagerBdd
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class allanlerouge_oltree_campaign_manager_Entities : DbContext
    {
        public allanlerouge_oltree_campaign_manager_Entities()
            : base("name=allanlerouge_oltree_campaign_manager_Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BaseElement> T_BASE_ELEMENT { get; set; }
        public virtual DbSet<Campaign> T_CAMPAIGN { get; set; }
        public virtual DbSet<T_CAMPAIGN_DAY> T_CAMPAIGN_DAY { get; set; }
        public virtual DbSet<T_CAMPAIGN_DAY_INTERACTION> T_CAMPAIGN_DAY_INTERACTION { get; set; }
        public virtual DbSet<T_CAMPAIGN_SESSION> T_CAMPAIGN_SESSION { get; set; }
        public virtual DbSet<T_COMMUNITY> T_COMMUNITY { get; set; }
        public virtual DbSet<T_COMMUNITY_THEME> T_COMMUNITY_THEME { get; set; }
        public virtual DbSet<T_FACTION> T_FACTION { get; set; }
        public virtual DbSet<T_HEXAGON> T_HEXAGON { get; set; }
        public virtual DbSet<T_MONSTER> T_MONSTER { get; set; }
        public virtual DbSet<T_NPC> T_NPC { get; set; }
        public virtual DbSet<T_PLACE> T_PLACE { get; set; }
        public virtual DbSet<T_RUMOR> T_RUMOR { get; set; }
    }
}

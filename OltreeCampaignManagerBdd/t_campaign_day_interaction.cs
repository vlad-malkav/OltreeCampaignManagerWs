//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OltreeCampaignManagerBdd
{
    using System;
    using System.Collections.Generic;

    [Table("T_CAMPAIGN_DAY_INTERACTION")]
    public partial class T_CAMPAIGN_DAY_INTERACTION : BaseElement
    {
        [Column("TYPE")]
        public long type { get; set; }

        [Column("CARD")]
        public string card { get; set; }

        [Column("ID_CAMPAIGN_DAY")]
        public virtual T_CAMPAIGN_DAY T_CAMPAIGN_DAY { get; set; }

        [Column("ID_CAMPAIGN_SESSION")]
        public virtual T_CAMPAIGN_SESSION T_CAMPAIGN_SESSION { get; set; }
    }
}

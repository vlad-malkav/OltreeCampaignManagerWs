//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations.Schema;

namespace OltreeCampaignManagerBdd
{
    using System;
    using System.Collections.Generic;

    [Table("T_RUMOR")]
    public partial class T_RUMOR : BaseElement
    {
        [Column("VERACITY")]
        public long veracity { get; set; }

        [Column("ID_HEXAGON")]
        public virtual T_HEXAGON T_HEXAGON { get; set; }
    }
}

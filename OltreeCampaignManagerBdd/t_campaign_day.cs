//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class t_campaign_day
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public t_campaign_day()
        {
            this.t_campaign_day_interaction = new HashSet<t_campaign_day_interaction>();
        }
    
        public long id { get; set; }
        public long usable_ressources_capacity { get; set; }
        public long usable_ressources_carried { get; set; }
        public long immobilised_ressources_carried { get; set; }
        public string goods_carried { get; set; }
        public string weather { get; set; }
        public long day { get; set; }
        public long week { get; set; }
        public long month { get; set; }
        public int year { get; set; }
        public string ressources_evolution { get; set; }
    
        public virtual t_base_element t_base_element { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_campaign_day_interaction> t_campaign_day_interaction { get; set; }
    }
}

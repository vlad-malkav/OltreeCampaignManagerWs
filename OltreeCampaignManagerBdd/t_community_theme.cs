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
    
    public partial class t_community_theme
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public t_community_theme()
        {
            this.t_faction = new HashSet<t_faction>();
        }
    
        public long id { get; set; }
        public long id_community { get; set; }
        public string name { get; set; }
        public string @base { get; set; }
    
        public virtual t_base_element t_base_element { get; set; }
        public virtual t_community t_community { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_faction> t_faction { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace OltreeCampaignManagerBdd.Models
{
    public class BaseElement
    {
        [Key]
        public long Id { get; set; }

        public long IdCampaign { get; set; }

        public string Description { get; set; }

        public string Notes { get; set; }

        public string DescriptionMd { get; set; }

        public string NotesMd { get; set; }

        public int Type { get; set; }
    }
}
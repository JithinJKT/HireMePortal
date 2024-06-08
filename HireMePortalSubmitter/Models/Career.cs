using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace HireMePortalSubmitter.Models
{
    public class Career
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(10)]
        [DisplayName("Career Name")]
        public string Name { get; set; }
        [DisplayName("Job Code")]
        public string JobCode { get; set; }
        [DisplayName("Location")]
        public string Location { get; set; }
        [DisplayName("Career Details")]
        public string JobDetails { get; set; }
        [DisplayName("Experience in Years")]
        public string ExperienceRange { get; set; }
    }

    
}

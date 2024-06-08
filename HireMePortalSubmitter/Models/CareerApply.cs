using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace HireMePortalSubmitter.Models
{
    public class CareerApply
    {
        [Key]
        public int CareerApplyId { get; set; }
        [Required]        
        [DisplayName("Full Name")]
        public string FullName { get; set; }
        [Required]
        [DisplayName("Year of Experinace")]
        public string YearofExperinace { get; set; }
        [Required]
        [DisplayName("Phone")]
        public string Phone { get; set; }
        [Required]
        [DisplayName("Email")]
        public string Email { get; set; }
    }
}

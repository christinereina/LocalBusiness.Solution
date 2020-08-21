using System.ComponentModel.DataAnnotations;

namespace LocalBusiness.Models
{
    public class Business
    {
        public int BusinessId { get; set; }

        [Required]
        [StringLength(40)]
        public string Name { get; set; }
        public string Rating { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Hours { get; set; }
        [Required]
        public string ServicesOffered { get; set; }
         
    }
}
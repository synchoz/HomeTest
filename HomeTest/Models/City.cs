using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeTest.Models
{
    public class City
    {
        public int Id { get; set; }

        [Column("שם ישוב")]
        [Display(Name = "שם ישוב")]
        [StringLength(100, ErrorMessage = "מספר תווים ל{0} צריך להיות בין {2} ו {1} באורך.", MinimumLength = 1)]
        public required string Name { get; set; }
        
    }
}

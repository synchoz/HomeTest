using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeTest.Models
{
    public class City
    {
        public int Id { get; set; }

        [Column("שם ישוב")]
        [Display(Name = "שם ישוב")]
        public required string Name { get; set; }
        
    }
}

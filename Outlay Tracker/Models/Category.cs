using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Outlay_Tracker.Models
{
    public class Category
    {
        // Specifies that this property is the primary key for the entity
        [Key]
        public int CategoryId { get; set; }

        // Specifies the database column type for the property
        [Column(TypeName = "nvarchar(50)")]
        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        [Column(TypeName = "nvarchar(5)")]
        public string Icon { get; set; } = "";

        [Column(TypeName = "nvarchar(10)")]
        public string Type { get; set; } = "Expense";

        // Specifies that this property is not mapped to the database
        [NotMapped]
        public string? TitleWithIcon
        {
            get
            {
                // Concatenates the Icon and Title properties to form a string
                return this.Icon + " " + this.Title;
            }
        }
    }
}

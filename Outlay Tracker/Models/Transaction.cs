using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Outlay_Tracker.Models
{
    public class Transaction
    {
        // Specifies that this property is the primary key for the entity
        [Key]
        public int TransactionId { get; set; }

        // Specifies that the value of CategoryId should be within the specified range
        [Range(1,int.MaxValue,ErrorMessage ="Please select a category.")]

        // Navigation property to relate to the Category entity (nullable)
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        // Specifies that the value of Amount should be within the specified range
        [Range(1, int.MaxValue, ErrorMessage = "Amount should be greater than 0.")]
        public int Amount { get; set; }

        // Specifies the database column type for the property
        [Column(TypeName = "nvarchar(75)")]
        public string? Note { get; set; }

        // Sets the default value of Date property to the current date and time
        public DateTime Date { get; set; } = DateTime.Now;

        // Specifies that this property is not mapped to the database
        [NotMapped]
        public string? CategoryTitleWithIcon
        {
            get
            {
                // Concatenates the Category's Icon and Title if Category is not null; otherwise, returns an empty string
                return Category == null ? "" : Category.Icon + " " + Category.Title;
            }
        }

        // Specifies that this property is not mapped to the database
        [NotMapped]
        public string? FormattedAmount
        {
            get
            {
                // Returns a formatted string representation of the Amount property, with a prefix of '-' for expenses and '+' for other categories
                return ((Category == null || Category.Type == "Expense") ? "- " : "+ ") + Amount.ToString("C0");
            }
        }

    }
}

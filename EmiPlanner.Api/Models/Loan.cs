using System.ComponentModel.DataAnnotations;

namespace EmiPlanner.Api.Models
{
    public class Loan
    {
        public int Id { get; set; }

        [Required]
        public decimal Principal { get; set; }

        [Required]
        public double Rate { get; set; }   // Annual interest rate

        [Required]
        public int Tenure { get; set; }    // Months

        [Required]
        public decimal Income { get; set; }

        public decimal Emi { get; set; }
    }
}
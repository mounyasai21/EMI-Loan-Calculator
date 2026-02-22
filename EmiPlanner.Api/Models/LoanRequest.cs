namespace EmiPlanner.Api.Models
{
    public class LoanRequest
    {
        public double Principal { get; set; }
        public double Rate { get; set; }
        public int Tenure { get; set; }
        public double Income { get; set; }
        public double Emi { get; set; }
    }
}
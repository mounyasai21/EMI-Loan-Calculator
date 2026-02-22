using Microsoft.AspNetCore.Mvc;
using EmiPlanner.Api.Models;

namespace EmiPlanner.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoanController : ControllerBase
    {
        // Temporary in-memory storage
        private static List<LoanRequest> _loans = new();

        [HttpGet]
        public IActionResult GetLoans()
        {
            return Ok(_loans);
        }

        [HttpPost]
        public IActionResult CalculateEmi([FromBody] LoanRequest request)
        {
            double monthlyRate = request.Rate / 12 / 100;
            int months = request.Tenure;

            double emi = (request.Principal * monthlyRate * Math.Pow(1 + monthlyRate, months)) /
                         (Math.Pow(1 + monthlyRate, months) - 1);

            request.Emi = Math.Round(emi, 2);

            _loans.Add(request);

            return Ok(new { emi = request.Emi });
        }
    }
}
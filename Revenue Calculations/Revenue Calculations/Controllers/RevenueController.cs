using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using Revenue_Calculations.IServices;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Revenue_Calculations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RevenueController : ControllerBase
    {
        private readonly IRevenueService _revenueService;

        public RevenueController(IRevenueService revenueService)
        {
            _revenueService = revenueService;
        }
        // Endpoint to trigger revenue calculation
        [HttpGet("GetRevenue")]
        public IActionResult GetRevenue(DateTime startDate, DateTime endDate)
        {
          var result= _revenueService.CalculateTotalRevenue(startDate, endDate);

          return Ok(result);
        }
        // Endpoint to trigger revenue calculation
        [HttpGet("GetRevenueByProduct")]
        public IActionResult GetRevenueByProduct(DateTime startDate, DateTime endDate,string productId)
        {
            var result = _revenueService.CalculateRevenueByProduct(startDate, endDate, productId);

            return Ok(result);
        }
        // Endpoint to trigger revenue calculation
        [HttpGet("GetRevenueByCustomerId")]
        public IActionResult GetRevenueByCustomerId(DateTime startDate, DateTime endDate,string customerId)
        {
            var result = _revenueService.CalculateRevenueByCustomerId(startDate, endDate, customerId);

            return Ok(result);
        }
        // Endpoint to trigger revenue calculation
        [HttpGet("GetRevenueByOrderId")]
        public IActionResult GetRevenueByOrderId(DateTime startDate, DateTime endDate,int orderId)
        {
            var result = _revenueService.CalculateRevenueByOrderId(startDate, endDate, orderId);

            return Ok(result);
        }

    }
}

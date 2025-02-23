using Revenue_Calculations.IServices;
using Revenue_Calculations.IRepository;
namespace Revenue_Calculations.Services
{
    public class RevenueService : IRevenueService
    {
        private readonly IRevenueRepository _revenueRepository;

        public RevenueService(IRevenueRepository revenueRepository)
        {
            _revenueRepository = revenueRepository;
        }
        public decimal CalculateTotalRevenue(DateTime startDate, DateTime endDate)
        {
            return _revenueRepository.CalculateTotalRevenue(startDate, endDate);
        }
        public Dictionary<string, decimal> CalculateRevenueByProduct(DateTime startDate, DateTime endDate, string productId)
        {
            return _revenueRepository.CalculateRevenueByProduct(startDate, endDate, productId);
        }
        public Dictionary<string, decimal> CalculateRevenueByCustomerId(DateTime startDate, DateTime endDate, string customerId)
        {
            return _revenueRepository.CalculateRevenueByCustomerId(startDate, endDate, customerId);
        }
        public Dictionary<int, decimal> CalculateRevenueByOrderId(DateTime startDate, DateTime endDate, int orderId)
        {
            return _revenueRepository.CalculateRevenueByOrderId(startDate, endDate, orderId);
        }
    }
}

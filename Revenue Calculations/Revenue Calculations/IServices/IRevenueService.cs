namespace Revenue_Calculations.IServices
{
    public interface IRevenueService
    {
        public decimal CalculateTotalRevenue(DateTime startDate, DateTime endDate);
        public Dictionary<string, decimal> CalculateRevenueByProduct(DateTime startDate, DateTime endDate, string productId);
        public Dictionary<string, decimal> CalculateRevenueByCustomerId(DateTime startDate, DateTime endDate, string categoryId);
        public Dictionary<int, decimal> CalculateRevenueByOrderId(DateTime startDate, DateTime endDate, int ordrId);
    }
}

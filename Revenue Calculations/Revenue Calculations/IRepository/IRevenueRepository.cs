namespace Revenue_Calculations.IRepository
{
    public interface IRevenueRepository
    {
        public decimal CalculateTotalRevenue(DateTime startDate, DateTime endDate);
        public Dictionary<string, decimal> CalculateRevenueByProduct(DateTime startDate, DateTime endDate,string productId);
        public Dictionary<string, decimal> CalculateRevenueByCustomerId(DateTime startDate, DateTime endDate, string customerId);
        public Dictionary<int, decimal> CalculateRevenueByOrderId(DateTime startDate, DateTime endDate, int region);
    }
}

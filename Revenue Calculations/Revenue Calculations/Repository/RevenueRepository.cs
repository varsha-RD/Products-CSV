using Revenue_Calculations.IRepository;
using Revenue_Calculations.Model;

namespace Revenue_Calculations.Repository
{
    public class RevenueRepository: IRevenueRepository
    {
        private readonly RevenueDbContext _context;

        public RevenueRepository(RevenueDbContext context)
        {
            _context = context;
        }

        // Calculate total revenue within a date range
        public decimal CalculateTotalRevenue(DateTime startDate, DateTime endDate)
        {
            decimal totalRevenue=0;
            try
            {
                 totalRevenue = _context.Orders
                .Where(o => o.DateOfSale >= startDate && o.DateOfSale <= endDate)
                .Sum(o => (o.QuantitySold * o.UnitPrice) - o.Discount + o.ShippingCost);
            }
            catch (Exception ex)
            {
                // Log exception
                Console.WriteLine($"Error calculating revenue: {ex.Message}");
            }
            return totalRevenue;


        }
        // Calculate total revenue by product within a date range
        public Dictionary<string, decimal> CalculateRevenueByProduct(DateTime startDate, DateTime endDate,string productId)
        {
            Dictionary<string, decimal> revenueByProduct=new Dictionary<string, decimal>(); 
            try
            {
                 revenueByProduct = _context.Orders
                .Where(o => o.DateOfSale >= startDate && o.DateOfSale <= endDate && o.ProductID == productId)
                .GroupBy(o => o.ProductID)
                .Select(g => new
                {
                    ProductID = g.Key,
                    Revenue = g.Sum(o => (o.QuantitySold * o.UnitPrice) - o.Discount + o.ShippingCost)
                })
                .ToDictionary(x => x.ProductID, x => x.Revenue);
            }
            catch (Exception ex)
            {
                // Log exception
                Console.WriteLine($"Error calculating revenue by product ID: {ex.Message}");
            }
            return revenueByProduct;
        }
        // Calculate total revenue by category within a date range
        public Dictionary<string, decimal> CalculateRevenueByCustomerId(DateTime startDate, DateTime endDate,string cutstomerId)
        {
            Dictionary<string, decimal> revenueByCategory = new Dictionary<string, decimal>();
            try
            {
                 revenueByCategory = _context.Orders
                .Where(o => o.DateOfSale >= startDate && o.DateOfSale <= endDate && o.CustomerID == cutstomerId)
                .GroupBy(op => op.CustomerID)
                .Select(g => new
                {
                    Category = g.Key,
                    Revenue = g.Sum(op => (op.QuantitySold * op.UnitPrice) - op.Discount + op.ShippingCost)
                })
                .ToDictionary(x => x.Category, x => x.Revenue);
            }
            catch (Exception ex)
            {
                // Log exception
                Console.WriteLine($"Error calculating revenue by customer ID: {ex.Message}");
            }
            return revenueByCategory;
        }

        // Calculate total revenue by region within a date range
        public Dictionary<int, decimal> CalculateRevenueByOrderId(DateTime startDate, DateTime endDate,int orderId)
        {
            Dictionary<int, decimal> revenueByRegion= new Dictionary<int, decimal>();
            try
            {
                 revenueByRegion = _context.Orders
                .Where(o => o.DateOfSale >= startDate && o.DateOfSale <= endDate && o.OrderID == orderId)
                .GroupBy(op => op.OrderID)
                .Select(g => new
                {
                    Region = g.Key,
                    Revenue = g.Sum(op => (op.QuantitySold * op.UnitPrice) - op.Discount + op.ShippingCost)
                })
                .ToDictionary(x => x.Region, x => x.Revenue);
            }
            catch (Exception ex)
            {
                // Log exception
                Console.WriteLine($"Error calculating revenue by order ID: {ex.Message}");
            }
            return revenueByRegion;
        }
    }
}

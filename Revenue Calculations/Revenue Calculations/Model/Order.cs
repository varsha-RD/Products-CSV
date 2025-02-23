namespace Revenue_Calculations.Model
{
    public class Order
    {
        public int OrderID { get; set; }
        public string ProductID { get; set; }
        public string CustomerID { get; set; }
        public DateTime DateOfSale { get; set; }
        public int QuantitySold { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal ShippingCost { get; set; }
    }
}

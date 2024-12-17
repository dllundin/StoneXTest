namespace StoneXTest.Data
{
    public class OrderDTO
    {
        public int OrderId { get; set; } = 0;
        public double Price { get; set; }
        public int Qty { get; set; }
        public string OrderDate { get; set; }
        public string Side { get; set; }
        public int? NumOfOrders { get; set; }
    }

    public class OrderVM: OrderDTO
    {
        
        
    }
}

namespace MiniShopProject_EFCore_FCM.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public decimal Amount { get; set; }
        public int CustomerId { get; set; }
    }
}

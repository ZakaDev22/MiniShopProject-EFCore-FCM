namespace MiniShopProject_EFCore_FCM.Entities
{
    public class Order
    {

        public Order(int v1, decimal v2, int v3)
        {
            this.OrderId = v1;
            this.Amount = v2;
            this.CustomerId = v3;
        }

        public int OrderId { get; set; }
        public decimal Amount { get; set; }
        public int CustomerId { get; set; }
    }
}

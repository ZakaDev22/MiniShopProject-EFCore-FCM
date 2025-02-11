namespace MiniShopProject_EFCore_FCM.Entities
{
    public class Customer
    {

        public Customer(int v1, string v2)
        {
            this.Id = v1;
            this.Name = v2;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}

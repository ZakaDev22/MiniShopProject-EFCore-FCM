namespace MiniShopProject_EFCore_FCM.Entities
{
    public class Customer
    {

        public Customer() { }
        public Customer(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}

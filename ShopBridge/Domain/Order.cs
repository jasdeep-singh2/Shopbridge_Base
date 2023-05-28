namespace Domain
{
    public class Order
    {
        public Guid Id { get; set; }
        public User User { get; set; }     
        public ICollection<Product> Products { get; set; }
        public DateTime Date { get; set; }
    }
}

public class Order
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public List<int> WatchIds { get; set; }
    public decimal TotalPrice { get; set; }
}

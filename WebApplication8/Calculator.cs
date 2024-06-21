namespace WebApplication8
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    public interface INotificationService
    {
        void Notify(string message);
    }

    public class OrderService
    {
        private readonly INotificationService _notificationService;

        public OrderService(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public void PlaceOrder(string product)
        {
            // Some order processing logic
            _notificationService.Notify($"Order placed for product: {product}");
        }
    }
}

using Moq;
using WebApplication8;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Add_ReturnsCorrectSum()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            int result = calculator.Add(2, 3);

            // Assert
            Assert.Equal(5, result);
        }

        [Fact]
        public void PlaceOrder_CallsNotify()
        {
            // Arrange
            var mockNotificationService = new Mock<INotificationService>();
            var orderService = new OrderService(mockNotificationService.Object);
            var product = "Test Product";

            // Act
            orderService.PlaceOrder(product);

            // Assert
            mockNotificationService.Verify(n => n.Notify($"Order placed for product: {product}"), Times.Once);

        }
    }
}
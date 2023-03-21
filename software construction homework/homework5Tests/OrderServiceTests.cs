using Microsoft.VisualStudio.TestTools.UnitTesting;
using homework5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        [TestMethod()]
        public void OrderServiceTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AddOrderTest()
        {
            // Arrange
            OrderService orderService = new OrderService();
            Order order = new Order("001", "Customer1");

            // Act
            orderService.AddOrder(order);

            // Assert
            Assert.AreEqual(1, orderService.Orders.Count);
            Assert.AreEqual(order, orderService.Orders[0]);
        }

        [TestMethod()]
        public void RemoveOrderTest()
        {   
            OrderService orderService = new OrderService();
            Order order1 = new Order("001", "Customer1");
            Order order2 = new Order("002", "Customer2");
            Order order3 = new Order("003", "Customer3");
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            orderService.AddOrder(order3);
            orderService.RemoveOrder("002");
            Assert.AreEqual(2, orderService.Orders.Count);   
            Assert.Fail();
        }

        [TestMethod()]
        public void ModifyOrderTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SortTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SortTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ShowOrdersTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void QueryOrdersByProductNameTest()
        {
            // Arrange
            OrderService service = new OrderService();
            Order order1 = new Order("001", "Alice");
            order1.OrderDetails.Add(new OrderDetail("apple", 5.0, 10));
            order1.OrderDetails.Add(new OrderDetail("banana", 3.0, 5));
            service.AddOrder(order1);

            Order order2 = new Order("002", "Bob");
            order2.OrderDetails.Add(new OrderDetail("banana", 3.0, 5));
            order2.OrderDetails.Add(new OrderDetail("orange", 4.0, 8));
            service.AddOrder(order2);

            // Act
            List<Order> result = service.QueryOrdersByProductName("banana");

            // Assert
            // the order with id "002" should come before the order with id "001" because it has a higher total money.
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual("002", result[0].OrderId);
            Assert.AreEqual("001", result[1].OrderId);
        }

        [TestMethod()]
        public void QueryOrdersByTotalAmountTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void QueryOrdersByCustomerNameTest()
        {
            Assert.Fail();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    //添加订单、删除订单、修改订单、查询订单（按照订单号、商品名称、客户、订单金额等进行查询）功能。
    //并对各个Public方法添加测试用例
    public class Order
    {
        public string OrderId { get; set; }
        public string Client { get; set; }
        //public string ProductName { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        //一般构造函数需要两个-1个无参1个含参
        public Order(string orderId, string cilent)
        {
            OrderId = orderId;
            //ProductName = productName;
            Client = cilent;
            OrderDetails = new List<OrderDetail>();
        }
        //如果是冗余字段需要随时根据变化更新数据-即保证一致性-冗余字段是为了减少计算量
        public double TotalMoney {
            get => OrderDetails.Sum(d => d.ProductPrice * d.ProductQuantity);
        }
        //（3）作业的订单和订单明细类需要重写Equals方法，确保添加的订单不重复，每个订单的订单明细不重复。
        public override bool Equals(object obj)
        {
            if (obj is Order order)
            {
                return OrderId == order.OrderId && Client == order.Client && OrderDetails.SequenceEqual(order.OrderDetails);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        
        //（4）订单、订单明细、客户、货物等类添加ToString方法，用来显示订单信息。
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"orderId: {OrderId}, client: {Client}, totalMoney : {TotalMoney}");
            OrderDetails.ForEach(d => sb.Append("\n\t" + d.ToString()));
            return sb.ToString();
        }

    }

    public class OrderDetail
    {
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int ProductQuantity { get; set; }

        public OrderDetail(string productName, double productPrice, int productQuantity)
        {
            ProductName = productName;
            ProductPrice = productPrice;
            ProductQuantity = productQuantity;
        }

        public override string ToString()
        {
            return $"productName : {ProductName}, productPrice : {ProductPrice}, productQuantity : {ProductQuantity}";
        }

        public override bool Equals(object obj)
        {
            if (obj is OrderDetail detail)
            {
                return ProductName == detail.ProductName && ProductPrice == detail.ProductPrice && ProductQuantity == detail.ProductQuantity;
            }
            return false ;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ProductName, ProductPrice, ProductQuantity);
        }
    }
    
    public class OrderService
    {
        public OrderService() { }
        //public List<Order> Orders { get; set; }
        /// <summary>
        /// 集合最好做初始化不要直接为null
        /// </summary>
        /// 应当设计为private类型
        public List<Order> Orders = new List<Order>();  // 就是因为这里你没有声明所以有错误 CS0117 “Order”未包含“ForEach”的定义 这样的报错       
        // 不要在order里面写add方法，这属于是业务逻辑而order只是一个数据结构
        // addDetail 太细了？ 数据库里修改一般是创建一个新的对象再把原来的覆盖掉
        public void AddOrder(Order order)  
        {
            if (order.OrderId == null) return;
            //先排序？还是先比较再插入，插入之后再排序?
            bool tag = false;
            //还可以使用findindex 然后对index判断是不是有
            Orders.ForEach(o => {
                if (o.OrderId == order.OrderId) tag = true;
                }
            );
            if (!tag)
            {
                Orders.Add(order);
            }
            else
            {   
                //最好定义自己的异常like orderException
                throw new ArgumentException($"Order with id {order.OrderId} already exiest.");
            }
        }
        //移除同名
        //（2）在订单删除、修改失败时，能够产生异常并显示给客户错误信息。
        public void RemoveOrder(string orderId)
        {
            if (!Orders.Any(o => o.OrderId == orderId))
            {
                throw new ArgumentException($"Order with id {orderId} not found.");
            }
            Orders.RemoveAll(o => o.OrderId == orderId);
        }
        //替换
        public void ModifyOrder(Order newOrder)
        {
            RemoveOrder(newOrder.OrderId);
            Orders.Add(newOrder);
        }
        /*（5）OrderService提供排序方法对保存的订单进行排序。默认按照订单号排序，也可以使用Lambda表达式进行自定义排序。*/
        public void Sort(Func<Order, Order, int> func)
        {
            Orders.Sort((o1, o2) => func(o1, o2));
        }
        public void Sort() { Orders.Sort((o1, o2) => o1.OrderId.CompareTo(o2.OrderId)); }
        public void ShowOrders()
        {
            Orders.ForEach(o => Console.WriteLine(o.ToString()));
        }
        //（1）使用LINQ语言实现各种查询功能，查询结果按照订单总金额排序返回。
        public List<Order> QueryOrdersByProductName(string productName)
        {
            var query = Orders.Where(o => o.OrderDetails.Any(d => d.ProductName == productName));
            //i不用这样排序，直接用orderBy(0 => o.totalmoney)就可以了
            List<Order> ans = query.ToList();
            ans.Sort((o1, o2) => o1.TotalMoney.CompareTo(o2.TotalMoney));
            return ans;
        }
        public List<Order> QueryOrdersByTotalAmount(double totalMoney)
        {
            var query = Orders.Where(o => o.TotalMoney >= totalMoney);
            List<Order> ans = query.ToList();
            ans.Sort((o1, o2) => o1.TotalMoney.CompareTo(o2.TotalMoney));
            return ans;
        }
        public List<Order> QueryOrdersByCustomerName(string client)
        {
            var query = Orders.Where(o => o.Client == client);
            List<Order> ans = query.ToList();
            ans.Sort((o1, o2) => o1.TotalMoney.CompareTo(o2.TotalMoney));
            return ans;
        }

    }

    public class Program
    {
        static void Main(string[] args)
        {
            OrderService orderService = new OrderService();
            Order order1 = new Order("001", "Customer1");
            Order order2 = new Order("002", "Customer2");
            Order order3 = new Order("003", "Customer3");
            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            orderService.AddOrder(order3);
        }
    }
}

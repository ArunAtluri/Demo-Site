using MyShop.Core.Infrastructure.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyShop.Core.Models;
using MyShop.Core.ViewModels;

namespace MyShop.Services
{
    public class OrderService : IOrderService
    {
        IRepository<Order> orderContext;

        public OrderService(IRepository<Order> OrderContext)
        {
            this.orderContext = OrderContext;
        }


        public void CreateOrder(Order baseOrder, List<BasketItemViewModel> basketItems)
        {
            foreach(var item in basketItems)
            {
                baseOrder.OrderItems.Add(new OrderItem() {
                    ProductId = item.Id,
                    ProductName = item.ProductName,
                    Image = item.Image,
                    Quantity = item.Quantity,
                    Price = item.Price
                });
            }

            orderContext.Insert(baseOrder);
            orderContext.Commit();
        }
    }
}

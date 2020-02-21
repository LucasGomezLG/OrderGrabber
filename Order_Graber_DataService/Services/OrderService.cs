using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_Graber_DataService.Services
{
    public class OrderService
    {
        public List<ORDERS> GetAllOrders()
        {
            using (OrderGraberDBEntities dbContext = new OrderGraberDBEntities())
            {
                return dbContext.ORDERS.ToList();
            }
        }

        public ORDERS GetOrderById(int id)
        {
            var order = new ORDERS();

            using (OrderGraberDBEntities dbContext = new OrderGraberDBEntities())
            {
                order = dbContext.ORDERS.FirstOrDefault(x => x.order_id == id);
            }
            return order;
        }

        public bool InsertOrder(ORDERS newOrder)
        {
            using (OrderGraberDBEntities dbContext = new OrderGraberDBEntities())
            {
                dbContext.ORDERS.Add(newOrder);
                dbContext.SaveChanges();
            }
            return true;
        }

        public bool UpdateOrder(ORDERS editOrder)
        {
            bool result = false;
            using (OrderGraberDBEntities dbContext = new OrderGraberDBEntities())
            {
                var recordToEdit = dbContext.ORDERS.FirstOrDefault(x => x.order_id == editOrder.order_id);
                recordToEdit.client_id = editOrder.client_id;
                recordToEdit.order_date = editOrder.order_date;
                recordToEdit.total_order = editOrder.total_order;
                recordToEdit.state = editOrder.state;
            }
            return result;
        }

        public bool DeleteOrder(int id)
        {
            bool result = false;
            using (OrderGraberDBEntities dbContext = new OrderGraberDBEntities())
            {
                var recordToDelete = dbContext.ORDERS.Find(id);
                dbContext.ORDERS.Remove(recordToDelete);
                dbContext.SaveChanges();
            }
            return result;
        }
    }
}

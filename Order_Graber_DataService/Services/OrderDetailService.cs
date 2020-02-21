using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_Graber_DataService.Services
{
    public class OrderDetailService
    {
        public List<ORDERS_DETAIL> GetAllOrdersDetails()
        {
            using (OrderGraberDBEntities dbContext = new OrderGraberDBEntities())
            {
                return dbContext.ORDERS_DETAIL.ToList();
            }
        }

        public ORDERS_DETAIL GetOrderDetailsById(int id)
        {
            var orderDetails = new ORDERS_DETAIL();

            using (OrderGraberDBEntities dbContext = new OrderGraberDBEntities())
            {
                orderDetails = dbContext.ORDERS_DETAIL.FirstOrDefault(x => x.line_id == id);
            }
            return orderDetails;
        }

        public bool InsertOrderDetail(ORDERS_DETAIL newOrderDetail)
        {
            using (OrderGraberDBEntities dbContext = new OrderGraberDBEntities())
            {
                dbContext.ORDERS_DETAIL.Add(newOrderDetail);
                dbContext.SaveChanges();
            }
            return true;
        }

        public bool UpdateOrderDetail(ORDERS_DETAIL editOrderDetail)
        {
            bool result = false;
            using (OrderGraberDBEntities dbContext = new OrderGraberDBEntities())
            {
                var recordToEdit = dbContext.ORDERS_DETAIL.FirstOrDefault(x => x.line_id == editOrderDetail.line_id);
                recordToEdit.order_id = editOrderDetail.order_id;
                recordToEdit.product_id = editOrderDetail.product_id;
                recordToEdit.quantity = editOrderDetail.quantity;
                recordToEdit.total_line = editOrderDetail.total_line;
            }
            return result;
        }

        public bool DeleteOrderDetail(int id)
        {
            bool result = false;
            using (OrderGraberDBEntities dbContext = new OrderGraberDBEntities())
            {
                var recordToDelete = dbContext.ORDERS_DETAIL.Find(id);
                dbContext.ORDERS_DETAIL.Remove(recordToDelete);
                dbContext.SaveChanges();
            }
            return result;
        }
    }
}

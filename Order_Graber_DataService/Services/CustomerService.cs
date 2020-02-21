using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_Graber_DataService.Services
{
    public class CustomerService
    {
        public List<CUSTOMERS> GetAllCustomers()
        {
            using (OrderGraberDBEntities dbContext = new OrderGraberDBEntities())
            {
                return dbContext.CUSTOMERS.ToList();
            }
        }

        public CUSTOMERS GetCustomerById(int id)
        {
            var customer = new CUSTOMERS();

            using (OrderGraberDBEntities dbContext = new OrderGraberDBEntities())
            {
                customer = dbContext.CUSTOMERS.FirstOrDefault(x => x.client_id == id);
            }
            return customer;
        }

        public bool InsertCustomer(CUSTOMERS newCustomer)
        {
            using (OrderGraberDBEntities dbContext = new OrderGraberDBEntities())
            {
                dbContext.CUSTOMERS.Add(newCustomer);
                dbContext.SaveChanges();
            }
            return true;
        }

        public bool UpdateCustomer(CUSTOMERS editCustomer)
        {
            bool result = false;
            using (OrderGraberDBEntities dbContext = new OrderGraberDBEntities())
            {
                var recordToEdit = dbContext.CUSTOMERS.FirstOrDefault(x => x.client_id == editCustomer.client_id);
                recordToEdit.document_type = editCustomer.document_type;
                recordToEdit.document_nro = editCustomer.document_nro;
                recordToEdit.customer_name = editCustomer.customer_name;
                recordToEdit.address = editCustomer.address;
                recordToEdit.email = editCustomer.email;
                recordToEdit.state = editCustomer.state;
            }
            return result;
        }

        public bool DeleteCustomer(int id)
        {
            bool result = false;
            using (OrderGraberDBEntities dbContext = new OrderGraberDBEntities())
            {
                var recordToDelete = dbContext.CUSTOMERS.Find(id);
                dbContext.CUSTOMERS.Remove(recordToDelete);
                dbContext.SaveChanges();
            }
            return result;
        }


    }

}

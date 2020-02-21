using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_Graber_DataService.Services
{
    public class ProductService
    {
        public List<PRODUCTS> GetAllProducts()
        {
            using (OrderGraberDBEntities dbContext = new OrderGraberDBEntities())
            {
                return dbContext.PRODUCTS.ToList();
            }
        }

        public PRODUCTS GetProductById(int id)
        {
            var product = new PRODUCTS();

            using (OrderGraberDBEntities dbContext = new OrderGraberDBEntities())
            {
                product = dbContext.PRODUCTS.FirstOrDefault(x => x.product_id == id);
            }

            return product;

        }

        public bool InsertProduct(PRODUCTS newProduct)
        {
            using (OrderGraberDBEntities dbContext = new OrderGraberDBEntities())
            {
                dbContext.PRODUCTS.Add(newProduct);
                dbContext.SaveChanges();
            }
            return true;
        }

        public bool UpdateProduct(PRODUCTS editProduct)
        {
            bool result = false;
            using (OrderGraberDBEntities dbContext = new OrderGraberDBEntities())
            {
                var recordToEdit = dbContext.PRODUCTS.FirstOrDefault(x => x.product_id == editProduct.product_id);
                recordToEdit.product_code = editProduct.product_code;
                recordToEdit.product_name = editProduct.product_name;
                recordToEdit.cost_price = editProduct.cost_price;
                recordToEdit.sale_price = editProduct.sale_price;
                recordToEdit.state = editProduct.state;
                
            }

            return result;
        }

        public bool DeleteProduct(int id)
        {
            bool result = false;
            using (OrderGraberDBEntities dbContext = new OrderGraberDBEntities())
            {
                var recordToDelete = dbContext.PRODUCTS.Find(id);
                dbContext.PRODUCTS.Remove(recordToDelete);
                dbContext.SaveChanges();
            }
            return result;
        }


    }
}

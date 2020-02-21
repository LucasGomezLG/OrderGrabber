using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Order_Graber_DataService;
using CUSTOMERS = Order_Graber_DataService.CUSTOMERS;

namespace Order_Graber_Desktop.Forms
{
    public partial class Datos : Form
    {

        private Order_Graber_DataService.Services.CustomerService customerService;
        private Order_Graber_DataService.Services.ProductService productService;

        public Datos()
        {
            InitializeComponent();

            gridClientes.Columns.Add("Nombre", "nombre");
            gridClientes.Columns.Add("Telefono", "telefono");
            gridClientes.Columns.Add("State", "state");

            gridProductos.Columns.Add("Nombre", "nombre");
            gridProductos.Columns.Add("Precio al costo", "precio");
            gridProductos.Columns.Add("State", "state");
        }

        private void gridClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           Order_Graber_DataService.Services.CustomerService customerService;

           customerService = new Order_Graber_DataService.Services.CustomerService();

           var customersList = customerService.GetAllCustomers();

            MessageBox.Show("" + customersList);

    }
        
        private void button1_Click(object sender, EventArgs e)
        {

            gridClientes.Rows.Clear();

            customerService = new Order_Graber_DataService.Services.CustomerService();

            var customersList = customerService.GetAllCustomers();


            foreach (var i in customersList) {

                gridClientes.Rows.Add(i.customer_name, i.phone, i.state);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            gridProductos.Rows.Cslear();

            productService = new Order_Graber_DataService.Services.ProductService();

            var productList = productService.GetAllProducts();
         

            foreach (var i in productList)
            {
                gridProductos.Rows.Add(i.product_name, i.cost_price, i.state);
            }
        }

        private void gridProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
        }
    }
}

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
        private Order_Graber_DataService.Services.OrderService orderService;
        private Order_Graber_DataService.Services.OrderDetailService orderDetailService;

        public Datos()
        {
            InitializeComponent();

            gridClientes.Columns.Add("nombre", "Nombre");
            gridClientes.Columns.Add("telefono", "Telefono");
            gridClientes.Columns.Add("state", "State");

            gridProductos.Columns.Add("nombre", "Nombre");
            gridProductos.Columns.Add("precio", "precio al costo");
            gridProductos.Columns.Add("state", "State");

            gridOrdenes.Columns.Add("fecha", "Fecha");
            gridOrdenes.Columns.Add("total", "Total");
            gridOrdenes.Columns.Add("state", "State");

            gridDetOrd.Columns.Add("id_orden", "Id de orden");
            gridDetOrd.Columns.Add("id_producto", "Id de producto");
            gridDetOrd.Columns.Add("cantidad", "Cantidad");
            gridDetOrd.Columns.Add("total", "Total");

            customerService = new Order_Graber_DataService.Services.CustomerService();
            var customersList = customerService.GetAllCustomers();
            foreach (var i in customersList)
            {
                gridClientes.Rows.Add(i.customer_name, i.phone, i.state);
            }

            productService = new Order_Graber_DataService.Services.ProductService();
            var products = productService.GetAllProducts();
            foreach (var i in products)
            {
                gridProductos.Rows.Add(i.product_name, i.cost_price, i.state);
            }

            orderService = new Order_Graber_DataService.Services.OrderService();
            var orderList = orderService.GetAllOrders();
            foreach (var i in orderList)
            {
                gridOrdenes.Rows.Add(i.order_date, i.total_order, i.state);
            }

            orderDetailService = new Order_Graber_DataService.Services.OrderDetailService();
            var ordersDetails = orderDetailService.GetAllOrdersDetails();
            foreach (var i in ordersDetails)
            {
                gridDetOrd.Rows.Add(i.order_id, i.product_id, i.quantity, i.total_line);
            }


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

            gridProductos.Rows.Clear();

            productService = new Order_Graber_DataService.Services.ProductService();

            var products = productService.GetAllProducts();
         

            foreach (var i in products)
            {
               gridProductos.Rows.Add(i.product_name, i.cost_price, i.state);
            }
        }

        private void gridProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            gridOrdenes.Rows.Clear();

            orderService = new Order_Graber_DataService.Services.OrderService();

            var orderList = orderService.GetAllOrders();


            foreach (var i in orderList)
            {
                gridOrdenes.Rows.Add(i.order_date, i.total_order, i.state);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            gridDetOrd.Rows.Clear();

            orderDetailService = new Order_Graber_DataService.Services.OrderDetailService();
            var ordersDetails = orderDetailService.GetAllOrdersDetails();
            foreach (var i in ordersDetails)
            {
                gridDetOrd.Rows.Add(i.order_id, i.product_id, i.quantity, i.total_line);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddCliente Check = new AddCliente();
            Check.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddProductos Check = new AddProductos();
            Check.Show();
            Hide();
        }
    }
}

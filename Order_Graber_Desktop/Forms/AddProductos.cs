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
using PRODUCTS = Order_Graber_DataService.PRODUCTS;

namespace Order_Graber_Desktop.Forms
{
    public partial class AddProductos : Form
    {
        private Order_Graber_DataService.Services.ProductService productService;

        public AddProductos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             try
             {
                 productService = new Order_Graber_DataService.Services.ProductService();
                 PRODUCTS newProduct = new PRODUCTS()
                 {
                     product_code = textBox1.Text,
                     product_name = textBox2.Text,
                     cost_price = Decimal.ToDouble(numericUpDown1.Value),
                     sale_price = Decimal.ToDouble(numericUpDown2.Value),
                     state = textBox4.Text,
                 };

                 productService.InsertProduct(newProduct);

                 Datos Check = new Datos();
                 Check.Show();
                 Hide();

             }
             catch
             {
                 MessageBox.Show("Error");
             }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datos Check = new Datos();
            Check.Show();
            Hide();
        }
    }
}

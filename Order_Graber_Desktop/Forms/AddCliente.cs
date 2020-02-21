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
    public partial class AddCliente : Form
    {
        private Order_Graber_DataService.Services.CustomerService customerService;

        public AddCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                customerService = new Order_Graber_DataService.Services.CustomerService();
                CUSTOMERS newCustomer = new CUSTOMERS()
                {
                    document_type = textBox1.Text,
                    document_nro = textBox2.Text,
                    customer_name = textBox3.Text,
                    address = textBox4.Text,
                    phone = textBox5.Text,
                    email = textBox6.Text,
                    state = textBox7.Text,
                };

                customerService.InsertCustomer(newCustomer);

                Datos Check = new Datos();
                Check.Show();
                Hide();

            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Datos Check = new Datos();
            Check.Show();
            Hide();
        }
    }
}

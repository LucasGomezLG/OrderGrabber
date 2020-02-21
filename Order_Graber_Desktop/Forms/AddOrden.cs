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
using ORDERS = Order_Graber_DataService.ORDERS;

namespace Order_Graber_Desktop.Forms
{
    public partial class AddOrden : Form
    {
        private Order_Graber_DataService.Services.OrderService orderService;

        public AddOrden()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datos Check = new Datos();
            Check.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                orderService = new Order_Graber_DataService.Services.OrderService();
                ORDERS newOrder = new ORDERS()
                {
                    client_id = Decimal.ToInt32(numericUpDown1.Value),
                    order_date = dateTime.Value,
                    total_order = Decimal.ToDouble(numericUpDown2.Value),
                    state = textBox1.Text,
                };

                orderService.InsertOrder(newOrder);

                Datos Check = new Datos();
                Check.Show();
                Hide();

            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}

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
using ORDERS_DETAIL = Order_Graber_DataService.ORDERS_DETAIL;

namespace Order_Graber_Desktop.Forms
{
    public partial class AddDetalleOrden : Form
    {
        private Order_Graber_DataService.Services.OrderDetailService orderDetailService;

        public AddDetalleOrden()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

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
                orderDetailService = new Order_Graber_DataService.Services.OrderDetailService();
                ORDERS_DETAIL newOrderDetail = new ORDERS_DETAIL()
                {
                   order_id = Decimal.ToInt32( numericUpDown1.Value),
                   product_id = Decimal.ToInt32 (numericUpDown2.Value),
                   quantity = Decimal.ToInt32 (numericUpDown3.Value),
                   total_line = Decimal.ToInt32 (numericUpDown4.Value)

                };

                orderDetailService.InsertOrderDetail(newOrderDetail);

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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalexam
{
    public partial class Ordered : Form
    {
        public Ordered()
        {
            InitializeComponent();
        }

        private void Ordered_Load(object sender, EventArgs e)
        {
            label6.Text = order.mainKey.ToString();
            order.ordertime=label10.Text = DateTime.Now.ToString("G");
            label1.Text = order.orderinformation;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            order.orderhis = "";
            order.ordername = this.textBox1.Text;
            order.orderphone = this.textBox2.Text;
            order.orderhis += "訂購人姓名:" + order.ordername + "\n訂購人電話:" + order.orderphone + "\n訂購時間:" + order.ordertime + "\n訂購商品資訊:\n品名      數量     金額" + order.orderinformation;
            order.list.Add(order.mainKey, order.orderhis);
            if (order.orderhis != null)
            {
                this.label4.Text = "下單成功";
            }
            else
            {
                this.label4.Text = "下單失敗";
            }
        }
    }
}

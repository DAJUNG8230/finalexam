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
    public partial class order_history : Form
    {
        public order_history()
        {
            InitializeComponent();
        }
        private void order_history_Load(object sender, EventArgs e)
        {
            this.numericUpDown1.Maximum = order.mainKey;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label2.Text = "";
            this.groupBox1.Text = "第"+this.numericUpDown1.Value.ToString()+"訂單";
            int ordernum=Convert.ToInt32(this.numericUpDown1.Value.ToString());
            this.label2.Text = order.list[ordernum];
        }
    }
}

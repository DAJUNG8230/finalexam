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
    public partial class order : Form
    {
        public order()
        {
            InitializeComponent();
        }
        public static string ordername = "";
        public static string orderphone = "";
        public static string ordertime = "";
        public static string orderinformation;
        public static int mainKey = 0;
        public static string orderhis = "";

        public static Dictionary<int, string> list = new Dictionary<int, string>();

        private void button1_Click(object sender, EventArgs e)
        {
            mainKey++;
            orderinformation = "";
            string first = this.numericUpDown1.Value.ToString();
            int firstnum = int.Parse(this.numericUpDown1.Value.ToString());
            string secound = this.numericUpDown2.Value.ToString();
            int secoundnum = int.Parse(this.numericUpDown2.Value.ToString());
            if (firstnum != 0)
            {
                orderinformation += "冰淇淋     " + first + "個     "+"  $"+firstnum*15+"\n";
            }
            if (secoundnum != 0)
            {
                orderinformation += "老干媽     " + secound + "個     " + "  $" + secoundnum * 30 + "\n";
            }
            Ordered ordered = new Ordered();
            ordered.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            order_history order_History = new order_history();
            order_History.Show();
            this.Close();
        }
    }
}

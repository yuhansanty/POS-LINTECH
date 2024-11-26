using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinTechPOS
{
    public partial class Stock : Form

    {
        public Stock()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDashboard FrmDash = new FrmDashboard();
            FrmDash.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PurchaseOrder FrmPO = new PurchaseOrder();
            FrmPO.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Accounts FrmAcc = new Accounts();
            FrmAcc.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Stock FrmStock = new Stock();
            FrmStock.Show();
            this.Hide();
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lINTECHDataSet4.Stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter1.Fill(this.lINTECHDataSet4.Stock);
            // TODO: This line of code loads data into the 'lINTECHDataSet3.Stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.lINTECHDataSet3.Stock);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}

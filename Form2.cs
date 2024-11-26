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
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDashboard FrmDash = new FrmDashboard();
            FrmDash.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Accounts FrmAcc = new Accounts();
            FrmAcc.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PurchaseOrder FrmPO = new PurchaseOrder();
            FrmPO.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Stock FrmStock = new Stock();
            FrmStock.Show();
            this.Hide();
        }
    }
}

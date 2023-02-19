using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaAutomation
{
    public partial class frmSales : Form
    {
        public frmSales()
        {
            InitializeComponent();
        }
        CinemaDataSetTableAdapters.SalesTableAdapter salesTable = new CinemaDataSetTableAdapters.SalesTableAdapter();
        private void frmSales_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = salesTable.ListByDate2(dateTimePicker1.Text);
            TotalPay();
        }

        private void TotalPay()
        {
            int totalPay = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                totalPay += Convert.ToInt32(dataGridView1.Rows[i].Cells["Pay"].Value);
            }
            label1.Text = "Toplam satış=" + totalPay + " tl";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = salesTable.SalesList2();
            TotalPay();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = salesTable.ListByDate2(dateTimePicker1.Text);
            TotalPay();
        }
    }
}

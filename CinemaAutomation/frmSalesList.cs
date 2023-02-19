using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaAutomation
{
    public partial class frmSalesList : Form//aslında seansların listesi karışıklık olmuş
    {
        public frmSalesList()
        {
            InitializeComponent();
        }
        private string connectionSentence = @"Data Source=DESKTOP-RDDKO5L;Initial Catalog=Cinema;Integrated Security=True";
        DataTable tb = new DataTable();
       
        private void SeansList(string sql)
        {
            SqlConnection connection = new SqlConnection(connectionSentence);
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql,connection);
            da.Fill(tb);
            dataGridView1.DataSource = tb;
            connection.Close();

        }
        private void frmSalesList_Load(object sender, EventArgs e)
        {
            tb.Clear();
            SeansList("select * from Sessions where Date like'" + dateTimePicker1.Text + "'");

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            tb.Clear();
            SeansList("select * from Sessions where Date like'" + dateTimePicker1.Text + "'");

        }

        private void btnShowFullSession_Click(object sender, EventArgs e)
        {
            tb.Clear();
            SeansList("select * from Sessions ");
        }
    }
}

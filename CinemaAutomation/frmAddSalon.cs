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
    public partial class frmAddSalon : Form
    {
        public frmAddSalon()
        {
            InitializeComponent();
        }
        CinemaDataSetTableAdapters.SalonsTableAdapter salon = new CinemaDataSetTableAdapters.SalonsTableAdapter();

        private void btnSalonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                salon.AddSalon(txtSalonName.Text);
                MessageBox.Show("Salon Eklendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Aynı Salon Daha Önce Eklendi");
            }
            txtSalonName.Text = "";


        }
    }
}

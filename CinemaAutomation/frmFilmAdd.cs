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
    public partial class frmFilmAdd : Form
    {
        public frmFilmAdd()
        {
            InitializeComponent();
        }

        CinemaDataSetTableAdapters.FilmsTableAdapter filmsTable = new CinemaDataSetTableAdapters.FilmsTableAdapter();
        private void frmFilmAdd_Load(object sender, EventArgs e)
        {
           
        }

        private void btnFilmAdd_Click(object sender, EventArgs e)
        {
            try
            {
                filmsTable.AddFilm(txtFilmName.Text, txtDirector.Text, cmbFilmTye.Text, txtTime.Text, txtYear.Text, dateTimePicker1.Text, pictureBox1.ImageLocation);
                MessageBox.Show("Film Bilgileri eklendi");
            }
            catch (Exception)
            {

                MessageBox.Show("Film Bilgileri dah önce eklendi");
            }
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                    //işlem tamamlandıktan sonra texboxları temizleyecek;
                    cmbFilmTye.Text = "";
                    MessageBox.Show("Film Bilgileri  daha önce eklendi");
                }
            }
        }

        private void btnChooseBannner_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }
    }
}

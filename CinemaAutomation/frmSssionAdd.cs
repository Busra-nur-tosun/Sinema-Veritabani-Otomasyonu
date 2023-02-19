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
    public partial class frmSssionAdd : Form
    {
        public frmSssionAdd()
        {
            InitializeComponent();
        }
        private string connectionSentence = @"Data Source=DESKTOP-RDDKO5L;Initial Catalog=Cinema;Integrated Security=True";
       
        string session = "";
        private void SelectedRadioButton()
        {
            if (radioButton1.Checked==true)session = radioButton1.Text;
            else if (radioButton2.Checked == true)session = radioButton2.Text;
            else if (radioButton3.Checked == true) session = radioButton3.Text;
            else if (radioButton4.Checked == true)session = radioButton4.Text;
            else if (radioButton5.Checked == true)session = radioButton5.Text;
            else if (radioButton6.Checked == true)session = radioButton6.Text;
            else if (radioButton7.Checked == true)session = radioButton7.Text;
            else if (radioButton8.Checked == true)session = radioButton8.Text;
            else if (radioButton9.Checked == true)session = radioButton9.Text;
            else if (radioButton10.Checked == true)session = radioButton10.Text;
            else if (radioButton11.Checked == true)session = radioButton11.Text;
            else if (radioButton12.Checked == true)session = radioButton12.Text;


        }
        CinemaDataSetTableAdapters.SessionsTableAdapter sessionsTable = new CinemaDataSetTableAdapters.SessionsTableAdapter();
        private void btnSessionAdd_Click(object sender, EventArgs e)
        {
            SelectedRadioButton();
            if (session != "")
            {
               
                sessionsTable.AddSession2(comboBox1.Text, comboBox2.Text, dateTimePicker1.Text, session);
                MessageBox.Show("Seans ekleme işlemi yapıldı");
            }
            else if (session == "")
            {
                MessageBox.Show("Seans seçimi yapmadınız");
            }
            comboBox1.Text = "";
            comboBox2.Text = " ";
            dateTimePicker1.Text = DateTime.Now.ToShortDateString();

        }
     
        private void ShowFilmandSalon(ComboBox combo,string sql,string sql2)//veri tabanından kayıtların gelmesi sağlandı
        {
            SqlConnection connection = new SqlConnection(connectionSentence);

            connection.Open();
            SqlCommand command = new SqlCommand(sql, connection);//sorguyu burada gösterdi
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read()==true)
            {
                combo.Items.Add(reader[sql2].ToString());//comboya veri tabanından gelen sonucu atttık
            }
            connection.Close();
        }
        private void frmSssionAdd_Load(object sender, EventArgs e)
        {
            ShowFilmandSalon(comboBox1, "Select * from Films", "FilmName");
            ShowFilmandSalon(comboBox2, "Select * from Salons", "SalonName");

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            foreach (Control item3 in groupBox1.Controls)
            {
                item3.Enabled = true;
            }





            DateTime today = DateTime.Parse(DateTime.Now.ToShortDateString());
            DateTime neww = DateTime.Parse(dateTimePicker1.Text);
            if (neww == today)
            {
                foreach (Control item in groupBox2.Controls)//seçili seans saati pasif olarak duracak
                {
                    if (DateTime.Parse(DateTime.Now.ToShortTimeString()) > DateTime.Parse(item.Text))
                    {
                        item.Enabled = false;
                    }
                }
                Compare();

            }
            else if (neww > today)
            {
                Compare();
            }
            else if (neww < today)
            {
                MessageBox.Show("Geriye dönük işlem yapılamaz");
                dateTimePicker1.Text = DateTime.Now.ToShortDateString();
            }
        }
    private void Compare()//KARŞILAŞTIRIYOR
    {
        SqlConnection connection = new SqlConnection(connectionSentence);

        connection.Open();
        SqlCommand command = new SqlCommand("Select * from Sessions where SalonName='" + comboBox2.Text + "'and Date='" + dateTimePicker1.Text + "'", connection);
        SqlDataReader reader = command.ExecuteReader();
        while (reader.Read() == true)
        {
            foreach (Control item2 in groupBox2.Controls)
            {
                if (reader["Session"].ToString() == item2.Text)
                {
                    item2.Enabled = false;

                }
            }
        }
        connection.Close();
    }

    private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

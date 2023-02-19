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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string connectionSentence = @"Data Source=DESKTOP-RDDKO5L;Initial Catalog=Cinema;Integrated Security=True";
        int counter = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            EmptySeats();
            ShowFilmandSalon(cmbFilmName, "select * from Films", "FilmName");
            ShowFilmandSalon(cmbSalonName, "select * from Salons", "SalonName");
        }
        private void ReColor()//yeniden renkelendirmek için bir metot
        {
            foreach (Control item in panel1.Controls)
            {
                if (item is Button)
                {
                    item.BackColor = Color.White;
                }
            }
        }
        private void FullSeat()//veritabanına göre boş koltuklar
        {
            SqlConnection connection = new SqlConnection(connectionSentence);
            connection.Open();
            SqlCommand command = new SqlCommand("Select * from Sales where FilmName='"+cmbFilmName.SelectedItem+ "'and SalonName='" + cmbSalonName.Text + "'and Date='" + cmbFilmDate.SelectedItem + "' and Hour='" + cmbFilmSession.SelectedItem + "'", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                foreach (Control item in panel1.Controls)
                {
                    if (item is Button)
                    {
                        if (reader["SeatNo"].ToString()==item.Text)
                        {
                            item.BackColor = Color.Red;
                        }
                        
                    }
                }

            }
            connection.Close();
        }
        private void ComboFullSeat()//comboboxta dolu koltukların gözükmesi olayı
        {

            cmbxTicketCancellation.Items.Clear();
            cmbxTicketCancellation.Text = "";
          
                foreach (Control item in panel1.Controls)
                {
                    if (item is Button)
                    {
                        if (item.BackColor == Color.Red)
                    {
                        cmbxTicketCancellation.Items.Add(item.Text);
                        }                       
                        
                    }
                }

        }
    


        public void ShowFilmandSalon(ComboBox combo,string sqlQuery, string SqlAnswer)
        {
            SqlConnection connection = new SqlConnection(connectionSentence);
            connection.Open();
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                combo.Items.Add(reader[SqlAnswer].ToString());

            }
            connection.Close();

        }
        private void ShowBanner()
        {
            SqlConnection connection = new SqlConnection(connectionSentence);
            connection.Open();
            SqlCommand command = new SqlCommand("select * from Films where FilmName='"+cmbFilmName.SelectedItem+"'",connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                pictureBox1.ImageLocation = reader["Image"].ToString();
            }
            connection.Close();
        }

        private void EmptySeats()//ctrl+r+m hemen method yapar
        {//BOŞ KOLTUK OLUŞTURUYOR
            counter = 1;
            for (int i = 0; i < 8; i++)//8 tane yan yana koltuk
            {
                for (int j = 0; j < 9; j++)//9 tane alt alta koltuk
                {
                    Button btn = new Button();
                    btn.Size = new Size(30, 30);
                    btn.BackColor = Color.White;
                    btn.Location = new Point(j * 30 + 20, i * 30 + 20);
                    btn.Name = counter.ToString();
                    btn.Text = counter.ToString();
                    if (j == 4)
                    {
                        continue;//orta kısmın boş olmasını sağlayacak
                    }
                    counter++;
                    this.panel1.Controls.Add(btn);
                    btn.Click += Btn_Clik;

                }
            }
        }

        private void  Btn_Clik(object sender,EventArgs e)
        {
            Button button = (Button)sender;//butona bastığın zaman butonun özelliğini alır
            if (button.BackColor==Color.White)
            {
                txtSeatNo.Text = button.Text;
            }
        }


        private void btnSession_Click(object sender, EventArgs e)//seans 
        {
            frmSssionAdd sesionAdd = new frmSssionAdd();
            sesionAdd.ShowDialog();

        }

        private void btnSalon_Click(object sender, EventArgs e)
        {
            frmAddSalon addSalon = new frmAddSalon();
            addSalon.ShowDialog();
        }

        private void btnFilm_Click(object sender, EventArgs e)
        {
            frmFilmAdd filmAdd = new frmFilmAdd();
            filmAdd.ShowDialog();
        }

        private void btnListSesion_Click(object sender, EventArgs e)
        {
            frmSalesList salesList = new frmSalesList();
            salesList.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)//satışl
        {
            frmSales salesList = new frmSales();
            salesList.ShowDialog();
        }

        private void cmbFilmName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbFilmSession.Items.Clear();
            cmbFilmDate.Items.Clear();
            cmbSalonName.Text = "";
            cmbFilmSession.Text = "";
            cmbFilmDate.Text = "";
            foreach (Control item in groupBox1.Controls )
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            ShowBanner();
            ReColor();
            ComboFullSeat();
        }
        CinemaDataSetTableAdapters.SalesTableAdapter salesTableAdapter = new CinemaDataSetTableAdapters.SalesTableAdapter();
        private void btnSellTickets_Click(object sender, EventArgs e)
        {
            if (txtSeatNo.Text!="")
            {
                try
                {
                  
                    salesTableAdapter.Sell(txtSeatNo.Text, cmbSalonName.Text, cmbFilmName.Text, cmbFilmDate.Text, cmbFilmSession.Text, txtName.Text, txtSurname.Text, cmbPay.Text, DateTime.Now.ToString());
                    foreach (Control item in groupBox1.Controls)
                    {
                        if (item is TextBox)
                        {
                            item.Text = "";
                        }
                    }
                    ReColor();
                    FullSeat();
                    ComboFullSeat();
                }
                catch (Exception)
                {

                    MessageBox.Show("Hata oluştu");
                }
            }
            else 
            {
                MessageBox.Show("koltuk seçimi yapmadınız");
            }
           
        }
        private void BringMovieDate()
        {
            cmbFilmDate.Text = "";
            cmbFilmSession.Text = "";
            cmbFilmSession.Items.Clear();
            cmbFilmDate.Items.Clear();
            SqlConnection connection = new SqlConnection(connectionSentence);
            connection.Open();
            SqlCommand command = new SqlCommand("select * from Sessions where  FilmName='" + cmbFilmName.SelectedItem + "'and SalanName='" + cmbSalonName.SelectedItem+"'", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (DateTime.Parse(reader["Date"].ToString())>=DateTime.Parse(DateTime.Now.ToShortDateString()))
                {
                    if (!cmbFilmDate.Items.Contains(reader["Date"].ToString()))//sadece 1 tane olanı getirir
                    {
                        cmbFilmDate.Items.Add(reader["Date"]).ToString();
                    }
                
                }
               
            }
            connection.Close();

        }

        private void cmbSalonName_SelectedIndexChanged(object sender, EventArgs e)
        {
            BringMovieDate();
        }

        private void BringaMovieSession()
        {
          
            cmbFilmSession.Text = "";
            cmbFilmSession.Items.Clear();
            SqlConnection connection = new SqlConnection(connectionSentence);
            connection.Open();
            SqlCommand command = new SqlCommand("select * from Sessions where  FilmName='" + cmbFilmName.SelectedItem + "'and SalanName='" + cmbSalonName.SelectedItem + "'and Date='"+cmbFilmDate.SelectedItem+"'", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (DateTime.Parse(reader["Date"].ToString()) == DateTime.Parse(DateTime.Now.ToShortDateString()))
                {

                    if (DateTime.Parse(reader["Session"].ToString()) > DateTime.Parse(DateTime.Now.ToShortDateString()))
                    {
                        cmbFilmSession.Items.Add(reader["Session"]).ToString();
                    }
                       
                   

                }
               else  if (DateTime.Parse(reader["Date"].ToString()) > DateTime.Parse(DateTime.Now.ToShortDateString()))
                {

                    cmbFilmSession.Items.Add(reader["Session"]).ToString();


                }

            }
            connection.Close();
        }
        private void cmbFilmDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            BringaMovieSession();
        }

        private void cmbFilmSession_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReColor();
            FullSeat();
            ComboFullSeat();


        }

        private void btnTicketCancellation_Click(object sender, EventArgs e)
        {
            if (cmbxTicketCancellation.Text!="")
            {
                try
                {
                    salesTableAdapter.SaleCanceled(cmbFilmDate.Text, cmbSalonName.Text, cmbFilmDate.Text, cmbFilmSession.Text, cmbxTicketCancellation.Text);

                }
                catch (Exception)
                {


                    MessageBox.Show("hata oluştu");
                }
              
            }
            else
            {
                MessageBox.Show("Koltuk seçimi yapmadınız");
            }
        }
    }
}

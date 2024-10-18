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
using System.Data.Sql;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form 
    {
        public Form3()
        {
            InitializeComponent();
        }
     
        private void Form3_Load(object sender, EventArgs e)
        {
            int[] sembol = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Random random = new Random();
            int s1, s2, s3, s4;
            s1 = random.Next(0, sembol.Length);
            s2 = random.Next(0, sembol.Length);
            s3 = random.Next(0,sembol.Length);
            s4 = random.Next(0, sembol.Length);
            label5.Text = Convert.ToString(s1) + Convert.ToString(s2) + Convert.ToString(s3) + Convert.ToString(s4);

        }

        private void label5_Click(object sender, EventArgs e)
        {
            int[] sembol = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Random random = new Random();
            int s1, s2, s3, s4;
            s1 = random.Next(0, sembol.Length);
            s2 = random.Next(0, sembol.Length);
            s3 = random.Next(0, sembol.Length);
            s4 = random.Next(0, sembol.Length);
            label5.Text = Convert.ToString(s1) + Convert.ToString(s2) + Convert.ToString(s3) + Convert.ToString(s4);
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            string TC = maskedTextBox1.Text;
            SqlConnection baglanti = new SqlConnection("Data Source=Metehan\\SQLEXPRESS;Initial Catalog=E-Okul;Integrated Security=True;Encrypt=False");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From E_Okul_Ogrenci Where OgrTC = '" + maskedTextBox1.Text + "'",baglanti);
            SqlDataReader reader = komut.ExecuteReader();
            if (reader.Read() && label5.Text == maskedTextBox2.Text)
            {
                Form5 form5 = new Form5();
                form5.tc = maskedTextBox1.Text;
                form5.Show();
            }
            else
            {
                MessageBox.Show("Yeniden deneyiniz!!!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            baglanti.Close();
          
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
         
        // Random karakter oluşturmak için.
        private void label6_Click(object sender, EventArgs e)
        {
            int[] sembol = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Random random = new Random();
            int s1,s2,s3,s4;
            s1=random.Next(0,sembol.Length);
            s2=random.Next(0,sembol.Length);
            s3=random.Next(0,sembol.Length);
            s4=random.Next(0,sembol.Length);
            label6.Text = Convert.ToString(s1) + Convert.ToString(s2) + Convert.ToString(s3) + Convert.ToString(s4);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            int[] sembol = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Random random = new Random();
            int s1, s2, s3, s4;
            s1 = random.Next(0, sembol.Length);
            s2 = random.Next(0, sembol.Length);
            s3 = random.Next(0, sembol.Length);
            s4 = random.Next(0, sembol.Length);
            label6.Text = Convert.ToString(s1) + Convert.ToString(s2) + Convert.ToString(s3) + Convert.ToString(s4);
        }
        // Login giriş yaptırmak için.
        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciadi = textBox1.Text;
            string sifre = textBox2.Text;
            SqlConnection con = new SqlConnection("Data Source=Metehan\\SQLEXPRESS;Initial Catalog=E-Okul;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand com = new SqlCommand("Select *From E_Okul_Ogretmen Where PerKullaniciAd = '" + textBox1.Text + "'And PerSifre = '" + textBox2.Text + "'", con);
            SqlDataReader dr = com.ExecuteReader();
            if(dr.Read() && label6.Text==maskedTextBox1.Text)
            {
                Form4 fm = new Form4();
                fm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tekrar deneyiniz!!!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}

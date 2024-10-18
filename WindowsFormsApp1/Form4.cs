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

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        // Tüm SQL KOMUTLARA BURADA VAR!!!!!!!!!

        // Yeni öğrenci eklemek için. insert komutu.
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=Metehan\\SQLEXPRESS;Initial Catalog=E-Okul;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand com = new SqlCommand("insert into E_Okul_Ogrenci (OgrNo,OgrTC,OgrMat,OgrFen,OgrSosyal,OgrTurkce,OgrIng,OgrName) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)",con);
            com.Parameters.AddWithValue("@p1", textBox1.Text);
            com.Parameters.AddWithValue("@p2", maskedTextBox1.Text);
            com.Parameters.AddWithValue("@p3", textBox2.Text);
            com.Parameters.AddWithValue("@p4", textBox5.Text);
            com.Parameters.AddWithValue("@p5", textBox6.Text);
            com.Parameters.AddWithValue("@p6", textBox4.Text);
            com.Parameters.AddWithValue("@p7", textBox7.Text);
            com.Parameters.AddWithValue("@p8", textBox3.Text);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Öğrenci başarıyla eklendi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }


        // Öğrenci silmek için. delete komutu.
        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=Metehan\\SQLEXPRESS;Initial Catalog=E-Okul;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand com = new SqlCommand("Delete from E_Okul_Ogrenci Where OgrNo=@k1 and OgrTC=@k2",con);
            com.Parameters.AddWithValue("@k1", textBox1.Text);
            com.Parameters.AddWithValue("@k2", maskedTextBox1.Text);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Öğrenci başarıyla silindi.","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Çıkış butonu için.
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // Öğrenci notu güncellemek için.
        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=Metehan\\SQLEXPRESS;Initial Catalog=E-Okul;Integrated Security=True;Encrypt=False");
            con.Open();
            SqlCommand com = new SqlCommand("Update E_Okul_Ogrenci set OgrMat=@a2,OgrFen=@a3,OgrTurkce=@a4,OgrIng=@a5,OgrSosyal=@a6,OgrTC=@a7,OgrName=@a8 Where OgrNo=@a1", con);
            com.Parameters.AddWithValue("@a1", textBox1.Text);
            com.Parameters.AddWithValue("@a2", textBox2.Text);
            com.Parameters.AddWithValue("@a3", textBox5.Text);
            com.Parameters.AddWithValue("@a4", textBox4.Text);
            com.Parameters.AddWithValue("@a5", textBox7.Text);
            com.Parameters.AddWithValue("@a6", textBox6.Text);
            com.Parameters.AddWithValue("@a7", maskedTextBox1.Text);
            com.Parameters.AddWithValue("@a8", textBox3.Text);
            com.ExecuteNonQuery(); 
            con.Close();
            MessageBox.Show("Öğrenci başarıyla güncellendi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}

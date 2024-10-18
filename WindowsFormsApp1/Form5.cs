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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        /* formlar arası veri almak için yapılması gereken. Bu formda public değişken oluşturup yollamak
          istediğimiz formdaki değeri o formda yolluyoruz. */
        public string tc;

        public void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_E_OkulDataSet4.E_Okul_Ogrenci' table. You can move, or remove it, as needed.
            this.e_Okul_OgrenciTableAdapter.Fill(this._E_OkulDataSet4.E_Okul_Ogrenci);

            lbltc.Text = tc;

            // Önceki formdan numaraya göre alıp değerleri yazdırmamı sağladı.
            SqlConnection baglanti = new SqlConnection("Data Source=Metehan\\SQLEXPRESS;Initial Catalog=E-Okul;Integrated Security=True;Encrypt=False");
            baglanti.Open();
            SqlCommand com = new SqlCommand("Select * From E_Okul_Ogrenci Where OgrTC=@p1",baglanti);
            com.Parameters.AddWithValue("@p1", tc);
            SqlDataReader dr = com.ExecuteReader();
            while(dr.Read())
            {
                lblad.Text = dr[1].ToString();
                lblno.Text = dr[0].ToString();
                lblmat.Text = dr[2].ToString();
                lblfen.Text = dr[3].ToString();
                lblturkce.Text = dr[4].ToString();
                lblsosyal.Text = dr[6].ToString();
                lblıng.Text = dr[5].ToString();
            }
            baglanti.Close();
            double ortalama,mat,fen,turkce,ing,sosyal;
            mat = Convert.ToDouble(lblmat.Text);
            fen=Convert.ToDouble(lblfen.Text);
            turkce=Convert.ToDouble(lblturkce.Text);
            ing = Convert.ToDouble (lblıng.Text);
            sosyal=Convert.ToDouble(lblsosyal.Text);
            ortalama= (mat+fen+turkce+ing+sosyal)/5;
            label18.Text = Convert.ToString(ortalama);
        }
        // DataGridView ile değerleri direkt olarak label'a yazma.
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            lblad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            lblno.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            lbltc.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            lblmat.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            lblfen.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            lblturkce.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            lblsosyal.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            lblıng.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
          
        // Çıkış butonu.
        private void button1_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }
    }
}

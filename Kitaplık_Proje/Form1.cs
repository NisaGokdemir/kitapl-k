using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kitaplık_Proje
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=qwerty\SQLEXPRESS;Initial Catalog=KitaplarDB;Integrated Security=True");
        
        string durum = ""; 
        public Form1()
        {
            InitializeComponent();
        }

        void listele()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Kitaplar", connect);
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("INSERT INTO Kitaplar (KitapAD, Yazar, Tür, Sayfa, Durum) VALUES (@p1, @p2, @p3, @p4, @p5)", connect);
            command.Parameters.AddWithValue("@p1", TxtAD.Text);
            command.Parameters.AddWithValue("@p2", TxtKitapYazar.Text);
            command.Parameters.AddWithValue("@p3", CmbKitapTür.Text);
            command.Parameters.AddWithValue("@p4", int.Parse(TxtKitapSayfa.Text)); // Sayfa alanı INT türünde olduğu için dönüşüm yapılmalı
            command.Parameters.AddWithValue("@p5", durum);
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Kitap Sistemi Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            durum = "0";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            durum = "1";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtAD.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtKitapYazar.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbKitapTür.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtKitapSayfa.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();

            if (dataGridView1.Rows[secilen].Cells[5].Value.ToString() == "True")
            {
                radioButton2.Checked = true;
            }
            else
            {
                radioButton1.Checked = false;
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("DELETE FROM Kitaplar WHERE KitapID=@p1", connect);
            command.Parameters.AddWithValue("@p1", int.Parse(TxtID.Text)); 
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Kitap Listeden Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("UPDATE Kitaplar SET KitapAD=@p1, Yazar=@p2, Tür=@p3, Sayfa=@p4, Durum=@p5 WHERE KitapID=@p6", connect);
            command.Parameters.AddWithValue("@p1", TxtAD.Text);
            command.Parameters.AddWithValue("@p2", TxtKitapYazar.Text);
            command.Parameters.AddWithValue("@p3", CmbKitapTür.Text);
            command.Parameters.AddWithValue("@p4", int.Parse(TxtKitapSayfa.Text)); 
            command.Parameters.AddWithValue("@p5", durum);
            command.Parameters.AddWithValue("@p6", int.Parse(TxtID.Text)); 
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Kayıt Güncellendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void BtnBul_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Kitaplar WHERE KitapAD LIKE '%' + @p1 + '%'", connect);
            command.Parameters.AddWithValue("@p1", TxtKitapBul.Text);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            connect.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
//using iTextSharp.text;
//using iTextSharp.text.pdf;
using System.IO;

namespace POSipank
{
    public partial class Form1 : Form
    {
        //konek db
        static string conString = "Server=localhost;Database=dbpos;Uid=root;Pwd=;";
        MySqlConnection con = new MySqlConnection(conString);
        MySqlCommand cmd,cmd1;
        MySqlDataAdapter adapter,adapter1;

        //set datatable
        DataTable dt = new DataTable();

        public Form1()
        {

            InitializeComponent();

            //textbox1 fokus
            textBox1.Focus();

            //set nilai textbox5
            textBox5.Text = 1 + "";

            //disable button4 dan 6
            button4.Enabled = false;
            button6.Enabled = false;

            //dtg databarang
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Nama Barang";
            dataGridView1.Columns[2].Name = "Harga";
            dataGridView1.Columns[3].Name = "Stok";
            dataGridView1.Columns[4].Name = "Biaya Pesan";
            dataGridView1.Columns[5].Name = "Biaya Simpan";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            //dtg barang masuk
            dtgBarangMasuk.ColumnCount = 5;
            dtgBarangMasuk.Columns[0].Name = "ID";
            dtgBarangMasuk.Columns[1].Name = "Nama Barang";
            dtgBarangMasuk.Columns[2].Name = "Harga";
            dtgBarangMasuk.Columns[3].Name = "Banyaknya";
            dtgBarangMasuk.Columns[4].Name = "Jumlah";
            dtgBarangMasuk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgBarangMasuk.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgBarangMasuk.MultiSelect = false;

            //manual
            dataGridView2.ColumnCount = 4;
            dataGridView2.Columns[0].Name = "Nama Barang";
            dataGridView2.Columns[1].Name = "Total Penjualan";
            dataGridView2.Columns[2].Name = "Stok";
            dataGridView2.Columns[3].Name = "Kuantitas";
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;            
            dataGridView2.MultiSelect = false;

            //POQ
            dgvPOQ.ColumnCount = 4;
            dgvPOQ.Columns[0].Name = "Nama Barang";
            dgvPOQ.Columns[1].Name = "Total Penjualan";
            dgvPOQ.Columns[2].Name = "Stok";
            dgvPOQ.Columns[3].Name = "Kuantitas";
            dgvPOQ.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPOQ.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPOQ.MultiSelect = false;

            selectDataBarang();
        }


        //menambahkan 1 baris ke dgv data barang
        private void masukDgvDataBarang(String id, String nama, string harga, string stok, string biayasimpan,string biayapesan)
        {
            //tambahkan baris + value ke dgv
            dataGridView1.Rows.Add(id, nama, harga, stok, biayasimpan,biayapesan);
        }

        //ambil data dari db barang 
        private void selectDataBarang()
        {
            dataGridView1.Rows.Clear();
            //sql statment
            string sql = "SELECT * FROM barang ";
            cmd = new MySqlCommand(sql, con);
            //buka koneksi, ambil,masukan ke dgv
            try
            {
                con.Open();
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                //looping hasil select di dt.rows 
                foreach (DataRow row in dt.Rows)
                {
                    masukDgvDataBarang(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString());
                }
                con.Close();
                //CLEAR DT
                dt.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        //ubah data di db
        private void update(int id, string nama, int harga, int stok,int biayaPesan, int biayaSimpan)
        {
            //sql statment
            string sql = "UPDATE barang SET biaya_pesan='" + biayaPesan + "',biaya_simpan='" + biayaSimpan + "',nama_barang='" + nama + "',harga_satuan='" + harga + "',stok_barang='" + stok + "' WHERE kode_barang=" + id + "";
            cmd = new MySqlCommand(sql, con);
            //buka koneksi, ambil,masukan ke dgv
            try
            {
                con.Open();
                adapter = new MySqlDataAdapter(cmd);
                adapter.UpdateCommand = con.CreateCommand();
                adapter.UpdateCommand.CommandText = sql;
                if (adapter.UpdateCommand.ExecuteNonQuery() > 0)
                {
                    reset();
                    MessageBox.Show("Berhasil diupdate!!");
                }
                con.Close();
                selectDataBarang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }
        //delete data di db
        private void delete(string id)
        {
            //sql statment
            string sql = "DELETE FROM barang WHERE kode_barang=" + id + "";
            cmd = new MySqlCommand(sql, con);
            //'OPEN CON,EXECUTE DELETE,CLOSE CON
            try
            {
                con.Open();
                adapter = new MySqlDataAdapter(cmd);
                adapter.DeleteCommand = con.CreateCommand();
                adapter.DeleteCommand.CommandText = sql;
                //PROMPT FOR CONFIRMATION
                if (MessageBox.Show("Yakin ??", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        reset();
                        MessageBox.Show("Berhasil dihapus!!");
                    }
                }
                con.Close();
                selectDataBarang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }


        //perpindahan panel
        private void pindahPanel(string namaPanel)
        {

            if (namaPanel == "kasir")
            {
                panelKasir.Show();
                panelDataBrg.Hide();
                panelLaporan.Hide();
            }
            else if (namaPanel == "dataBarang")
            {
                panelKasir.Hide();
                panelDataBrg.Show();
                panelLaporan.Hide();
                selectDataBarang();
                textBox2.Focus();
            }
            else if (namaPanel == "laporan")
            {
                panelKasir.Hide();
                panelDataBrg.Hide();
                panelLaporan.Show();
            }
        }

        //clear textbox databarang
        private void cleartbBarang() {
            textBox2.Text = " ";
            textBox3.Text = " ";
            textBox4.Text = " ";
            textBox2.Focus();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            pindahPanel("kasir");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            pindahPanel("dataBarang");
        }


        private void BtnLaporan_Click(object sender, EventArgs e)
        {
            pindahPanel("laporan");
        }




        private void Button3_Click(object sender, EventArgs e)
        {
            if ((Regex.IsMatch(textBox3.Text, "[^0-9]+")) || (Regex.IsMatch(textBox4.Text, "[^0-9]+")))
            {


                MessageBox.Show("Inputan Harga & Stok harus berupa angka!!");

            }
            else {

                if (string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text))
                {
                    MessageBox.Show("Inputan tidak boleh kosong");

                }
                else
                {

                    //tambah data barang
                    String namaBrg = textBox2.Text;
                    String hargaBrg = textBox3.Text;
                    String stokBrg = textBox4.Text;
                    String biayaPesan = textBox7.Text;
                    String biayaSimpan = textBox14.Text;


                    string connectionString = @"server=localhost;userid=root;password=;database=dbpos";
                    MySqlConnection connection = null;
                    try
                    {
                        connection = new MySqlConnection(connectionString);
                        connection.Open();
                        MySqlCommand cmd = new MySqlCommand();
                        cmd.Connection = connection;
                        cmd.CommandText = "INSERT INTO barang(nama_barang,harga_satuan,stok_barang) VALUES(@v1,@v2,@v3,@v4,@v5)";
                        cmd.Prepare();

                        cmd.Parameters.AddWithValue("@v1", namaBrg);
                        cmd.Parameters.AddWithValue("@v2", hargaBrg);
                        cmd.Parameters.AddWithValue("@v3", stokBrg);
                        cmd.Parameters.AddWithValue("@v4", biayaPesan);
                        cmd.Parameters.AddWithValue("@v5", biayaSimpan);
                        cmd.ExecuteNonQuery();

                        button3.Enabled = true;
                        button4.Enabled = false;
                        button6.Enabled = false;
                        textBox2.Focus();

                    }
                    finally
                    {
                        if (connection != null)
                            connection.Close();
                    }

                    //refresh dgv
                    selectDataBarang();

                    //clear textbox data barang
                    cleartbBarang();

                    //
                    MessageBox.Show("Berhasil ditambahkan !!");

                }

            }
            
            
        }


        private void PanelDataBrg_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            DataGridViewCell cell = dataGridView1.SelectedCells[0] as DataGridViewCell;
            string value = cell.Value.ToString();
            delete(value);
        }

        private void Button4_Click(object sender, EventArgs e)
        {

            if ((Regex.IsMatch(textBox3.Text, "[^0-9]+")) || (Regex.IsMatch(textBox4.Text, "[^0-9]+")))
            {


                MessageBox.Show("Inputan Harga & Stok harus berupa angka!!");

            }
            else
            {
                DataGridViewCell cell = dataGridView1.SelectedCells[0] as DataGridViewCell;
                string value = cell.Value.ToString();
                update(Convert.ToInt32(value), textBox2.Text, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox14.Text));
                selectDataBarang();
            }

            
        }

        private void reset() {

            //clear textbox data barang
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox7.Text = "";
            textBox14.Text = "";

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            reset();

            //aktifkan tombol button3
            button3.Enabled = true;

            //matikan tombol button4 6
            button4.Enabled = false;
            button6.Enabled = false;

            //kursor fokus ke textbox2
            textBox2.Focus();

            selectDataBarang();
        }

        //aksi cell dgv databarang di klik
        private void DataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //matikan tombol button3
            button3.Enabled = false;

            //aktifkan tombol button4 6
            button4.Enabled = true;
            button6.Enabled = true;

            //ambil value cell ke 1
            DataGridViewCell cell0 = dataGridView1.SelectedCells[1] as DataGridViewCell;
            string value0 = cell0.Value.ToString();

            //ambil value cell ke 2
            DataGridViewCell cell1 = dataGridView1.SelectedCells[2] as DataGridViewCell;
            string value1 = cell1.Value.ToString();

            //ambil value cell ke 3
            DataGridViewCell cell2 = dataGridView1.SelectedCells[3] as DataGridViewCell;
            string value2 = cell2.Value.ToString();

           

            // data dimasukan ke textbox
            textBox2.Text = value0 + "";
            textBox3.Text = value1 + "";
            textBox4.Text = value2 + "";
            textBox7.Text = (Convert.ToInt32(textBox3.Text) * 0.1) + "";
            textBox14.Text = (Convert.ToInt32(textBox3.Text) * 0.02) + "";

        }

        //aksi textbox1 ketika pencet enter di keyboard
        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (!Regex.IsMatch(textBox1.Text, "[^0-9]+"))
                {
                    e.Handled = true;
                    masuk();

                    //kosongkan textbox1
                    textBox1.Text = "";

                    //set nilai textbox5 ke 1
                    textBox5.Text = 1 + "";

                    //fokus ke textbox1
                    textBox1.Focus();
                }
                else {
                    MessageBox.Show("Input Hanya Angka!!");
                }
            }
        }

        private void hitungBrgMasuk() {

            //hitung banyak baris/record
            int a = (dtgBarangMasuk.Rows.Count);
            int total = 0;
           
            for (int i = 0; i < a; i++)
            {
                //ambil value colom ke 4 dan baris ke i
                string b = dtgBarangMasuk[4, i].Value.ToString();

                //hitung semua loop
                total = total +  Convert.ToInt32(b);
            
            }

            //hasil loop dimasukan ke textbox
            txtJumlahTotal.Text = "TOTAL JUMLAH RP. " + total.ToString();

        }

        private void masuk(){

            string tb1 = textBox1.Text;

            //hapus baris di dgv
            dataGridView1.Rows.Clear();
            //sql statment
            string sql = "SELECT * FROM barang where kode_barang=" + tb1 ;
            cmd = new MySqlCommand(sql, con);
            //buka koneksi,ambil dr db,masukan ke dgv
            try
            {
                con.Open();
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                //loop hasil dr db
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        if (Convert.ToInt32(row[3]) <= 0)
                        {
                            MessageBox.Show("Stok Habis");
                        }
                        else
                        {

                            //hitung jumlah banyaknya, harga x banyaknya
                            int jumlah = Convert.ToInt32(row[2]) * Convert.ToInt32(textBox5.Text);

                            //masukan semua ke dgv
                            dtgBarangMasuk.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), textBox5.Text, jumlah);

                        }

                        
                    }
                }
                else {
                    MessageBox.Show("Kode Barang / Barcode tidak ada di Database!!!");
                }

                con.Close();
                //CLEAR DT                
                dt.Rows.Clear();

                hitungBrgMasuk();

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                con.Close();
            }

        }

        //aksi ketika textbox5 pencet enter di keyboard
        private void TextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (!Regex.IsMatch(textBox5.Text, "[^0-9]+"))
                {
                    e.Handled = true;
                    masuk();
                    textBox1.Text = "";
                    textBox5.Text = 1 + "";
                    textBox1.Focus();

                }
                else
                {
                    MessageBox.Show("Input Hanya Angka!!");
                }
            }
        }

        private void TbInputBarang_TextChanged(object sender, EventArgs e)
        {
            


        }

        //jika input bayar dan pencet enter dikeyboard
        private void TbInputBarang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (!Regex.IsMatch(tbInputBarang.Text, "[^0-9]+"))
                {
                    int bayar = Convert.ToInt32(tbInputBarang.Text);
                    int totalBelanjaan = Convert.ToInt32(Regex.Replace(txtJumlahTotal.Text, "[^0-9]+", string.Empty));

                    if (bayar >= totalBelanjaan)
                    {
                        int kembalian = bayar - totalBelanjaan;
                        txtKembalian.Text = "KEMBALIAN = RP. " + kembalian;
                        textBox1.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Nominal Bayar Kurang!!");
                    }

                }
                else {
                    MessageBox.Show("Input Hanya Angka!!");

                }

                tbInputBarang.Focus();   
            }
        }

        //AKSI button proses
        private void Button2_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin ingin memproses transaksi ??", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                //bikin id random
                var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            string pelanggan_random = new String(stringChars);
            //end bikin id

            //tanggal
            string tanggal = DateTime.Now.ToString("yyyy-MM-dd");
                MessageBox.Show(tanggal);

            //cek apakah id_pelanggan ada di database   
            //sql statment
            string sql = "SELECT id_pelanggan FROM pelanggan where id_pelanggan='" + pelanggan_random + "'";
            cmd = new MySqlCommand(sql, con);
                //buka koneksi,ambil dr db,masukan ke dgv
                try
                {
                    con.Open();
                    adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    //loop hasil dr db
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("tidak dapat membuat id random");
                    }
                    else
                    {
                        //id random berhasil dibuat  dan masukan ke db
                        insertPelangganRandom(pelanggan_random.ToString());

                        //hitung banyak baris/record
                        int a = (dtgBarangMasuk.Rows.Count);


                        for (int i = 0; i < a; i++)
                        {
                            //mulai transaksi
                            //ambil value colom ke 0 dan baris ke i
                            string kode = dtgBarangMasuk[0, i].Value.ToString();


                            //ambil value colom ke 2 dan baris ke i
                            string harga = dtgBarangMasuk[2, i].Value.ToString();

                            //ambil value colom ke 3 dan baris ke i
                            string stokDiambil = dtgBarangMasuk[3, i].Value.ToString();

                            //ambil value colom ke 4 dan baris ke i
                            string totalnya = dtgBarangMasuk[4, i].Value.ToString();
                           

                            //insert
                            insertTransaksi(pelanggan_random.ToString(),kode.ToString(), Convert.ToInt32(stokDiambil), Convert.ToInt32(totalnya), tanggal);

                            //update stok
                            updateStok(kode.ToString(), Convert.ToInt32(stokDiambil));
                        }

                        //mulai transaksi2
                       // insertTransaksi2(kodeTransaksi.ToString(), Convert.ToInt32(Regex.Replace(txtJumlahTotal.Text, "[^0-9]+", string.Empty)), Convert.ToInt32(tbInputBarang.Text), Convert.ToInt32(Regex.Replace(txtKembalian.Text, "[^0-9]+", string.Empty)));
                        con.Close();
                        MessageBox.Show("Berhasil diProses!");

                    }

                    con.Close();
                    //CLEAR DT                
                    dt.Rows.Clear();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

                txtJumlahTotal.Text = "JUMLAH TOTAL = RP.0";
                txtKembalian.Text = "KEMBALIAN = RP.0";
                tbInputBarang.Text = "";
                dtgBarangMasuk.Rows.Clear();
                dtgBarangMasuk.Columns.Clear();

                dtgBarangMasuk.ColumnCount = 5;
                dtgBarangMasuk.Columns[0].Name = "ID";
                dtgBarangMasuk.Columns[1].Name = "Nama Barang";
                dtgBarangMasuk.Columns[2].Name = "Harga";
                dtgBarangMasuk.Columns[3].Name = "Banyaknya";
                dtgBarangMasuk.Columns[4].Name = "Jumlah";
                dtgBarangMasuk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtgBarangMasuk.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dtgBarangMasuk.MultiSelect = false;
                
            }
        }

        private void insertPelangganRandom(string pelangganRandom) {
            //SQL STMT
            string sql = "INSERT INTO pelanggan(id_pelanggan) VALUES(@pelangganRandom)";
            cmd = new MySqlCommand(sql, con);
            //ADD PARAMETERS
            cmd.Parameters.AddWithValue("@pelangganRandom", pelangganRandom);
            
            //OPEN CON AND EXEC insert
            try
            {
                if (cmd.ExecuteNonQuery() > 0)
                {
                    //MessageBox.Show("Transaksi Berhasil diProses");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void updateStok(string idBarang,int kurangiStok) {
            string simpanStok = "";

            //cek stok awal 
            //sql statment
            string sql = "SELECT * FROM barang where kode_barang=" + Convert.ToInt32(idBarang);
            cmd = new MySqlCommand(sql, con);
            //buka koneksi,ambil dr db,masukan ke dgv
            try
            {
                
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                //loop hasil dr db                
                foreach (DataRow row in dt.Rows)
                {
                    simpanStok = row[3].ToString();                    
                }



                //CLEAR DT                
                dt.Rows.Clear();
                //MessageBox.Show(simpanStok + " awa" + kurangiStok);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

            int stok = Convert.ToInt32(Convert.ToInt32(simpanStok) - kurangiStok);
           
            //sql statment ubah
            string sql1 = "UPDATE barang SET stok_barang=" + stok + " WHERE kode_barang=" + Convert.ToInt32(idBarang);
            cmd1 = new MySqlCommand(sql1, con);
            
            //buka koneksi, ambil,masukan ke dgv
            try
            {
                adapter1 = new MySqlDataAdapter(cmd1);
                adapter1.UpdateCommand = con.CreateCommand();
                adapter1.UpdateCommand.CommandText = sql1;
                if (adapter1.UpdateCommand.ExecuteNonQuery() > 0)
                {
                    reset();
                    //MessageBox.Show("Berhasil diupdate!!");
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

        }

        //inser ke db transaksi2 //DISABLED FUCTION
        //private void insertTransaksi2(string kodeTransaksi, int totalTrx, int bayar, int kembali)
        //{
        //    //SQL STMT
        //    string sql = "INSERT INTO transaksi2(id_transaksi,total_transaksi,bayar,kembali) VALUES(@kodeTransaksi,@totalTrx,@bayar,@kembali)";
        //    cmd = new MySqlCommand(sql, con);
        //    //ADD kodeTransaksi
        //    cmd.Parameters.AddWithValue("@kodeTransaksi", kodeTransaksi);
        //    cmd.Parameters.AddWithValue("@totalTrx", totalTrx);
        //    cmd.Parameters.AddWithValue("@bayar", bayar);
        //    cmd.Parameters.AddWithValue("@kembali", kembali);            
        //    //OPEN CON AND EXEC insert
        //    try
        //    {
        //        if (cmd.ExecuteNonQuery() > 0)
        //        {
        //            //MessageBox.Show("Transaksi2 Berhasil diProses");
        //        }
        //
        //    }
        //    catch (Exception ex)
        //    {
        //
        //        MessageBox.Show(ex.Message);
        //        con.Close();
        //    }
        //}

        //insert ke db transksi
        private void insertTransaksi(string pelanggan_random, string idProduk, int banyaknya, int total, string tanggal) {
           //SQL STMT
           string sql = "INSERT INTO transaksi(kode_barang,id_pelanggan,banyaknya,jumlah,tanggal) VALUES(@idProduk,@pelanggan_random,@banyaknya,@total,@tanggal)";
           cmd = new MySqlCommand(sql, con);
           //ADD PARAMETERS
           cmd.Parameters.AddWithValue("@pelanggan_random", pelanggan_random);
           cmd.Parameters.AddWithValue("@idProduk", idProduk);
           cmd.Parameters.AddWithValue("@banyaknya", banyaknya);
            cmd.Parameters.AddWithValue("@total", total);
            cmd.Parameters.AddWithValue("@tanggal", tanggal);
            //OPEN CON AND EXEC insert
            try{  
                if (cmd.ExecuteNonQuery() > 0)
                {
                  //MessageBox.Show("Transaksi Berhasil diProses");
                }
                
            }
            catch (Exception ex){

               MessageBox.Show(ex.Message);
               con.Close();
           }
        }

        private void TbInputBarang_Leave(object sender, EventArgs e)
        {

        }

       

        private void TabControl1_Click(object sender, EventArgs e)
        {

        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage2"])//your specific tabname
            {
               
                    
            }
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

           
            
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            //if (comboBox2.SelectedIndex != -1 && comboBox1.SelectedIndex != -1)
            //{
            //    //combobox tidak kosong
            //    //MessageBox.Show(tempLabelBarang.Text);
            //    //select data transaksi sesuai nama barang
            //    string tglAwal = tempTahun.Text + "-" + tempBulanAngka.Text + "-01";
            //    string tglAkhir = tempTahun.Text + "-" + tempBulanAngka.Text + "-" + tempBulan.Text;
            //
            //
            //    dataGridView1.Rows.Clear();
            //    //sql statment
            //    string sql1 = "select barang.nama_barang as barang,sum(transaksi.banyaknya) as totaljual from barang inner join transaksi on barang.kode_barang = transaksi.kode_barang where barang.nama_barang ='" + tempLabelBarang.Text + "' and (transaksi.tanggal BETWEEN '"+ tglAwal +"' AND  '"+ tglAkhir +"') group by barang.nama_barang";
            //    MessageBox.Show(sql1);
            //    cmd = new MySqlCommand(sql1, con);
            //    //buka koneksi, ambil,masukan ke dgv
            //    try
            //    {
            //        con.Open();
            //        adapter = new MySqlDataAdapter(cmd);
            //        adapter.Fill(dt);
            //        //looping hasil select di dt.rows 
            //        foreach (DataRow row in dt.Rows)
            //        {
            //            MessageBox.Show(row["totaljual"].ToString());
            //            MessageBox.Show(row["barang"].ToString());                        
            //        }
            //        con.Close();
            //        //CLEAR DT
            //        dt.Rows.Clear();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //        con.Close();
            //    }
            //    //end ambil databarang
            //
            //    
            //}
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.GetItemText(comboBox1.SelectedItem))
            {
                case "Januari":
                    tempBulan.Text = 31 + "";
                    tempBulanAngka.Text = 1 + "";
                    break;
                case "Februari":
                    tempBulan.Text = 29 + "";
                    tempBulanAngka.Text = 2 + "";
                    break;
                case "Maret":
                    tempBulan.Text = 30 + "";
                    tempBulanAngka.Text = 3 + "";
                    break;
                case "April":
                    tempBulan.Text = 31 + "";
                    tempBulanAngka.Text = 4 + "";
                    break;
                case "Mei":
                    tempBulan.Text = 31 + "";
                    tempBulanAngka.Text = 5 + "";
                    break;
                case "Juni":
                    tempBulan.Text = 30 + "";
                    tempBulanAngka.Text = 6 + "";
                    break;
                case "Juli":
                    tempBulan.Text = 31 + "";
                    tempBulanAngka.Text = 7 + "";
                    break;
                case "Agustus":
                    tempBulan.Text = 31 + "";
                    tempBulanAngka.Text = 8 + "";
                    break;
                case "September":
                    tempBulan.Text = 30 + "";
                    tempBulanAngka.Text = 9 + "";
                    break;
                case "Oktober":
                    tempBulan.Text = 31 + "";
                    tempBulanAngka.Text = 10 + "";
                    break;
                case "November":
                    tempBulan.Text = 30 + "";
                    tempBulanAngka.Text = 11 + "";
                    break;
                case "Desember":
                    tempBulan.Text = 31 + "";
                    tempBulanAngka.Text = 12 + "";
                    break;
                default:
                    break;
            } 
        }

        private void CbTahun_SelectedIndexChanged(object sender, EventArgs e)
        {
            tempTahun.Text = cbTahun.GetItemText(cbTahun.SelectedItem) + "";
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            
        }


        string[] barang;
        private void Button12_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1 && cbTahun.SelectedIndex != -1)
            {            
                 var listBarang = new List<string>();
                 
                 //ambil data barang
                 dataGridView1.Rows.Clear();
                 //sql statment
                 string sql = "SELECT nama_barang FROM barang";
                 cmd = new MySqlCommand(sql, con);
                 //buka koneksi, ambil,masukan ke dgv
                 try
                 {
                     con.Open();
                     adapter = new MySqlDataAdapter(cmd);
                     adapter.Fill(dt);
                     //looping hasil select di dt.rows 
                     foreach (DataRow row in dt.Rows)
                     {
                         listBarang.Add(row[1].ToString());                    
                         
                     }
                     barang = listBarang.ToArray();
                    
                     con.Close();
                     //CLEAR DT
                     dt.Rows.Clear();
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.Message);
                     con.Close();
                 }
                 //end ambil databarang

                 //ambil tgl awal dan ahir
                 string tglAwal = tempTahun.Text + "-" + tempBulanAngka.Text + "-01";
                 string tglAkhir = tempTahun.Text + "-" + tempBulanAngka.Text + "-" + tempBulan.Text;
                 //end ambil tgl awal dan ahir

                

                 for (int i = 0; i < barang.Length; i++)
                 {
                     //sql statment
                     string sql1 = "select barang.nama_barang as barang,barang.stok_barang as stok,sum(transaksi.banyaknya) as totaljual,barang.biaya_simpan as biaya_simpan, barang.biaya_pesan as biaya_pesan from barang inner join transaksi on barang.kode_barang = transaksi.kode_barang where barang.nama_barang ='" + barang[i] + "' and (transaksi.tanggal BETWEEN '" + tglAwal + "' AND  '" + tglAkhir + "') group by barang.nama_barang";
                     //MessageBox.Show(sql1);
                     cmd = new MySqlCommand(sql1, con);
                     //buka koneksi, ambil,masukan ke dgv
                     try
                     {
                         con.Open();
                         adapter = new MySqlDataAdapter(cmd);
                         adapter.Fill(dt);
                         //looping hasil select di dt.rows 
                         foreach (DataRow row in dt.Rows)
                         {
                             
                             int totalJual = Convert.ToInt32(row["totaljual"].ToString());
                             int biayaPesan = Convert.ToInt32(row["biaya_pesan"].ToString());
                             int biayaSimpan = Convert.ToInt32(row["biaya_simpan"].ToString());

                            //rumus EOQ                            
                             double EOQ = (2 * totalJual * biayaPesan) / (biayaSimpan + 0.0000000001);
                             EOQ = Math.Sqrt(EOQ);

                             //hasil EOQ dibulatkan
                             double EOQBulat = Convert.ToInt32(Math.Ceiling(EOQ));

                             //rumus ROP, total penjualan / 4
                             double ROP = (Convert.ToInt32(row["totaljual"].ToString()) / 4);

                             //rumus POQ, bisi we diperlukan
                             double POQ = (EOQBulat + 0.0000000001) / (ROP + 0.0000000001);
                             
                             dgvPOQ.Rows.Add(row["barang"].ToString(), totalJual, row["stok"].ToString(), EOQBulat);

                         }
                         con.Close();
                         //CLEAR DT
                         dt.Rows.Clear();
                     }
                     catch (Exception ex)
                     {
                         MessageBox.Show(ex.Message);
                         con.Close();
                     }
                     //end ambil databarang
                 }
            }
            else
            {
                MessageBox.Show("Pilih Bulan dan Tahun!");
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(" "," "," "," ");
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            
        }

        private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //ambil value cell ke 1
            DataGridViewCell cell0 = dataGridView2.SelectedCells[1] as DataGridViewCell;
            string value0 = cell0.Value.ToString();

            button10.Text = "Hapus Baris " + value0;
        }

        int i = 0;
        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            int width = 0;
            int height = 0;
            int x = 0;
            int y = 0;
            int rowheight = 0;
            int columnwidth = 0;

            StringFormat str = new StringFormat();
            str.Alignment = StringAlignment.Near;
            str.LineAlignment = StringAlignment.Center;
            str.Trimming = StringTrimming.EllipsisCharacter;
            Pen p = new Pen(Color.Black, 2.5f);
            //e.Graphics.DrawRectangle(p,dgvPOQ.Bounds);

            //printPreviewDialog1.Document=printDocument1;
            //e.Graphics.DrawString("Hi this a test print", new Font(Font.SystemFontName,10.5f), Brushes.Black, new PointF(250.0f, 250.0f));
            //e.Graphics.DrawImage((Image)bm,new Point(10,10));

            #region Draw Column 1 

            e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(100, 100, dgvPOQ.Columns[0].Width, dgvPOQ.Rows[0].Height));
            e.Graphics.DrawRectangle(Pens.Black, 100, 100, dgvPOQ.Columns[0].Width, dgvPOQ.Rows[0].Height);
            e.Graphics.DrawString(dgvPOQ.Columns[0].HeaderText, dgvPOQ.Font, Brushes.Black, new RectangleF(100, 100, dgvPOQ.Columns[0].Width, dgvPOQ.Rows[0].Height), str);

            #endregion

            #region Draw column 2 

            e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(100 + dgvPOQ.Columns[0].Width, 100, dgvPOQ.Columns[0].Width, dgvPOQ.Rows[0].Height));
            e.Graphics.DrawRectangle(Pens.Black, 100 + dgvPOQ.Columns[0].Width, 100, dgvPOQ.Columns[0].Width, dgvPOQ.Rows[0].Height);
            e.Graphics.DrawString(dgvPOQ.Columns[1].HeaderText, dgvPOQ.Font, Brushes.Black, new RectangleF(100 + dgvPOQ.Columns[0].Width, 100, dgvPOQ.Columns[0].Width, dgvPOQ.Rows[0].Height), str);

            width = 100 + dgvPOQ.Columns[0].Width;
            height = 100;
            //variable i is declared at class level to preserve the value of i if e.hasmorepages is true
            while (i < dgvPOQ.Rows.Count - 1)
            {
                if (height > e.MarginBounds.Height)
                {
                    height = 100;
                    width = 100;
                    e.HasMorePages = true;
                    return;
                }

                height += dgvPOQ.Rows[i].Height;
                e.Graphics.DrawRectangle(Pens.Black, 100, height, dgvPOQ.Columns[0].Width, dgvPOQ.Rows[0].Height);
                e.Graphics.DrawString(dgvPOQ.Rows[i].Cells[0].FormattedValue.ToString(), dgvPOQ.Font, Brushes.Black, new RectangleF(100, height, dgvPOQ.Columns[0].Width, dgvPOQ.Rows[0].Height), str);

                e.Graphics.DrawRectangle(Pens.Black, 100 + dgvPOQ.Columns[0].Width, height, dgvPOQ.Columns[0].Width, dgvPOQ.Rows[0].Height);
                e.Graphics.DrawString(dgvPOQ.Rows[i].Cells[1].Value.ToString(), dgvPOQ.Font, Brushes.Black, new RectangleF(100 + dgvPOQ.Columns[0].Width, height, dgvPOQ.Columns[0].Width, dgvPOQ.Rows[0].Height), str);

                width += dgvPOQ.Columns[0].Width;
                i++;
            }

            #endregion
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textBox4.Text, "[^0-9]+"))
            {

            }
            else
            {
                MessageBox.Show("Input Hanya Angka!!");
                textBox4.Text = "";
            }
        }

       
    }
}

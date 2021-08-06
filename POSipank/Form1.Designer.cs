namespace POSipank
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelKasir = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtKembalian = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbInputBarang = new System.Windows.Forms.TextBox();
            this.txtJumlahTotal = new System.Windows.Forms.Label();
            this.dtgBarangMasuk = new System.Windows.Forms.DataGridView();
            this.btnKasir = new System.Windows.Forms.Button();
            this.btnDataBarang = new System.Windows.Forms.Button();
            this.btnLaporan = new System.Windows.Forms.Button();
            this.judulAPP = new System.Windows.Forms.Label();
            this.panelDataBrg = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panelLaporan = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.tempTahun = new System.Windows.Forms.Label();
            this.tempBulanAngka = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button12 = new System.Windows.Forms.Button();
            this.dgvPOQ = new System.Windows.Forms.DataGridView();
            this.button8 = new System.Windows.Forms.Button();
            this.cbTahun = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tempBulan = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.panelKasir.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBarangMasuk)).BeginInit();
            this.panelDataBrg.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelLaporan.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPOQ)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelKasir
            // 
            this.panelKasir.Controls.Add(this.groupBox4);
            this.panelKasir.Controls.Add(this.groupBox3);
            this.panelKasir.Location = new System.Drawing.Point(0, 0);
            this.panelKasir.Name = "panelKasir";
            this.panelKasir.Size = new System.Drawing.Size(760, 449);
            this.panelKasir.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.textBox5);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Location = new System.Drawing.Point(20, 68);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(733, 62);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Input Barang (Masukan Kode Barang / Barcode) ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(559, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Banyaknya";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(652, 23);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(75, 29);
            this.textBox5.TabIndex = 18;
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox5_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(536, 29);
            this.textBox1.TabIndex = 17;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.txtKembalian);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.tbInputBarang);
            this.groupBox3.Controls.Add(this.txtJumlahTotal);
            this.groupBox3.Controls.Add(this.dtgBarangMasuk);
            this.groupBox3.Location = new System.Drawing.Point(20, 136);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(740, 310);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Barang Masuk";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(625, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 30);
            this.button2.TabIndex = 15;
            this.button2.Text = "PROSES";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // txtKembalian
            // 
            this.txtKembalian.AutoSize = true;
            this.txtKembalian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKembalian.Location = new System.Drawing.Point(498, 110);
            this.txtKembalian.Name = "txtKembalian";
            this.txtKembalian.Size = new System.Drawing.Size(153, 20);
            this.txtKembalian.TabIndex = 14;
            this.txtKembalian.Text = "KEMBALIAN = RP.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(498, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "BAYAR = RP. ";
            // 
            // tbInputBarang
            // 
            this.tbInputBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInputBarang.Location = new System.Drawing.Point(611, 71);
            this.tbInputBarang.Name = "tbInputBarang";
            this.tbInputBarang.Size = new System.Drawing.Size(120, 26);
            this.tbInputBarang.TabIndex = 12;
            this.tbInputBarang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbInputBarang_KeyPress);
            // 
            // txtJumlahTotal
            // 
            this.txtJumlahTotal.AutoSize = true;
            this.txtJumlahTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJumlahTotal.Location = new System.Drawing.Point(498, 37);
            this.txtJumlahTotal.Name = "txtJumlahTotal";
            this.txtJumlahTotal.Size = new System.Drawing.Size(180, 20);
            this.txtJumlahTotal.TabIndex = 11;
            this.txtJumlahTotal.Text = "JUMLAH TOTAL = RP.0";
            // 
            // dtgBarangMasuk
            // 
            this.dtgBarangMasuk.AllowUserToAddRows = false;
            this.dtgBarangMasuk.AllowUserToDeleteRows = false;
            this.dtgBarangMasuk.AllowUserToResizeColumns = false;
            this.dtgBarangMasuk.AllowUserToResizeRows = false;
            this.dtgBarangMasuk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBarangMasuk.Location = new System.Drawing.Point(6, 27);
            this.dtgBarangMasuk.Name = "dtgBarangMasuk";
            this.dtgBarangMasuk.Size = new System.Drawing.Size(478, 264);
            this.dtgBarangMasuk.TabIndex = 9;
            // 
            // btnKasir
            // 
            this.btnKasir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKasir.Location = new System.Drawing.Point(363, 12);
            this.btnKasir.Name = "btnKasir";
            this.btnKasir.Size = new System.Drawing.Size(92, 30);
            this.btnKasir.TabIndex = 0;
            this.btnKasir.Text = "KASIR";
            this.btnKasir.UseVisualStyleBackColor = true;
            this.btnKasir.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnDataBarang
            // 
            this.btnDataBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDataBarang.Location = new System.Drawing.Point(462, 12);
            this.btnDataBarang.Name = "btnDataBarang";
            this.btnDataBarang.Size = new System.Drawing.Size(171, 30);
            this.btnDataBarang.TabIndex = 1;
            this.btnDataBarang.Text = "DATA BARANG";
            this.btnDataBarang.UseVisualStyleBackColor = true;
            this.btnDataBarang.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnLaporan
            // 
            this.btnLaporan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaporan.Location = new System.Drawing.Point(639, 12);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.Size = new System.Drawing.Size(133, 30);
            this.btnLaporan.TabIndex = 2;
            this.btnLaporan.Text = "ORDER";
            this.btnLaporan.UseVisualStyleBackColor = true;
            this.btnLaporan.Click += new System.EventHandler(this.BtnLaporan_Click);
            // 
            // judulAPP
            // 
            this.judulAPP.AutoSize = true;
            this.judulAPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.judulAPP.Location = new System.Drawing.Point(8, 15);
            this.judulAPP.Name = "judulAPP";
            this.judulAPP.Size = new System.Drawing.Size(310, 24);
            this.judulAPP.TabIndex = 3;
            this.judulAPP.Text = "POINT OF SALES ANEKA WARNA";
            // 
            // panelDataBrg
            // 
            this.panelDataBrg.Controls.Add(this.button5);
            this.panelDataBrg.Controls.Add(this.groupBox2);
            this.panelDataBrg.Controls.Add(this.groupBox1);
            this.panelDataBrg.Location = new System.Drawing.Point(0, 0);
            this.panelDataBrg.Name = "panelDataBrg";
            this.panelDataBrg.Size = new System.Drawing.Size(782, 449);
            this.panelDataBrg.TabIndex = 8;
            this.panelDataBrg.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelDataBrg_Paint);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(645, 341);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 30);
            this.button5.TabIndex = 18;
            this.button5.Text = "Reset";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(26, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(486, 350);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Barang";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 31);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(472, 313);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.textBox14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Location = new System.Drawing.Point(518, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 350);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tambah Barang";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(14, 156);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(92, 16);
            this.label24.TabIndex = 23;
            this.label24.Text = "Biaya Simpan";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(120, 155);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 20);
            this.textBox14.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(14, 124);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 16);
            this.label15.TabIndex = 21;
            this.label15.Text = "Biaya Pesan";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(120, 123);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 20;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(11, 264);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(95, 30);
            this.button6.TabIndex = 19;
            this.button6.Text = "Hapus";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(11, 219);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 30);
            this.button4.TabIndex = 18;
            this.button4.Text = "Ubah";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(127, 219);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 30);
            this.button3.TabIndex = 17;
            this.button3.Text = "Tambah";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Harga Satuan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Stok";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(120, 58);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nama Barang";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(121, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(120, 90);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 15;
            // 
            // panelLaporan
            // 
            this.panelLaporan.Controls.Add(this.label10);
            this.panelLaporan.Controls.Add(this.tempTahun);
            this.panelLaporan.Controls.Add(this.tempBulanAngka);
            this.panelLaporan.Controls.Add(this.tabControl1);
            this.panelLaporan.Controls.Add(this.tempBulan);
            this.panelLaporan.Controls.Add(this.button7);
            this.panelLaporan.Location = new System.Drawing.Point(0, 0);
            this.panelLaporan.Name = "panelLaporan";
            this.panelLaporan.Size = new System.Drawing.Size(782, 449);
            this.panelLaporan.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 24);
            this.label10.TabIndex = 8;
            this.label10.Text = "Order Kebutuhan";
            // 
            // tempTahun
            // 
            this.tempTahun.AutoSize = true;
            this.tempTahun.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempTahun.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tempTahun.Location = new System.Drawing.Point(713, 376);
            this.tempTahun.Name = "tempTahun";
            this.tempTahun.Size = new System.Drawing.Size(44, 18);
            this.tempTahun.TabIndex = 37;
            this.tempTahun.Text = "tahun";
            this.tempTahun.Visible = false;
            // 
            // tempBulanAngka
            // 
            this.tempBulanAngka.AutoSize = true;
            this.tempBulanAngka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempBulanAngka.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tempBulanAngka.Location = new System.Drawing.Point(711, 349);
            this.tempBulanAngka.Name = "tempBulanAngka";
            this.tempBulanAngka.Size = new System.Drawing.Size(43, 18);
            this.tempBulanAngka.TabIndex = 38;
            this.tempBulanAngka.Text = "bulan";
            this.tempBulanAngka.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(17, 108);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(681, 319);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button12);
            this.tabPage2.Controls.Add(this.dgvPOQ);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.cbTahun);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(673, 293);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hitung dari Data Kasir";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(218, 27);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 31);
            this.button12.TabIndex = 43;
            this.button12.Text = "Hitung";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.Button12_Click);
            // 
            // dgvPOQ
            // 
            this.dgvPOQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPOQ.Location = new System.Drawing.Point(15, 77);
            this.dgvPOQ.Name = "dgvPOQ";
            this.dgvPOQ.Size = new System.Drawing.Size(531, 187);
            this.dgvPOQ.TabIndex = 42;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(299, 28);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(110, 30);
            this.button8.TabIndex = 39;
            this.button8.Text = "Laporan PDF";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // cbTahun
            // 
            this.cbTahun.FormattingEnabled = true;
            this.cbTahun.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020"});
            this.cbTahun.Location = new System.Drawing.Point(115, 35);
            this.cbTahun.Name = "cbTahun";
            this.cbTahun.Size = new System.Drawing.Size(77, 21);
            this.cbTahun.TabIndex = 36;
            this.cbTahun.SelectedIndexChanged += new System.EventHandler(this.CbTahun_SelectedIndexChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(97, 37);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(12, 18);
            this.label22.TabIndex = 35;
            this.label22.Text = "/";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(138, 18);
            this.label14.TabIndex = 1;
            this.label14.Text = "Penjualan Bulan (D)";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Januari",
            "Februari",
            "Maret",
            "April",
            "Mei",
            "Juni",
            "Juli",
            "Agustus",
            "September",
            "Oktober",
            "November",
            "Desember"});
            this.comboBox1.Location = new System.Drawing.Point(15, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(76, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button11);
            this.tabPage3.Controls.Add(this.button10);
            this.tabPage3.Controls.Add(this.button9);
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(673, 293);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Manual";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(537, 252);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(113, 23);
            this.button11.TabIndex = 3;
            this.button11.Text = "Laporan PDF";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(537, 62);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(113, 23);
            this.button10.TabIndex = 2;
            this.button10.Text = "Kurangi Baris";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.Button10_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(537, 25);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(113, 23);
            this.button9.TabIndex = 1;
            this.button9.Text = "Tambah Baris";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(11, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(506, 250);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellClick);
            // 
            // tempBulan
            // 
            this.tempBulan.AutoSize = true;
            this.tempBulan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempBulan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tempBulan.Location = new System.Drawing.Point(711, 317);
            this.tempBulan.Name = "tempBulan";
            this.tempBulan.Size = new System.Drawing.Size(43, 18);
            this.tempBulan.TabIndex = 34;
            this.tempBulan.Text = "bulan";
            this.tempBulan.Visible = false;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(700, 273);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(68, 27);
            this.button7.TabIndex = 32;
            this.button7.Text = "Hitung";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Visible = false;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.judulAPP);
            this.Controls.Add(this.btnLaporan);
            this.Controls.Add(this.btnDataBarang);
            this.Controls.Add(this.btnKasir);
            this.Controls.Add(this.panelLaporan);
            this.Controls.Add(this.panelDataBrg);
            this.Controls.Add(this.panelKasir);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Point Of Sales";
            this.panelKasir.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBarangMasuk)).EndInit();
            this.panelDataBrg.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelLaporan.ResumeLayout(false);
            this.panelLaporan.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPOQ)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelKasir;
        private System.Windows.Forms.Button btnKasir;
        private System.Windows.Forms.Button btnLaporan;
        private System.Windows.Forms.Button btnDataBarang;
        private System.Windows.Forms.Label judulAPP;
        private System.Windows.Forms.Panel panelDataBrg;
        private System.Windows.Forms.Panel panelLaporan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label txtKembalian;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbInputBarang;
        private System.Windows.Forms.Label txtJumlahTotal;
        private System.Windows.Forms.DataGridView dtgBarangMasuk;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label tempBulan;
        private System.Windows.Forms.ComboBox cbTahun;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label tempTahun;
        private System.Windows.Forms.Label tempBulanAngka;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.DataGridView dgvPOQ;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button7;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}


namespace WindowsFormsApp1
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbltc = new System.Windows.Forms.Label();
            this.lblno = new System.Windows.Forms.Label();
            this.lblad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblıng = new System.Windows.Forms.Label();
            this.lblsosyal = new System.Windows.Forms.Label();
            this.lblturkce = new System.Windows.Forms.Label();
            this.lblfen = new System.Windows.Forms.Label();
            this.lblmat = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ogrNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrMatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrFenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrTurkceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrIngDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrSosyalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eOkulOgrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eOkulDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._E_OkulDataSet4 = new WindowsFormsApp1._E_OkulDataSet4();
            this.e_Okul_OgrenciTableAdapter = new WindowsFormsApp1._E_OkulDataSet4TableAdapters.E_Okul_OgrenciTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eOkulOgrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eOkulDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._E_OkulDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lbltc);
            this.groupBox1.Controls.Add(this.lblno);
            this.groupBox1.Controls.Add(this.lblad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(-1, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(638, 177);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Bilgileri";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(328, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltc.Location = new System.Drawing.Point(141, 101);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(137, 30);
            this.lbltc.TabIndex = 5;
            this.lbltc.Text = "Tc Kimlik No:";
            // 
            // lblno
            // 
            this.lblno.AutoSize = true;
            this.lblno.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblno.Location = new System.Drawing.Point(160, 69);
            this.lblno.Name = "lblno";
            this.lblno.Size = new System.Drawing.Size(160, 30);
            this.lblno.TabIndex = 4;
            this.lblno.Text = "Okul Numarası:";
            // 
            // lblad
            // 
            this.lblad.AutoSize = true;
            this.lblad.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblad.Location = new System.Drawing.Point(113, 39);
            this.lblad.Name = "lblad";
            this.lblad.Size = new System.Drawing.Size(114, 30);
            this.lblad.TabIndex = 3;
            this.lblad.Text = "Ad-Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(7, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tc Kimlik No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(4, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Okul Numarası:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(4, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad-Soyad:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.lblıng);
            this.groupBox2.Controls.Add(this.lblsosyal);
            this.groupBox2.Controls.Add(this.lblturkce);
            this.groupBox2.Controls.Add(this.lblfen);
            this.groupBox2.Controls.Add(this.lblmat);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(-8, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(645, 257);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğrenci Notları";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(385, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 48);
            this.button1.TabIndex = 18;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(515, 164);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(25, 30);
            this.label18.TabIndex = 17;
            this.label18.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(355, 164);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(163, 30);
            this.label17.TabIndex = 16;
            this.label17.Text = "Not Ortalaması:";
            // 
            // lblıng
            // 
            this.lblıng.AutoSize = true;
            this.lblıng.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblıng.Location = new System.Drawing.Point(160, 219);
            this.lblıng.Name = "lblıng";
            this.lblıng.Size = new System.Drawing.Size(121, 30);
            this.lblıng.TabIndex = 15;
            this.lblıng.Text = "Matematik:";
            // 
            // lblsosyal
            // 
            this.lblsosyal.AutoSize = true;
            this.lblsosyal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsosyal.Location = new System.Drawing.Point(160, 175);
            this.lblsosyal.Name = "lblsosyal";
            this.lblsosyal.Size = new System.Drawing.Size(121, 30);
            this.lblsosyal.TabIndex = 14;
            this.lblsosyal.Text = "Matematik:";
            // 
            // lblturkce
            // 
            this.lblturkce.AutoSize = true;
            this.lblturkce.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblturkce.Location = new System.Drawing.Point(160, 127);
            this.lblturkce.Name = "lblturkce";
            this.lblturkce.Size = new System.Drawing.Size(121, 30);
            this.lblturkce.TabIndex = 13;
            this.lblturkce.Text = "Matematik:";
            // 
            // lblfen
            // 
            this.lblfen.AutoSize = true;
            this.lblfen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblfen.Location = new System.Drawing.Point(160, 86);
            this.lblfen.Name = "lblfen";
            this.lblfen.Size = new System.Drawing.Size(121, 30);
            this.lblfen.TabIndex = 12;
            this.lblfen.Text = "Matematik:";
            // 
            // lblmat
            // 
            this.lblmat.AutoSize = true;
            this.lblmat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmat.Location = new System.Drawing.Point(160, 44);
            this.lblmat.Name = "lblmat";
            this.lblmat.Size = new System.Drawing.Size(121, 30);
            this.lblmat.TabIndex = 11;
            this.lblmat.Text = "Matematik:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(11, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 30);
            this.label11.TabIndex = 10;
            this.label11.Text = "Sosyal Bilgiler:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(79, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 30);
            this.label10.TabIndex = 9;
            this.label10.Text = "Türkçe:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(66, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 30);
            this.label9.TabIndex = 8;
            this.label9.Text = "İngilizce:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(28, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 30);
            this.label8.TabIndex = 7;
            this.label8.Text = "Fen Bilimleri:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(43, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 30);
            this.label7.TabIndex = 6;
            this.label7.Text = "Matematik:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrNoDataGridViewTextBoxColumn,
            this.ogrNameDataGridViewTextBoxColumn,
            this.ogrMatDataGridViewTextBoxColumn,
            this.ogrFenDataGridViewTextBoxColumn,
            this.ogrTurkceDataGridViewTextBoxColumn,
            this.ogrIngDataGridViewTextBoxColumn,
            this.ogrSosyalDataGridViewTextBoxColumn,
            this.ogrTCDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.eOkulOgrenciBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 437);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1134, 149);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // ogrNoDataGridViewTextBoxColumn
            // 
            this.ogrNoDataGridViewTextBoxColumn.DataPropertyName = "OgrNo";
            this.ogrNoDataGridViewTextBoxColumn.HeaderText = "OgrNo";
            this.ogrNoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ogrNoDataGridViewTextBoxColumn.Name = "ogrNoDataGridViewTextBoxColumn";
            this.ogrNoDataGridViewTextBoxColumn.Width = 150;
            // 
            // ogrNameDataGridViewTextBoxColumn
            // 
            this.ogrNameDataGridViewTextBoxColumn.DataPropertyName = "OgrName";
            this.ogrNameDataGridViewTextBoxColumn.HeaderText = "OgrName";
            this.ogrNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ogrNameDataGridViewTextBoxColumn.Name = "ogrNameDataGridViewTextBoxColumn";
            this.ogrNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // ogrMatDataGridViewTextBoxColumn
            // 
            this.ogrMatDataGridViewTextBoxColumn.DataPropertyName = "OgrMat";
            this.ogrMatDataGridViewTextBoxColumn.HeaderText = "OgrMat";
            this.ogrMatDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ogrMatDataGridViewTextBoxColumn.Name = "ogrMatDataGridViewTextBoxColumn";
            this.ogrMatDataGridViewTextBoxColumn.Width = 150;
            // 
            // ogrFenDataGridViewTextBoxColumn
            // 
            this.ogrFenDataGridViewTextBoxColumn.DataPropertyName = "OgrFen";
            this.ogrFenDataGridViewTextBoxColumn.HeaderText = "OgrFen";
            this.ogrFenDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ogrFenDataGridViewTextBoxColumn.Name = "ogrFenDataGridViewTextBoxColumn";
            this.ogrFenDataGridViewTextBoxColumn.Width = 150;
            // 
            // ogrTurkceDataGridViewTextBoxColumn
            // 
            this.ogrTurkceDataGridViewTextBoxColumn.DataPropertyName = "OgrTurkce";
            this.ogrTurkceDataGridViewTextBoxColumn.HeaderText = "OgrTurkce";
            this.ogrTurkceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ogrTurkceDataGridViewTextBoxColumn.Name = "ogrTurkceDataGridViewTextBoxColumn";
            this.ogrTurkceDataGridViewTextBoxColumn.Width = 150;
            // 
            // ogrIngDataGridViewTextBoxColumn
            // 
            this.ogrIngDataGridViewTextBoxColumn.DataPropertyName = "OgrIng";
            this.ogrIngDataGridViewTextBoxColumn.HeaderText = "OgrIng";
            this.ogrIngDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ogrIngDataGridViewTextBoxColumn.Name = "ogrIngDataGridViewTextBoxColumn";
            this.ogrIngDataGridViewTextBoxColumn.Width = 150;
            // 
            // ogrSosyalDataGridViewTextBoxColumn
            // 
            this.ogrSosyalDataGridViewTextBoxColumn.DataPropertyName = "OgrSosyal";
            this.ogrSosyalDataGridViewTextBoxColumn.HeaderText = "OgrSosyal";
            this.ogrSosyalDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ogrSosyalDataGridViewTextBoxColumn.Name = "ogrSosyalDataGridViewTextBoxColumn";
            this.ogrSosyalDataGridViewTextBoxColumn.Width = 150;
            // 
            // ogrTCDataGridViewTextBoxColumn
            // 
            this.ogrTCDataGridViewTextBoxColumn.DataPropertyName = "OgrTC";
            this.ogrTCDataGridViewTextBoxColumn.HeaderText = "OgrTC";
            this.ogrTCDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ogrTCDataGridViewTextBoxColumn.Name = "ogrTCDataGridViewTextBoxColumn";
            this.ogrTCDataGridViewTextBoxColumn.Width = 150;
            // 
            // eOkulOgrenciBindingSource
            // 
            this.eOkulOgrenciBindingSource.DataMember = "E_Okul_Ogrenci";
            this.eOkulOgrenciBindingSource.DataSource = this.eOkulDataSet4BindingSource;
            // 
            // eOkulDataSet4BindingSource
            // 
            this.eOkulDataSet4BindingSource.DataSource = this._E_OkulDataSet4;
            this.eOkulDataSet4BindingSource.Position = 0;
            // 
            // _E_OkulDataSet4
            // 
            this._E_OkulDataSet4.DataSetName = "_E_OkulDataSet4";
            this._E_OkulDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // e_Okul_OgrenciTableAdapter
            // 
            this.e_Okul_OgrenciTableAdapter.ClearBeforeFill = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(638, 432);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eOkulOgrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eOkulDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._E_OkulDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.Label lblno;
        private System.Windows.Forms.Label lblad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblıng;
        private System.Windows.Forms.Label lblsosyal;
        private System.Windows.Forms.Label lblturkce;
        private System.Windows.Forms.Label lblfen;
        private System.Windows.Forms.Label lblmat;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource eOkulDataSet4BindingSource;
        private _E_OkulDataSet4 _E_OkulDataSet4;
        private System.Windows.Forms.BindingSource eOkulOgrenciBindingSource;
        private _E_OkulDataSet4TableAdapters.E_Okul_OgrenciTableAdapter e_Okul_OgrenciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrMatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrFenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrTurkceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrIngDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrSosyalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}
namespace OkulAppSube1BIL
{
    partial class frmOgrtKayit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdt = new System.Windows.Forms.TextBox();
            this.txtSoyadt = new System.Windows.Forms.TextBox();
            this.txtTCkimlikt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKaydett = new System.Windows.Forms.Button();
            this.btnBult = new System.Windows.Forms.Button();
            this.btnSilt = new System.Windows.Forms.Button();
            this.btnGuncellet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "TCkimlik";
            // 
            // txtAdt
            // 
            this.txtAdt.Location = new System.Drawing.Point(91, 23);
            this.txtAdt.Name = "txtAdt";
            this.txtAdt.Size = new System.Drawing.Size(100, 20);
            this.txtAdt.TabIndex = 3;
            // 
            // txtSoyadt
            // 
            this.txtSoyadt.Location = new System.Drawing.Point(91, 70);
            this.txtSoyadt.Name = "txtSoyadt";
            this.txtSoyadt.Size = new System.Drawing.Size(100, 20);
            this.txtSoyadt.TabIndex = 4;
            // 
            // txtTCkimlikt
            // 
            this.txtTCkimlikt.Location = new System.Drawing.Point(91, 110);
            this.txtTCkimlikt.Name = "txtTCkimlikt";
            this.txtTCkimlikt.Size = new System.Drawing.Size(100, 20);
            this.txtTCkimlikt.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTCkimlikt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSoyadt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAdt);
            this.groupBox1.Location = new System.Drawing.Point(24, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 157);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ogretmen Kayıt";
            // 
            // btnKaydett
            // 
            this.btnKaydett.Location = new System.Drawing.Point(115, 218);
            this.btnKaydett.Name = "btnKaydett";
            this.btnKaydett.Size = new System.Drawing.Size(100, 33);
            this.btnKaydett.TabIndex = 7;
            this.btnKaydett.Text = "Kaydet";
            this.btnKaydett.UseVisualStyleBackColor = true;
            this.btnKaydett.Click += new System.EventHandler(this.btnKaydett_Click);
            // 
            // btnBult
            // 
            this.btnBult.Location = new System.Drawing.Point(365, 52);
            this.btnBult.Name = "btnBult";
            this.btnBult.Size = new System.Drawing.Size(75, 23);
            this.btnBult.TabIndex = 8;
            this.btnBult.Text = "Bul";
            this.btnBult.UseVisualStyleBackColor = true;
            this.btnBult.Click += new System.EventHandler(this.btnBult_Click);
            // 
            // btnSilt
            // 
            this.btnSilt.Enabled = false;
            this.btnSilt.Location = new System.Drawing.Point(365, 101);
            this.btnSilt.Name = "btnSilt";
            this.btnSilt.Size = new System.Drawing.Size(75, 23);
            this.btnSilt.TabIndex = 9;
            this.btnSilt.Text = "Sil";
            this.btnSilt.UseVisualStyleBackColor = true;
            this.btnSilt.Click += new System.EventHandler(this.btnSilt_Click);
            // 
            // btnGuncellet
            // 
            this.btnGuncellet.Enabled = false;
            this.btnGuncellet.Location = new System.Drawing.Point(365, 152);
            this.btnGuncellet.Name = "btnGuncellet";
            this.btnGuncellet.Size = new System.Drawing.Size(75, 23);
            this.btnGuncellet.TabIndex = 10;
            this.btnGuncellet.Text = "Güncelle";
            this.btnGuncellet.UseVisualStyleBackColor = true;
            this.btnGuncellet.Click += new System.EventHandler(this.btnGuncellet_Click);
            // 
            // frmOgrtKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 285);
            this.Controls.Add(this.btnGuncellet);
            this.Controls.Add(this.btnSilt);
            this.Controls.Add(this.btnBult);
            this.Controls.Add(this.btnKaydett);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmOgrtKayit";
            this.Text = "Ogretmen Kayıt Islemleri";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKaydett;
        private System.Windows.Forms.Button btnBult;
        public System.Windows.Forms.Button btnSilt;
        public System.Windows.Forms.Button btnGuncellet;
        public System.Windows.Forms.TextBox txtAdt;
        public System.Windows.Forms.TextBox txtSoyadt;
        public System.Windows.Forms.TextBox txtTCkimlikt;
    }
}
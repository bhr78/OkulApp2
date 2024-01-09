namespace OkulAppSube1BIL
{
    partial class frmOgrtBul
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnArat = new System.Windows.Forms.Button();
            this.txtNumarat = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tc Kimlik Giriniz";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnArat);
            this.groupBox1.Controls.Add(this.txtNumarat);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(78, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 135);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğretmen Bulma Ekranı";
            // 
            // btnArat
            // 
            this.btnArat.Location = new System.Drawing.Point(76, 106);
            this.btnArat.Name = "btnArat";
            this.btnArat.Size = new System.Drawing.Size(75, 23);
            this.btnArat.TabIndex = 1;
            this.btnArat.Text = "ARA";
            this.btnArat.UseVisualStyleBackColor = true;
            this.btnArat.Click += new System.EventHandler(this.btnArat_Click);
            // 
            // txtNumarat
            // 
            this.txtNumarat.Location = new System.Drawing.Point(63, 65);
            this.txtNumarat.Name = "txtNumarat";
            this.txtNumarat.Size = new System.Drawing.Size(100, 20);
            this.txtNumarat.TabIndex = 0;
            // 
            // frmOgrtBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 260);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmOgrtBul";
            this.Text = "frmOgrtBul";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnArat;
        private System.Windows.Forms.TextBox txtNumarat;
    }
}
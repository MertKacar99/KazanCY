namespace Veritabanli_Bilgi_Yarismasi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.richtextboxsoru = new System.Windows.Forms.RichTextBox();
            this.btnelli = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnlevel3 = new System.Windows.Forms.Button();
            this.btnlevel2 = new System.Windows.Forms.Button();
            this.btnlevel1 = new System.Windows.Forms.Button();
            this.lblSoruNo = new System.Windows.Forms.Label();
            this.lblanswer = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.lblseviyeKontrol = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richtextboxsoru
            // 
            this.richtextboxsoru.Enabled = false;
            this.richtextboxsoru.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richtextboxsoru.Location = new System.Drawing.Point(241, 88);
            this.richtextboxsoru.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.richtextboxsoru.Name = "richtextboxsoru";
            this.richtextboxsoru.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richtextboxsoru.Size = new System.Drawing.Size(698, 64);
            this.richtextboxsoru.TabIndex = 0;
            this.richtextboxsoru.Text = "";
            // 
            // btnelli
            // 
            this.btnelli.Location = new System.Drawing.Point(841, 51);
            this.btnelli.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnelli.Name = "btnelli";
            this.btnelli.Size = new System.Drawing.Size(98, 34);
            this.btnelli.TabIndex = 1;
            this.btnelli.Text = "%50";
            this.btnelli.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnlevel3);
            this.groupBox1.Controls.Add(this.btnlevel2);
            this.groupBox1.Controls.Add(this.btnlevel1);
            this.groupBox1.Location = new System.Drawing.Point(974, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 376);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seviyeler";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yanlış:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Doğru:";
            // 
            // btnlevel3
            // 
            this.btnlevel3.BackColor = System.Drawing.Color.Khaki;
            this.btnlevel3.Location = new System.Drawing.Point(31, 165);
            this.btnlevel3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnlevel3.Name = "btnlevel3";
            this.btnlevel3.Size = new System.Drawing.Size(265, 34);
            this.btnlevel3.TabIndex = 1;
            this.btnlevel3.Text = "Üçüncü Seviye";
            this.btnlevel3.UseVisualStyleBackColor = false;
            this.btnlevel3.Click += new System.EventHandler(this.btnlevel3_Click);
            // 
            // btnlevel2
            // 
            this.btnlevel2.BackColor = System.Drawing.Color.Khaki;
            this.btnlevel2.Location = new System.Drawing.Point(31, 207);
            this.btnlevel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnlevel2.Name = "btnlevel2";
            this.btnlevel2.Size = new System.Drawing.Size(265, 34);
            this.btnlevel2.TabIndex = 1;
            this.btnlevel2.Text = "İkinci Seviye";
            this.btnlevel2.UseVisualStyleBackColor = false;
            this.btnlevel2.Click += new System.EventHandler(this.btnlevel2_Click);
            // 
            // btnlevel1
            // 
            this.btnlevel1.BackColor = System.Drawing.Color.Khaki;
            this.btnlevel1.Location = new System.Drawing.Point(31, 249);
            this.btnlevel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnlevel1.Name = "btnlevel1";
            this.btnlevel1.Size = new System.Drawing.Size(265, 34);
            this.btnlevel1.TabIndex = 1;
            this.btnlevel1.Text = "Birinci Seviye";
            this.btnlevel1.UseVisualStyleBackColor = false;
            this.btnlevel1.Click += new System.EventHandler(this.btnlevel1_Click);
            // 
            // lblSoruNo
            // 
            this.lblSoruNo.AutoSize = true;
            this.lblSoruNo.Location = new System.Drawing.Point(239, 61);
            this.lblSoruNo.Name = "lblSoruNo";
            this.lblSoruNo.Size = new System.Drawing.Size(62, 24);
            this.lblSoruNo.TabIndex = 3;
            this.lblSoruNo.Text = "Soru:";
            // 
            // lblanswer
            // 
            this.lblanswer.AutoSize = true;
            this.lblanswer.Location = new System.Drawing.Point(241, 167);
            this.lblanswer.Name = "lblanswer";
            this.lblanswer.Size = new System.Drawing.Size(76, 24);
            this.lblanswer.TabIndex = 4;
            this.lblanswer.Text = "Cevap:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(243, 189);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(295, 30);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(243, 221);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(295, 34);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Gönder";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(134, 91);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(65, 24);
            this.lblId.TabIndex = 7;
            this.lblId.Text = "label3";
            this.lblId.Visible = false;
            // 
            // lblseviyeKontrol
            // 
            this.lblseviyeKontrol.AutoSize = true;
            this.lblseviyeKontrol.Location = new System.Drawing.Point(134, 133);
            this.lblseviyeKontrol.Name = "lblseviyeKontrol";
            this.lblseviyeKontrol.Size = new System.Drawing.Size(65, 24);
            this.lblseviyeKontrol.TabIndex = 8;
            this.lblseviyeKontrol.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1290, 397);
            this.Controls.Add(this.lblseviyeKontrol);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblanswer);
            this.Controls.Add(this.lblSoruNo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnelli);
            this.Controls.Add(this.richtextboxsoru);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richtextboxsoru;
        private System.Windows.Forms.Button btnelli;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnlevel3;
        private System.Windows.Forms.Button btnlevel2;
        private System.Windows.Forms.Button btnlevel1;
        private System.Windows.Forms.Label lblSoruNo;
        private System.Windows.Forms.Label lblanswer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblseviyeKontrol;
    }
}


namespace SinemaOtomasyonu
{
    partial class filmEkleme
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.filmadi = new System.Windows.Forms.TextBox();
            this.yonetmen = new System.Windows.Forms.TextBox();
            this.sure = new System.Windows.Forms.TextBox();
            this.yapimyili = new System.Windows.Forms.TextBox();
            this.filmturu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.filmekle = new System.Windows.Forms.Button();
            this.afisec = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.tarih = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(368, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // filmadi
            // 
            this.filmadi.Location = new System.Drawing.Point(150, 24);
            this.filmadi.Name = "filmadi";
            this.filmadi.Size = new System.Drawing.Size(155, 22);
            this.filmadi.TabIndex = 1;
            // 
            // yonetmen
            // 
            this.yonetmen.Location = new System.Drawing.Point(150, 69);
            this.yonetmen.Name = "yonetmen";
            this.yonetmen.Size = new System.Drawing.Size(155, 22);
            this.yonetmen.TabIndex = 2;
            // 
            // sure
            // 
            this.sure.Location = new System.Drawing.Point(150, 158);
            this.sure.Name = "sure";
            this.sure.Size = new System.Drawing.Size(155, 22);
            this.sure.TabIndex = 3;
            // 
            // yapimyili
            // 
            this.yapimyili.Location = new System.Drawing.Point(150, 203);
            this.yapimyili.Name = "yapimyili";
            this.yapimyili.Size = new System.Drawing.Size(155, 22);
            this.yapimyili.TabIndex = 4;
            // 
            // filmturu
            // 
            this.filmturu.FormattingEnabled = true;
            this.filmturu.Location = new System.Drawing.Point(150, 113);
            this.filmturu.Name = "filmturu";
            this.filmturu.Size = new System.Drawing.Size(155, 24);
            this.filmturu.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(399, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "FİLM AFİŞİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(40, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Yönetmen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.IndianRed;
            this.label3.Location = new System.Drawing.Point(40, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Film Türü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(40, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Süre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.IndianRed;
            this.label5.Location = new System.Drawing.Point(40, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Yapım Yılı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.IndianRed;
            this.label6.Location = new System.Drawing.Point(40, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Film Adı";
            // 
            // filmekle
            // 
            this.filmekle.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filmekle.Location = new System.Drawing.Point(200, 297);
            this.filmekle.Name = "filmekle";
            this.filmekle.Size = new System.Drawing.Size(105, 49);
            this.filmekle.TabIndex = 7;
            this.filmekle.Text = "Film Ekle";
            this.filmekle.UseVisualStyleBackColor = true;
            this.filmekle.Click += new System.EventHandler(this.filmekle_Click);
            // 
            // afisec
            // 
            this.afisec.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.afisec.Location = new System.Drawing.Point(439, 297);
            this.afisec.Name = "afisec";
            this.afisec.Size = new System.Drawing.Size(105, 49);
            this.afisec.TabIndex = 7;
            this.afisec.Text = "Afiş Seç";
            this.afisec.UseVisualStyleBackColor = true;
            this.afisec.Click += new System.EventHandler(this.afisec_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.IndianRed;
            this.label7.Location = new System.Drawing.Point(42, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tarih";
            // 
            // tarih
            // 
            this.tarih.Location = new System.Drawing.Point(150, 252);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(155, 22);
            this.tarih.TabIndex = 8;
            // 
            // filmEkleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SinemaOtomasyonu.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(630, 380);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.afisec);
            this.Controls.Add(this.filmekle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filmturu);
            this.Controls.Add(this.yapimyili);
            this.Controls.Add(this.sure);
            this.Controls.Add(this.yonetmen);
            this.Controls.Add(this.filmadi);
            this.Controls.Add(this.pictureBox1);
            this.Name = "filmEkleme";
            this.Text = "filmEkleme";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.filmEkleme_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox filmadi;
        private System.Windows.Forms.TextBox yonetmen;
        private System.Windows.Forms.TextBox sure;
        private System.Windows.Forms.TextBox yapimyili;
        private System.Windows.Forms.ComboBox filmturu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button filmekle;
        private System.Windows.Forms.Button afisec;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker tarih;
    }
}
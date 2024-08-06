namespace kafe_adisyon_uygulaması
{
    partial class masatasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(masatasi));
            cmbKaynakMasa = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            cmbHedefMasa = new ComboBox();
            btnMasayiTasi = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmbKaynakMasa
            // 
            cmbKaynakMasa.Font = new Font("Segoe UI", 20F);
            cmbKaynakMasa.FormattingEnabled = true;
            cmbKaynakMasa.Location = new Point(112, 182);
            cmbKaynakMasa.Name = "cmbKaynakMasa";
            cmbKaynakMasa.Size = new Size(195, 45);
            cmbKaynakMasa.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gainsboro;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(112, 127);
            label1.Name = "label1";
            label1.Size = new Size(195, 37);
            label1.TabIndex = 2;
            label1.Text = "KAYNAK MASA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gainsboro;
            label2.Font = new Font("Segoe UI", 20F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(478, 127);
            label2.Name = "label2";
            label2.Size = new Size(175, 37);
            label2.TabIndex = 4;
            label2.Text = "HEDEF MASA";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(334, 177);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // cmbHedefMasa
            // 
            cmbHedefMasa.Font = new Font("Segoe UI", 20F);
            cmbHedefMasa.FormattingEnabled = true;
            cmbHedefMasa.Location = new Point(469, 182);
            cmbHedefMasa.Name = "cmbHedefMasa";
            cmbHedefMasa.Size = new Size(195, 45);
            cmbHedefMasa.TabIndex = 6;
            // 
            // btnMasayiTasi
            // 
            btnMasayiTasi.BackColor = Color.White;
            btnMasayiTasi.Font = new Font("Segoe UI", 20F);
            btnMasayiTasi.Location = new Point(525, 320);
            btnMasayiTasi.Name = "btnMasayiTasi";
            btnMasayiTasi.Size = new Size(150, 61);
            btnMasayiTasi.TabIndex = 7;
            btnMasayiTasi.Text = "TAŞI";
            btnMasayiTasi.UseVisualStyleBackColor = false;
            btnMasayiTasi.Click += btnMasayiTasi_Click;
            // 
            // masatasi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMasayiTasi);
            Controls.Add(cmbHedefMasa);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbKaynakMasa);
            Name = "masatasi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "masatasi";
            Load += masatasi_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbKaynakMasa;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private ComboBox cmbHedefMasa;
        private Button btnMasayiTasi;
    }
}
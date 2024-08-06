namespace kafe_adisyon_uygulaması
{
    partial class adisyonekleme
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
            button1 = new Button();
            adisyon = new ListView();
            ürün_adet = new ColumnHeader();
            ürün_adi = new ColumnHeader();
            ürün_fiyati = new ColumnHeader();
            button2 = new Button();
            btnHesapOde = new Button();
            button4 = new Button();
            button5 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button13 = new Button();
            button12 = new Button();
            button6 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(12, 255);
            button1.Name = "button1";
            button1.Size = new Size(149, 81);
            button1.TabIndex = 0;
            button1.Text = "Masayı Taşı";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // adisyon
            // 
            adisyon.BackColor = Color.White;
            adisyon.BorderStyle = BorderStyle.None;
            adisyon.Columns.AddRange(new ColumnHeader[] { ürün_adet, ürün_adi, ürün_fiyati });
            adisyon.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            adisyon.ForeColor = Color.Black;
            adisyon.FullRowSelect = true;
            adisyon.GridLines = true;
            adisyon.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            adisyon.Location = new Point(181, 30);
            adisyon.Name = "adisyon";
            adisyon.Size = new Size(521, 530);
            adisyon.TabIndex = 1;
            adisyon.UseCompatibleStateImageBehavior = false;
            adisyon.View = View.Details;
            adisyon.SelectedIndexChanged += adisyon_SelectedIndexChanged;
            // 
            // ürün_adet
            // 
            ürün_adet.Text = "Adet";
            ürün_adet.Width = 150;
            // 
            // ürün_adi
            // 
            ürün_adi.Text = "Ürün Adı";
            ürün_adi.Width = 200;
            // 
            // ürün_fiyati
            // 
            ürün_fiyati.Text = "Ürün Fiyatı";
            ürün_fiyati.Width = 200;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(12, 369);
            button2.Name = "button2";
            button2.Size = new Size(149, 81);
            button2.TabIndex = 2;
            button2.Text = "İptal";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnHesapOde
            // 
            btnHesapOde.BackColor = Color.White;
            btnHesapOde.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnHesapOde.Location = new Point(462, 599);
            btnHesapOde.Name = "btnHesapOde";
            btnHesapOde.Size = new Size(240, 81);
            btnHesapOde.TabIndex = 3;
            btnHesapOde.Text = "Hesabı Öde";
            btnHesapOde.UseVisualStyleBackColor = false;
            btnHesapOde.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button4.Location = new Point(12, 143);
            button4.Name = "button4";
            button4.Size = new Size(149, 81);
            button4.TabIndex = 4;
            button4.Text = "-";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button5.Location = new Point(12, 30);
            button5.Name = "button5";
            button5.Size = new Size(149, 81);
            button5.TabIndex = 5;
            button5.Text = "+";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.DarkOrange;
            button7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button7.ForeColor = Color.Black;
            button7.Location = new Point(781, 155);
            button7.Name = "button7";
            button7.Size = new Size(231, 134);
            button7.TabIndex = 7;
            button7.Text = "Döner";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.DarkOrange;
            button8.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button8.Location = new Point(781, 280);
            button8.Name = "button8";
            button8.Size = new Size(231, 134);
            button8.TabIndex = 8;
            button8.Text = "Kebap";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.DarkOrange;
            button9.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button9.Location = new Point(781, 405);
            button9.Name = "button9";
            button9.Size = new Size(231, 134);
            button9.TabIndex = 9;
            button9.Text = "Soğuk İçecekler";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.DarkOrange;
            button10.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button10.Location = new Point(781, 30);
            button10.Name = "button10";
            button10.Size = new Size(231, 134);
            button10.TabIndex = 10;
            button10.Text = "Fast Food";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.DarkOrange;
            button11.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button11.Location = new Point(781, 530);
            button11.Name = "button11";
            button11.Size = new Size(231, 134);
            button11.TabIndex = 11;
            button11.Text = "Sıcak İçecekler";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.DarkOrange;
            button13.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button13.Location = new Point(781, 655);
            button13.Name = "button13";
            button13.Size = new Size(231, 134);
            button13.TabIndex = 13;
            button13.Text = "Tatlılar";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.White;
            button12.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button12.Location = new Point(181, 599);
            button12.Name = "button12";
            button12.Size = new Size(240, 81);
            button12.TabIndex = 14;
            button12.Text = "Siparişi Kaydet";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.DeepSkyBlue;
            button6.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button6.Location = new Point(1093, 30);
            button6.Name = "button6";
            button6.Size = new Size(258, 179);
            button6.TabIndex = 15;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button14
            // 
            button14.BackColor = Color.DeepSkyBlue;
            button14.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button14.Location = new Point(1384, 610);
            button14.Name = "button14";
            button14.Size = new Size(258, 179);
            button14.TabIndex = 16;
            button14.Text = "button14";
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // button15
            // 
            button15.BackColor = Color.DeepSkyBlue;
            button15.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button15.Location = new Point(1093, 416);
            button15.Name = "button15";
            button15.Size = new Size(258, 179);
            button15.TabIndex = 17;
            button15.Text = "button15";
            button15.UseVisualStyleBackColor = false;
            button15.Click += button15_Click;
            // 
            // button16
            // 
            button16.BackColor = Color.DeepSkyBlue;
            button16.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button16.Location = new Point(1384, 416);
            button16.Name = "button16";
            button16.Size = new Size(258, 179);
            button16.TabIndex = 18;
            button16.Text = "button16";
            button16.UseVisualStyleBackColor = false;
            button16.Click += button16_Click;
            // 
            // button17
            // 
            button17.BackColor = Color.DeepSkyBlue;
            button17.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button17.Location = new Point(1384, 220);
            button17.Name = "button17";
            button17.Size = new Size(258, 179);
            button17.TabIndex = 19;
            button17.Text = "button17";
            button17.UseVisualStyleBackColor = false;
            button17.Click += button17_Click;
            // 
            // button18
            // 
            button18.BackColor = Color.DeepSkyBlue;
            button18.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button18.Location = new Point(1093, 220);
            button18.Name = "button18";
            button18.Size = new Size(258, 179);
            button18.TabIndex = 20;
            button18.Text = "button18";
            button18.UseVisualStyleBackColor = false;
            button18.Click += button18_Click;
            // 
            // button19
            // 
            button19.BackColor = Color.DeepSkyBlue;
            button19.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button19.Location = new Point(1384, 30);
            button19.Name = "button19";
            button19.Size = new Size(258, 179);
            button19.TabIndex = 21;
            button19.Text = "button19";
            button19.UseVisualStyleBackColor = false;
            button19.Click += button19_Click;
            // 
            // button20
            // 
            button20.BackColor = Color.DeepSkyBlue;
            button20.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button20.Location = new Point(1093, 610);
            button20.Name = "button20";
            button20.Size = new Size(258, 179);
            button20.TabIndex = 22;
            button20.Text = "button20";
            button20.UseVisualStyleBackColor = false;
            button20.Click += button20_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(1093, 795);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(549, 438);
            flowLayoutPanel1.TabIndex = 23;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // adisyonekleme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1924, 1061);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button20);
            Controls.Add(button19);
            Controls.Add(button18);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button6);
            Controls.Add(button12);
            Controls.Add(button13);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(btnHesapOde);
            Controls.Add(button2);
            Controls.Add(adisyon);
            Controls.Add(button1);
            Name = "adisyonekleme";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "Adisyon";
            WindowState = FormWindowState.Maximized;
            Load += adisyonekleme_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ColumnHeader ürün_adet;
        private ColumnHeader ürün_adi;
        private ColumnHeader ürün_fiyati;
        private Button button2;
        private Button btnHesapOde;
        private Button button4;
        private Button button5;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button13;
        private Button button12;
        private Button button6;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
        public ListView adisyon;
        public FlowLayoutPanel flowLayoutPanel1;
    }
}
namespace kafe_adisyon_uygulaması
{
    partial class admin_panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_panel));
            button1 = new Button();
            pictureBox3 = new PictureBox();
            button3 = new Button();
            pictureBox4 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Font = new Font("Segoe UI", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.Black;
            button1.ImageAlign = ContentAlignment.BottomCenter;
            button1.Location = new Point(271, 143);
            button1.Name = "button1";
            button1.Size = new Size(616, 340);
            button1.TabIndex = 3;
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Gray;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(374, 163);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(394, 193);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Gray;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Font = new Font("Segoe UI", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.ForeColor = Color.Black;
            button3.ImageAlign = ContentAlignment.BottomCenter;
            button3.Location = new Point(947, 138);
            button3.Name = "button3";
            button3.Size = new Size(616, 340);
            button3.TabIndex = 6;
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Gray;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1050, 163);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(406, 218);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gray;
            label2.Font = new Font("Segoe UI", 35.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(454, 376);
            label2.Name = "label2";
            label2.Size = new Size(253, 62);
            label2.TabIndex = 11;
            label2.Text = "MASALAR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Gray;
            label3.Font = new Font("Segoe UI", 35.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(1154, 395);
            label3.Name = "label3";
            label3.Size = new Size(241, 62);
            label3.TabIndex = 12;
            label3.Text = "YÖNETİM";
            // 
            // admin_panel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1790, 1006);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox4);
            Controls.Add(button3);
            Controls.Add(pictureBox3);
            Controls.Add(button1);
            Name = "admin_panel";
            Text = "admin_panel";
            WindowState = FormWindowState.Maximized;
            Load += admin_panel_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private PictureBox pictureBox3;
        private Button button3;
        private PictureBox pictureBox4;
        private Label label2;
        private Label label3;
    }
}
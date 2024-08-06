namespace kafe_adisyon_uygulaması
{
    partial class yönetim
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
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 30F);
            button1.Location = new Point(289, 146);
            button1.Name = "button1";
            button1.Size = new Size(239, 129);
            button1.TabIndex = 0;
            button1.Text = "ÜRÜN EKLE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Segoe UI", 30F);
            button2.Location = new Point(635, 146);
            button2.Name = "button2";
            button2.Size = new Size(239, 129);
            button2.TabIndex = 1;
            button2.Text = "ÜRÜN GÜNCELLE";
            button2.UseVisualStyleBackColor = false;
            // 
            // yönetim
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1924, 1061);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "yönetim";
            Text = "yönetim";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
    }
}
namespace kafe_adisyon_uygulaması
{
    partial class masaekle_sil
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
            txtmasaid = new TextBox();
            txtmasaadı = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtmasaid
            // 
            txtmasaid.Location = new Point(114, 79);
            txtmasaid.Name = "txtmasaid";
            txtmasaid.Size = new Size(100, 23);
            txtmasaid.TabIndex = 0;
            // 
            // txtmasaadı
            // 
            txtmasaadı.Location = new Point(114, 142);
            txtmasaadı.Name = "txtmasaadı";
            txtmasaadı.Size = new Size(100, 23);
            txtmasaadı.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 79);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 2;
            label1.Text = "masaID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 145);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 3;
            label2.Text = "Masa Adı";
            // 
            // button1
            // 
            button1.Location = new Point(139, 220);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // masaekle_sil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtmasaadı);
            Controls.Add(txtmasaid);
            Name = "masaekle_sil";
            Text = "masaekle_sil";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtmasaid;
        private TextBox txtmasaadı;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}
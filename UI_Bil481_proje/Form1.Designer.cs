namespace UI_Bil481_proje
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            enlem1 = new TextBox();
            Continue = new Button();
            boylam1 = new TextBox();
            ucak_adi = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label4 = new Label();
            boylam2 = new TextBox();
            enlem2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(324, 55);
            label1.Name = "label1";
            label1.Size = new Size(488, 106);
            label1.TabIndex = 0;
            label1.Text = "Hoşgeldiniz";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(452, 271);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "Enlem";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(452, 315);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 2;
            label3.Text = "Boylam";
            // 
            // enlem1
            // 
            enlem1.Location = new Point(526, 267);
            enlem1.Margin = new Padding(3, 4, 3, 4);
            enlem1.Name = "enlem1";
            enlem1.Size = new Size(114, 27);
            enlem1.TabIndex = 3;
            enlem1.TextChanged += enlem_TextChanged;
            // 
            // Continue
            // 
            Continue.BackColor = Color.GreenYellow;
            Continue.BackgroundImageLayout = ImageLayout.Center;
            Continue.Location = new Point(726, 366);
            Continue.Margin = new Padding(3, 4, 3, 4);
            Continue.Name = "Continue";
            Continue.Size = new Size(86, 31);
            Continue.TabIndex = 4;
            Continue.Text = "Gönder";
            Continue.UseVisualStyleBackColor = false;
            Continue.Click += Continue_Click;
            // 
            // boylam1
            // 
            boylam1.Location = new Point(526, 311);
            boylam1.Margin = new Padding(3, 4, 3, 4);
            boylam1.Name = "boylam1";
            boylam1.Size = new Size(114, 27);
            boylam1.TabIndex = 5;
            // 
            // ucak_adi
            // 
            ucak_adi.Location = new Point(526, 214);
            ucak_adi.Margin = new Padding(3, 4, 3, 4);
            ucak_adi.Name = "ucak_adi";
            ucak_adi.Size = new Size(114, 27);
            ucak_adi.TabIndex = 6;
            ucak_adi.TextChanged += textBox3_TextChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(452, 218);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 8;
            label4.Text = "Uçak Adı";
            // 
            // boylam2
            // 
            boylam2.Location = new Point(698, 311);
            boylam2.Margin = new Padding(3, 4, 3, 4);
            boylam2.Name = "boylam2";
            boylam2.Size = new Size(114, 27);
            boylam2.TabIndex = 10;
            // 
            // enlem2
            // 
            enlem2.Location = new Point(698, 267);
            enlem2.Margin = new Padding(3, 4, 3, 4);
            enlem2.Name = "enlem2";
            enlem2.Size = new Size(114, 27);
            enlem2.TabIndex = 9;
            enlem2.TextChanged += textBox2_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = SystemColors.ActiveCaption;
            label5.ImageAlign = ContentAlignment.MiddleRight;
            label5.Location = new Point(649, 284);
            label5.Name = "label5";
            label5.Size = new Size(43, 60);
            label5.TabIndex = 11;
            label5.Text = "-";
            label5.TextAlign = ContentAlignment.TopCenter;
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.ForeColor = SystemColors.ActiveCaption;
            label6.ImageAlign = ContentAlignment.MiddleRight;
            label6.Location = new Point(649, 240);
            label6.Name = "label6";
            label6.Size = new Size(43, 60);
            label6.TabIndex = 12;
            label6.Text = "-";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1144, 515);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(boylam2);
            Controls.Add(enlem2);
            Controls.Add(label4);
            Controls.Add(ucak_adi);
            Controls.Add(boylam1);
            Controls.Add(Continue);
            Controls.Add(enlem1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "GIS UI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox enlem1;
        private Button Continue;
        private TextBox boylam1;
        private TextBox ucak_adi;
        private ContextMenuStrip contextMenuStrip1;
        private Label label4;
        private TextBox boylam2;
        private TextBox enlem2;
        private Label label5;
        private Label label6;
    }
}

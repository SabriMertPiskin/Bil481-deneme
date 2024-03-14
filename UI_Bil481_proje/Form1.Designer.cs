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
            enlem = new TextBox();
            Continue = new Button();
            boylam = new TextBox();
            ucak_adi = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label4 = new Label();
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
            // enlem
            // 
            enlem.Location = new Point(526, 267);
            enlem.Margin = new Padding(3, 4, 3, 4);
            enlem.Name = "enlem";
            enlem.Size = new Size(114, 27);
            enlem.TabIndex = 3;
            enlem.TextChanged += enlem_TextChanged;
            // 
            // Continue
            // 
            Continue.BackColor = Color.GreenYellow;
            Continue.BackgroundImageLayout = ImageLayout.Center;
            Continue.Location = new Point(641, 356);
            Continue.Margin = new Padding(3, 4, 3, 4);
            Continue.Name = "Continue";
            Continue.Size = new Size(86, 31);
            Continue.TabIndex = 4;
            Continue.Text = "Continue";
            Continue.UseVisualStyleBackColor = false;
            Continue.Click += Continue_Click;
            // 
            // boylam
            // 
            boylam.Location = new Point(526, 311);
            boylam.Margin = new Padding(3, 4, 3, 4);
            boylam.Name = "boylam";
            boylam.Size = new Size(114, 27);
            boylam.TabIndex = 5;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1144, 515);
            Controls.Add(label4);
            Controls.Add(ucak_adi);
            Controls.Add(boylam);
            Controls.Add(Continue);
            Controls.Add(enlem);
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
        private TextBox enlem;
        private Button Continue;
        private TextBox boylam;
        private TextBox ucak_adi;
        private ContextMenuStrip contextMenuStrip1;
        private Label label4;
    }
}

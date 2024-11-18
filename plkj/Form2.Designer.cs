namespace plkj
{
    partial class FrmI
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
            btnins = new Button();
            brnrtr = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            SuspendLayout();
            // 
            // btnins
            // 
            btnins.Location = new Point(145, 439);
            btnins.Name = "btnins";
            btnins.Size = new Size(153, 68);
            btnins.TabIndex = 0;
            btnins.Text = "S'inscrire";
            btnins.UseVisualStyleBackColor = true;
            // 
            // brnrtr
            // 
            brnrtr.Location = new Point(162, 543);
            brnrtr.Name = "brnrtr";
            brnrtr.Size = new Size(121, 46);
            brnrtr.TabIndex = 1;
            brnrtr.Text = "retour";
            brnrtr.UseVisualStyleBackColor = true;
            brnrtr.Click += brnrtr_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 48);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 2;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 208);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 3;
            label2.Text = "E-mail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 156);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 4;
            label3.Text = "Prenom";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 101);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 5;
            label4.Text = "Nom";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 271);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 6;
            label5.Text = "Mot de passe";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(54, 342);
            label6.Name = "label6";
            label6.Size = new Size(105, 20);
            label6.TabIndex = 7;
            label6.Text = "Carte bancaire";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(173, 48);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(184, 27);
            textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(173, 271);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(184, 27);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(173, 205);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(184, 27);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(173, 153);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(184, 27);
            textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(173, 98);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(184, 27);
            textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(173, 342);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(184, 27);
            textBox6.TabIndex = 13;
            // 
            // FrmI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Turquoise;
            ClientSize = new Size(474, 636);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(brnrtr);
            Controls.Add(btnins);
            Name = "FrmI";
            Text = "menu inscription";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnins;
        private Button brnrtr;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
    }
}
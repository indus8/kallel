namespace plkj
{
    partial class FrmC
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
            btncon = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // btncon
            // 
            btncon.Location = new Point(169, 230);
            btncon.Name = "btncon";
            btncon.Size = new Size(153, 49);
            btncon.TabIndex = 0;
            btncon.Text = "connecter";
            btncon.UseVisualStyleBackColor = true;
            btncon.Click += btncon_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 79);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 1;
            label1.Text = "login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 145);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 2;
            label2.Text = "mot de passe";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(198, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(166, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(198, 138);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(166, 27);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 322);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 5;
            label3.Text = "pas de compte?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(198, 322);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(75, 20);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "inscrire ici";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // FrmC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SpringGreen;
            ClientSize = new Size(523, 450);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btncon);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "FrmC";
            Text = "login menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncon;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private LinkLabel linkLabel1;
    }
}

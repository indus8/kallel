namespace plkj
{
    partial class Form3
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
            DGV = new DataGridView();
            txtrecher = new TextBox();
            btnrecher = new Button();
            ((System.ComponentModel.ISupportInitialize)DGV).BeginInit();
            SuspendLayout();
            // 
            // DGV
            // 
            DGV.AllowUserToAddRows = false;
            DGV.AllowUserToDeleteRows = false;
            DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV.Location = new Point(1, 125);
            DGV.Name = "DGV";
            DGV.ReadOnly = true;
            DGV.RowHeadersWidth = 51;
            DGV.Size = new Size(797, 262);
            DGV.TabIndex = 0;
            DGV.CellContentClick += DGV_CellContentClick;
            // 
            // txtrecher
            // 
            txtrecher.Location = new Point(78, 52);
            txtrecher.Name = "txtrecher";
            txtrecher.Size = new Size(222, 27);
            txtrecher.TabIndex = 1;
            // 
            // btnrecher
            // 
            btnrecher.Location = new Point(439, 52);
            btnrecher.Name = "btnrecher";
            btnrecher.Size = new Size(94, 29);
            btnrecher.TabIndex = 2;
            btnrecher.Text = "rechercher";
            btnrecher.UseVisualStyleBackColor = true;
            btnrecher.Click += btnrecher_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnrecher);
            Controls.Add(txtrecher);
            Controls.Add(DGV);
            Name = "Form3";
            Text = "recherche plats";
            ((System.ComponentModel.ISupportInitialize)DGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGV;
        private TextBox txtrecher;
        private Button btnrecher;
    }
}
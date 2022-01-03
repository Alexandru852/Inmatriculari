namespace Inmatriculari
{
    partial class AdaugaAsigurare
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
            this.TxtAsigurare = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSalveaza = new System.Windows.Forms.Button();
            this.RadioBtn12Luni = new System.Windows.Forms.RadioButton();
            this.RadioBtn6Luni = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtAsigurare
            // 
            this.TxtAsigurare.Location = new System.Drawing.Point(178, 126);
            this.TxtAsigurare.Name = "TxtAsigurare";
            this.TxtAsigurare.Size = new System.Drawing.Size(167, 22);
            this.TxtAsigurare.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data incepere asigurare";
            // 
            // BtnSalveaza
            // 
            this.BtnSalveaza.Location = new System.Drawing.Point(203, 217);
            this.BtnSalveaza.Name = "BtnSalveaza";
            this.BtnSalveaza.Size = new System.Drawing.Size(75, 23);
            this.BtnSalveaza.TabIndex = 2;
            this.BtnSalveaza.Text = "Salveaza";
            this.BtnSalveaza.UseVisualStyleBackColor = true;
            this.BtnSalveaza.Click += new System.EventHandler(this.BtnSalveaza_Click);
            // 
            // RadioBtn12Luni
            // 
            this.RadioBtn12Luni.AutoSize = true;
            this.RadioBtn12Luni.Location = new System.Drawing.Point(268, 165);
            this.RadioBtn12Luni.Name = "RadioBtn12Luni";
            this.RadioBtn12Luni.Size = new System.Drawing.Size(65, 20);
            this.RadioBtn12Luni.TabIndex = 3;
            this.RadioBtn12Luni.TabStop = true;
            this.RadioBtn12Luni.Text = "12 luni";
            this.RadioBtn12Luni.UseVisualStyleBackColor = true;
            // 
            // RadioBtn6Luni
            // 
            this.RadioBtn6Luni.AutoSize = true;
            this.RadioBtn6Luni.Location = new System.Drawing.Point(151, 165);
            this.RadioBtn6Luni.Name = "RadioBtn6Luni";
            this.RadioBtn6Luni.Size = new System.Drawing.Size(58, 20);
            this.RadioBtn6Luni.TabIndex = 4;
            this.RadioBtn6Luni.TabStop = true;
            this.RadioBtn6Luni.Text = "6 luni";
            this.RadioBtn6Luni.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Introduceti data sub forma Luna.Zi.An cu \".\" intre ele. \r\nExemplu: 01.03.2022\r\n";
            // 
            // AdaugaAsigurare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 395);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RadioBtn6Luni);
            this.Controls.Add(this.RadioBtn12Luni);
            this.Controls.Add(this.BtnSalveaza);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtAsigurare);
            this.Name = "AdaugaAsigurare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdaugaAsigurare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSalveaza;
        public System.Windows.Forms.TextBox TxtAsigurare;
        public System.Windows.Forms.RadioButton RadioBtn12Luni;
        public System.Windows.Forms.RadioButton RadioBtn6Luni;
        private System.Windows.Forms.Label label2;
    }
}
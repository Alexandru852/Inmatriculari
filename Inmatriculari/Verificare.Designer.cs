namespace Inmatriculari
{
    partial class Verificare
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
            this.BTNVerificare = new System.Windows.Forms.Button();
            this.TxtNumar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTNVerificare
            // 
            this.BTNVerificare.Location = new System.Drawing.Point(143, 110);
            this.BTNVerificare.Name = "BTNVerificare";
            this.BTNVerificare.Size = new System.Drawing.Size(75, 23);
            this.BTNVerificare.TabIndex = 0;
            this.BTNVerificare.Text = "Verifica";
            this.BTNVerificare.UseVisualStyleBackColor = true;
            this.BTNVerificare.Click += new System.EventHandler(this.BTNVerificare_Click);
            // 
            // TxtNumar
            // 
            this.TxtNumar.Location = new System.Drawing.Point(105, 72);
            this.TxtNumar.Name = "TxtNumar";
            this.TxtNumar.Size = new System.Drawing.Size(159, 22);
            this.TxtNumar.TabIndex = 1;
            // 
            // Verificare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 198);
            this.Controls.Add(this.TxtNumar);
            this.Controls.Add(this.BTNVerificare);
            this.Name = "Verificare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verificare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNVerificare;
        private System.Windows.Forms.TextBox TxtNumar;
    }
}


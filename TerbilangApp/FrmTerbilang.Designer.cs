namespace TerbilangApp
{
    partial class FrmTerbilang
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNominal = new System.Windows.Forms.TextBox();
            this.btnCek = new System.Windows.Forms.Button();
            this.tampil = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nominal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Terbilang";
            // 
            // txtNominal
            // 
            this.txtNominal.Location = new System.Drawing.Point(63, 31);
            this.txtNominal.Name = "txtNominal";
            this.txtNominal.Size = new System.Drawing.Size(124, 20);
            this.txtNominal.TabIndex = 2;
            this.txtNominal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCek
            // 
            this.btnCek.Location = new System.Drawing.Point(193, 29);
            this.btnCek.Name = "btnCek";
            this.btnCek.Size = new System.Drawing.Size(98, 23);
            this.btnCek.TabIndex = 3;
            this.btnCek.Text = "Cek Terbilang";
            this.btnCek.UseVisualStyleBackColor = true;
            this.btnCek.Click += new System.EventHandler(this.btnCek_Click);
            // 
            // tampil
            // 
            this.tampil.BackColor = System.Drawing.SystemColors.Menu;
            this.tampil.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tampil.FormattingEnabled = true;
            this.tampil.Location = new System.Drawing.Point(63, 79);
            this.tampil.Name = "tampil";
            this.tampil.Size = new System.Drawing.Size(477, 43);
            this.tampil.TabIndex = 4;
            // 
            // FrmTerbilang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 153);
            this.Controls.Add(this.tampil);
            this.Controls.Add(this.btnCek);
            this.Controls.Add(this.txtNominal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmTerbilang";
            this.Text = "Demo Terbilang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNominal;
        private System.Windows.Forms.Button btnCek;
        private System.Windows.Forms.ListBox tampil;
    }
}


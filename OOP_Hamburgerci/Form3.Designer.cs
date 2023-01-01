
namespace OOP_Hamburgerci
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
            this.grpEkstraMalzeme = new System.Windows.Forms.GroupBox();
            this.btnEkstraMalzemeKaydet = new System.Windows.Forms.Button();
            this.nmrEkstraMalzeme = new System.Windows.Forms.NumericUpDown();
            this.txtEkstraMalzeme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpEkstraMalzeme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrEkstraMalzeme)).BeginInit();
            this.SuspendLayout();
            // 
            // grpEkstraMalzeme
            // 
            this.grpEkstraMalzeme.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.grpEkstraMalzeme.Controls.Add(this.btnEkstraMalzemeKaydet);
            this.grpEkstraMalzeme.Controls.Add(this.nmrEkstraMalzeme);
            this.grpEkstraMalzeme.Controls.Add(this.txtEkstraMalzeme);
            this.grpEkstraMalzeme.Controls.Add(this.label2);
            this.grpEkstraMalzeme.Controls.Add(this.label1);
            this.grpEkstraMalzeme.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpEkstraMalzeme.Location = new System.Drawing.Point(12, 12);
            this.grpEkstraMalzeme.Name = "grpEkstraMalzeme";
            this.grpEkstraMalzeme.Size = new System.Drawing.Size(295, 157);
            this.grpEkstraMalzeme.TabIndex = 1;
            this.grpEkstraMalzeme.TabStop = false;
            this.grpEkstraMalzeme.Text = "EKSTRA MALZEME BİLGİLERİ";
            // 
            // btnEkstraMalzemeKaydet
            // 
            this.btnEkstraMalzemeKaydet.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEkstraMalzemeKaydet.Location = new System.Drawing.Point(13, 103);
            this.btnEkstraMalzemeKaydet.Name = "btnEkstraMalzemeKaydet";
            this.btnEkstraMalzemeKaydet.Size = new System.Drawing.Size(266, 34);
            this.btnEkstraMalzemeKaydet.TabIndex = 4;
            this.btnEkstraMalzemeKaydet.Text = "EKSTRA MALZEME  KAYDET";
            this.btnEkstraMalzemeKaydet.UseVisualStyleBackColor = false;
            this.btnEkstraMalzemeKaydet.Click += new System.EventHandler(this.btnEkstraMalzemeKaydet_Click);
            // 
            // nmrEkstraMalzeme
            // 
            this.nmrEkstraMalzeme.Location = new System.Drawing.Point(117, 67);
            this.nmrEkstraMalzeme.Name = "nmrEkstraMalzeme";
            this.nmrEkstraMalzeme.Size = new System.Drawing.Size(162, 22);
            this.nmrEkstraMalzeme.TabIndex = 3;
            // 
            // txtEkstraMalzeme
            // 
            this.txtEkstraMalzeme.Location = new System.Drawing.Point(117, 32);
            this.txtEkstraMalzeme.Multiline = true;
            this.txtEkstraMalzeme.Name = "txtEkstraMalzeme";
            this.txtEkstraMalzeme.Size = new System.Drawing.Size(162, 20);
            this.txtEkstraMalzeme.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "FİYATI:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "MALZEME  ADI:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 183);
            this.Controls.Add(this.grpEkstraMalzeme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form3";
            this.grpEkstraMalzeme.ResumeLayout(false);
            this.grpEkstraMalzeme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrEkstraMalzeme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEkstraMalzeme;
        private System.Windows.Forms.Button btnEkstraMalzemeKaydet;
        private System.Windows.Forms.NumericUpDown nmrEkstraMalzeme;
        private System.Windows.Forms.TextBox txtEkstraMalzeme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
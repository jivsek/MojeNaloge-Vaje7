namespace Proj1
{
    partial class Form1
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
            this.to_do = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_dodaj = new System.Windows.Forms.Button();
            this.btn_odstrani = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // to_do
            // 
            this.to_do.FormattingEnabled = true;
            this.to_do.Location = new System.Drawing.Point(17, 58);
            this.to_do.Name = "to_do";
            this.to_do.Size = new System.Drawing.Size(496, 364);
            this.to_do.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "TO DO";
            // 
            // btn_dodaj
            // 
            this.btn_dodaj.Location = new System.Drawing.Point(519, 431);
            this.btn_dodaj.Name = "btn_dodaj";
            this.btn_dodaj.Size = new System.Drawing.Size(90, 32);
            this.btn_dodaj.TabIndex = 2;
            this.btn_dodaj.Text = "Dodaj";
            this.btn_dodaj.UseVisualStyleBackColor = true;
            this.btn_dodaj.Click += new System.EventHandler(this.btn_dodaj_Click);
            // 
            // btn_odstrani
            // 
            this.btn_odstrani.Location = new System.Drawing.Point(519, 58);
            this.btn_odstrani.Name = "btn_odstrani";
            this.btn_odstrani.Size = new System.Drawing.Size(90, 32);
            this.btn_odstrani.TabIndex = 3;
            this.btn_odstrani.Text = "Izbriši";
            this.btn_odstrani.UseVisualStyleBackColor = true;
            this.btn_odstrani.Click += new System.EventHandler(this.btn_odstrani_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 431);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(496, 31);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 494);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_odstrani);
            this.Controls.Add(this.btn_dodaj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.to_do);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox to_do;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_dodaj;
        private System.Windows.Forms.Button btn_odstrani;
        private System.Windows.Forms.TextBox textBox1;
    }
}


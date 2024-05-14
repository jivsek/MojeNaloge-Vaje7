namespace Proj2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Pocisti = new System.Windows.Forms.Button();
            this.btn_Shrani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(560, 298);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // btn_Pocisti
            // 
            this.btn_Pocisti.Location = new System.Drawing.Point(13, 317);
            this.btn_Pocisti.Name = "btn_Pocisti";
            this.btn_Pocisti.Size = new System.Drawing.Size(92, 35);
            this.btn_Pocisti.TabIndex = 1;
            this.btn_Pocisti.Text = "Počisti";
            this.btn_Pocisti.UseVisualStyleBackColor = true;
            this.btn_Pocisti.Click += new System.EventHandler(this.btn_Pocisti_Click);
            // 
            // btn_Shrani
            // 
            this.btn_Shrani.Location = new System.Drawing.Point(481, 317);
            this.btn_Shrani.Name = "btn_Shrani";
            this.btn_Shrani.Size = new System.Drawing.Size(92, 35);
            this.btn_Shrani.TabIndex = 2;
            this.btn_Shrani.Text = "Shrani";
            this.btn_Shrani.UseVisualStyleBackColor = true;
            this.btn_Shrani.Click += new System.EventHandler(this.btn_Shrani_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 359);
            this.Controls.Add(this.btn_Shrani);
            this.Controls.Add(this.btn_Pocisti);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Pocisti;
        private System.Windows.Forms.Button btn_Shrani;
    }
}


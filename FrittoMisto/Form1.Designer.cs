namespace FrittoMisto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPoziv = new System.Windows.Forms.Button();
            this.btnNarudzba = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPoziv
            // 
            this.btnPoziv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(216)))), ((int)(((byte)(253)))));
            this.btnPoziv.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(216)))), ((int)(((byte)(253)))));
            this.btnPoziv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPoziv.Font = new System.Drawing.Font("Mistral", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPoziv.Location = new System.Drawing.Point(27, 92);
            this.btnPoziv.Name = "btnPoziv";
            this.btnPoziv.Size = new System.Drawing.Size(159, 43);
            this.btnPoziv.TabIndex = 0;
            this.btnPoziv.Text = "POZIV";
            this.btnPoziv.UseVisualStyleBackColor = false;
            this.btnPoziv.Click += new System.EventHandler(this.btnPoziv_Click);
            // 
            // btnNarudzba
            // 
            this.btnNarudzba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(216)))), ((int)(((byte)(253)))));
            this.btnNarudzba.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(216)))), ((int)(((byte)(253)))));
            this.btnNarudzba.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNarudzba.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNarudzba.Location = new System.Drawing.Point(27, 161);
            this.btnNarudzba.Name = "btnNarudzba";
            this.btnNarudzba.Size = new System.Drawing.Size(159, 43);
            this.btnNarudzba.TabIndex = 1;
            this.btnNarudzba.Text = "NARUDŽBA";
            this.btnNarudzba.UseVisualStyleBackColor = false;
            this.btnNarudzba.Click += new System.EventHandler(this.btnNarudzba_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, -38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(213, 228);
            this.Controls.Add(this.btnNarudzba);
            this.Controls.Add(this.btnPoziv);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "FrittoMisto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPoziv;
        private System.Windows.Forms.Button btnNarudzba;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


namespace FrittoMisto
{
    partial class Narudzba
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Narudzba));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCustom = new System.Windows.Forms.Button();
            this.btnMeni = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCustom
            // 
            this.btnCustom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(216)))), ((int)(((byte)(253)))));
            this.btnCustom.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(216)))), ((int)(((byte)(253)))));
            this.btnCustom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCustom.Font = new System.Drawing.Font("Mistral", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCustom.Location = new System.Drawing.Point(27, 93);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(159, 43);
            this.btnCustom.TabIndex = 1;
            this.btnCustom.Text = "CUSTOM";
            this.btnCustom.UseVisualStyleBackColor = false;
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // btnMeni
            // 
            this.btnMeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(216)))), ((int)(((byte)(253)))));
            this.btnMeni.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(216)))), ((int)(((byte)(253)))));
            this.btnMeni.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMeni.Font = new System.Drawing.Font("Mistral", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMeni.Location = new System.Drawing.Point(27, 164);
            this.btnMeni.Name = "btnMeni";
            this.btnMeni.Size = new System.Drawing.Size(159, 43);
            this.btnMeni.TabIndex = 2;
            this.btnMeni.Text = "MENI";
            this.btnMeni.UseVisualStyleBackColor = false;
            this.btnMeni.Click += new System.EventHandler(this.btnMeni_Click);
            // 
            // Narudzba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(215, 232);
            this.Controls.Add(this.btnMeni);
            this.Controls.Add(this.btnCustom);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Narudzba";
            this.Text = "Narudzba";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCustom;
        private System.Windows.Forms.Button btnMeni;
    }
}
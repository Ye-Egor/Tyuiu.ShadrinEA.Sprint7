
namespace Tyuiu.ShadrinEA.Sprint7.Project.V10
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonEnter_SEA = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEnter_SEA
            // 
            this.buttonEnter_SEA.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonEnter_SEA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEnter_SEA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonEnter_SEA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEnter_SEA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEnter_SEA.Location = new System.Drawing.Point(0, 443);
            this.buttonEnter_SEA.Name = "buttonEnter_SEA";
            this.buttonEnter_SEA.Size = new System.Drawing.Size(799, 56);
            this.buttonEnter_SEA.TabIndex = 0;
            this.buttonEnter_SEA.Text = "Перейти в каталог";
            this.buttonEnter_SEA.UseVisualStyleBackColor = false;
            this.buttonEnter_SEA.Click += new System.EventHandler(this.buttonEnter_SEA_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 443);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(799, 499);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonEnter_SEA);
            this.MinimumSize = new System.Drawing.Size(546, 361);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEnter_SEA;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
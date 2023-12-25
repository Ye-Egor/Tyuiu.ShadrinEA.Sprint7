
namespace Tyuiu.ShadrinEA.Sprint7.Project.V10
{
    partial class FormBasket
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
            this.richTextBox_SEA = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxChange_SEA = new System.Windows.Forms.GroupBox();
            this.textBoxQuantity_SEA = new System.Windows.Forms.TextBox();
            this.textBoxNumber_SEA = new System.Windows.Forms.TextBox();
            this.buttonChange_SEA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNumber_SEA = new System.Windows.Forms.Label();
            this.buttonArrange_SEA = new System.Windows.Forms.Button();
            this.buttonBack_SEA = new System.Windows.Forms.Button();
            this.buttonClose_SEA = new System.Windows.Forms.Button();
            this.buttonShowFile_SEA = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBoxChange_SEA.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox_SEA
            // 
            this.richTextBox_SEA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_SEA.Location = new System.Drawing.Point(0, 0);
            this.richTextBox_SEA.Name = "richTextBox_SEA";
            this.richTextBox_SEA.Size = new System.Drawing.Size(1050, 573);
            this.richTextBox_SEA.TabIndex = 0;
            this.richTextBox_SEA.Text = "";
            this.richTextBox_SEA.TextChanged += new System.EventHandler(this.richTextBox_SEA_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.groupBoxChange_SEA);
            this.panel1.Controls.Add(this.buttonArrange_SEA);
            this.panel1.Controls.Add(this.buttonBack_SEA);
            this.panel1.Controls.Add(this.buttonClose_SEA);
            this.panel1.Controls.Add(this.buttonShowFile_SEA);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(791, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 573);
            this.panel1.TabIndex = 1;
            // 
            // groupBoxChange_SEA
            // 
            this.groupBoxChange_SEA.Controls.Add(this.textBoxQuantity_SEA);
            this.groupBoxChange_SEA.Controls.Add(this.textBoxNumber_SEA);
            this.groupBoxChange_SEA.Controls.Add(this.buttonChange_SEA);
            this.groupBoxChange_SEA.Controls.Add(this.label1);
            this.groupBoxChange_SEA.Controls.Add(this.labelNumber_SEA);
            this.groupBoxChange_SEA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxChange_SEA.ForeColor = System.Drawing.Color.White;
            this.groupBoxChange_SEA.Location = new System.Drawing.Point(3, 189);
            this.groupBoxChange_SEA.Name = "groupBoxChange_SEA";
            this.groupBoxChange_SEA.Size = new System.Drawing.Size(252, 121);
            this.groupBoxChange_SEA.TabIndex = 7;
            this.groupBoxChange_SEA.TabStop = false;
            this.groupBoxChange_SEA.Text = "Изменить заказ";
            // 
            // textBoxQuantity_SEA
            // 
            this.textBoxQuantity_SEA.Location = new System.Drawing.Point(112, 51);
            this.textBoxQuantity_SEA.Name = "textBoxQuantity_SEA";
            this.textBoxQuantity_SEA.Size = new System.Drawing.Size(75, 24);
            this.textBoxQuantity_SEA.TabIndex = 10;
            // 
            // textBoxNumber_SEA
            // 
            this.textBoxNumber_SEA.Location = new System.Drawing.Point(187, 26);
            this.textBoxNumber_SEA.Name = "textBoxNumber_SEA";
            this.textBoxNumber_SEA.Size = new System.Drawing.Size(59, 24);
            this.textBoxNumber_SEA.TabIndex = 9;
            // 
            // buttonChange_SEA
            // 
            this.buttonChange_SEA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChange_SEA.ForeColor = System.Drawing.Color.Black;
            this.buttonChange_SEA.Location = new System.Drawing.Point(9, 88);
            this.buttonChange_SEA.Name = "buttonChange_SEA";
            this.buttonChange_SEA.Size = new System.Drawing.Size(235, 26);
            this.buttonChange_SEA.TabIndex = 8;
            this.buttonChange_SEA.Text = "Изменить";
            this.buttonChange_SEA.UseVisualStyleBackColor = true;
            this.buttonChange_SEA.Click += new System.EventHandler(this.buttonChange_SEA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Количество:";
            // 
            // labelNumber_SEA
            // 
            this.labelNumber_SEA.AutoSize = true;
            this.labelNumber_SEA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumber_SEA.ForeColor = System.Drawing.Color.White;
            this.labelNumber_SEA.Location = new System.Drawing.Point(6, 31);
            this.labelNumber_SEA.Name = "labelNumber_SEA";
            this.labelNumber_SEA.Size = new System.Drawing.Size(182, 16);
            this.labelNumber_SEA.TabIndex = 5;
            this.labelNumber_SEA.Text = "Введите номер товара:";
            // 
            // buttonArrange_SEA
            // 
            this.buttonArrange_SEA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonArrange_SEA.Location = new System.Drawing.Point(3, 112);
            this.buttonArrange_SEA.Name = "buttonArrange_SEA";
            this.buttonArrange_SEA.Size = new System.Drawing.Size(253, 59);
            this.buttonArrange_SEA.TabIndex = 6;
            this.buttonArrange_SEA.Text = "Все верно.\r\nоформить заказ";
            this.buttonArrange_SEA.UseVisualStyleBackColor = false;
            this.buttonArrange_SEA.Click += new System.EventHandler(this.buttonArrange_SEA_Click);
            // 
            // buttonBack_SEA
            // 
            this.buttonBack_SEA.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonBack_SEA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack_SEA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBack_SEA.Location = new System.Drawing.Point(196, 32);
            this.buttonBack_SEA.Name = "buttonBack_SEA";
            this.buttonBack_SEA.Size = new System.Drawing.Size(60, 30);
            this.buttonBack_SEA.TabIndex = 5;
            this.buttonBack_SEA.Text = "Назад";
            this.buttonBack_SEA.UseVisualStyleBackColor = false;
            this.buttonBack_SEA.Click += new System.EventHandler(this.buttonBack_SEA_Click);
            // 
            // buttonClose_SEA
            // 
            this.buttonClose_SEA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonClose_SEA.Cursor = System.Windows.Forms.Cursors.No;
            this.buttonClose_SEA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClose_SEA.Location = new System.Drawing.Point(196, 3);
            this.buttonClose_SEA.Name = "buttonClose_SEA";
            this.buttonClose_SEA.Size = new System.Drawing.Size(60, 23);
            this.buttonClose_SEA.TabIndex = 4;
            this.buttonClose_SEA.Text = "закрыть";
            this.buttonClose_SEA.UseVisualStyleBackColor = false;
            this.buttonClose_SEA.Click += new System.EventHandler(this.buttonClose_SEA_Click);
            // 
            // buttonShowFile_SEA
            // 
            this.buttonShowFile_SEA.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.buttonShowFile_SEA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShowFile_SEA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonShowFile_SEA.Location = new System.Drawing.Point(3, 3);
            this.buttonShowFile_SEA.Name = "buttonShowFile_SEA";
            this.buttonShowFile_SEA.Size = new System.Drawing.Size(187, 59);
            this.buttonShowFile_SEA.TabIndex = 0;
            this.buttonShowFile_SEA.Text = "Показать";
            this.buttonShowFile_SEA.UseVisualStyleBackColor = false;
            this.buttonShowFile_SEA.Click += new System.EventHandler(this.buttonShowFile_SEA_Click_1);
            // 
            // FormBasket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 573);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox_SEA);
            this.Name = "FormBasket";
            this.Text = "FormBasket";
            this.panel1.ResumeLayout(false);
            this.groupBoxChange_SEA.ResumeLayout(false);
            this.groupBoxChange_SEA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_SEA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonShowFile_SEA;
        private System.Windows.Forms.Button buttonBack_SEA;
        private System.Windows.Forms.Button buttonClose_SEA;
        private System.Windows.Forms.GroupBox groupBoxChange_SEA;
        private System.Windows.Forms.Button buttonArrange_SEA;
        private System.Windows.Forms.TextBox textBoxQuantity_SEA;
        private System.Windows.Forms.TextBox textBoxNumber_SEA;
        private System.Windows.Forms.Button buttonChange_SEA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNumber_SEA;
    }
}
﻿namespace TaskFormApp
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
            this.BtnReadFile = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BtnCounter = new System.Windows.Forms.Button();
            this.textBoxCounter = new System.Windows.Forms.TextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // BtnReadFile
            // 
            this.BtnReadFile.Location = new System.Drawing.Point(22, 25);
            this.BtnReadFile.Name = "BtnReadFile";
            this.BtnReadFile.Size = new System.Drawing.Size(75, 23);
            this.BtnReadFile.TabIndex = 0;
            this.BtnReadFile.Text = "Dosya Oku";
            this.BtnReadFile.UseVisualStyleBackColor = true;
            this.BtnReadFile.Click += new System.EventHandler(this.BtnReadFile_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(22, 81);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(183, 180);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // BtnCounter
            // 
            this.BtnCounter.Location = new System.Drawing.Point(251, 25);
            this.BtnCounter.Name = "BtnCounter";
            this.BtnCounter.Size = new System.Drawing.Size(75, 23);
            this.BtnCounter.TabIndex = 2;
            this.BtnCounter.Text = "Sayaç arttır";
            this.BtnCounter.UseVisualStyleBackColor = true;
            this.BtnCounter.Click += new System.EventHandler(this.BtnCounter_Click);
            // 
            // textBoxCounter
            // 
            this.textBoxCounter.Location = new System.Drawing.Point(251, 81);
            this.textBoxCounter.Name = "textBoxCounter";
            this.textBoxCounter.Size = new System.Drawing.Size(100, 20);
            this.textBoxCounter.TabIndex = 3;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(533, 81);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(196, 180);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.textBoxCounter);
            this.Controls.Add(this.BtnCounter);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.BtnReadFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnReadFile;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button BtnCounter;
        private System.Windows.Forms.TextBox textBoxCounter;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}

﻿
namespace ClientProxyForm_P5_115
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonHasil = new System.Windows.Forms.Button();
            this.labelPenjumlahan = new System.Windows.Forms.Label();
            this.labelPengurangan = new System.Windows.Forms.Label();
            this.labelPerkalian = new System.Windows.Forms.Label();
            this.labelPembagian = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Angka 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Angka 2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 153);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hasil Penjumlahan : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hasil Pengurangan :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Hasil Perkalian :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Hasil Pembagian :";
            // 
            // buttonHasil
            // 
            this.buttonHasil.Location = new System.Drawing.Point(142, 213);
            this.buttonHasil.Name = "buttonHasil";
            this.buttonHasil.Size = new System.Drawing.Size(75, 23);
            this.buttonHasil.TabIndex = 8;
            this.buttonHasil.Text = "Hasil";
            this.buttonHasil.UseVisualStyleBackColor = true;
            this.buttonHasil.Click += new System.EventHandler(this.buttonHasil_Click);
            // 
            // labelPenjumlahan
            // 
            this.labelPenjumlahan.AutoSize = true;
            this.labelPenjumlahan.Location = new System.Drawing.Point(368, 87);
            this.labelPenjumlahan.Name = "labelPenjumlahan";
            this.labelPenjumlahan.Size = new System.Drawing.Size(0, 13);
            this.labelPenjumlahan.TabIndex = 9;
            // 
            // labelPengurangan
            // 
            this.labelPengurangan.AutoSize = true;
            this.labelPengurangan.Location = new System.Drawing.Point(368, 123);
            this.labelPengurangan.Name = "labelPengurangan";
            this.labelPengurangan.Size = new System.Drawing.Size(0, 13);
            this.labelPengurangan.TabIndex = 10;
            // 
            // labelPerkalian
            // 
            this.labelPerkalian.AutoSize = true;
            this.labelPerkalian.Location = new System.Drawing.Point(371, 159);
            this.labelPerkalian.Name = "labelPerkalian";
            this.labelPerkalian.Size = new System.Drawing.Size(0, 13);
            this.labelPerkalian.TabIndex = 11;
            // 
            // labelPembagian
            // 
            this.labelPembagian.AutoSize = true;
            this.labelPembagian.Location = new System.Drawing.Point(368, 194);
            this.labelPembagian.Name = "labelPembagian";
            this.labelPembagian.Size = new System.Drawing.Size(0, 13);
            this.labelPembagian.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 327);
            this.Controls.Add(this.labelPembagian);
            this.Controls.Add(this.labelPerkalian);
            this.Controls.Add(this.labelPengurangan);
            this.Controls.Add(this.labelPenjumlahan);
            this.Controls.Add(this.buttonHasil);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonHasil;
        private System.Windows.Forms.Label labelPenjumlahan;
        private System.Windows.Forms.Label labelPengurangan;
        private System.Windows.Forms.Label labelPerkalian;
        private System.Windows.Forms.Label labelPembagian;
    }
}


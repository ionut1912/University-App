﻿namespace FacultateUI
{
    partial class AdaugareCursuri
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodCurs = new System.Windows.Forms.TextBox();
            this.txtNrCredite = new System.Windows.Forms.TextBox();
            this.txtNumeCurs = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CodCurs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NumeCurs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NrCredite";
            // 
            // txtCodCurs
            // 
            this.txtCodCurs.Location = new System.Drawing.Point(118, 50);
            this.txtCodCurs.Name = "txtCodCurs";
            this.txtCodCurs.Size = new System.Drawing.Size(100, 20);
            this.txtCodCurs.TabIndex = 1;
            // 
            // txtNrCredite
            // 
            this.txtNrCredite.Location = new System.Drawing.Point(118, 111);
            this.txtNrCredite.Name = "txtNrCredite";
            this.txtNrCredite.Size = new System.Drawing.Size(100, 20);
            this.txtNrCredite.TabIndex = 3;
            this.txtNrCredite.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtNumeCurs
            // 
            this.txtNumeCurs.Location = new System.Drawing.Point(118, 80);
            this.txtNumeCurs.Name = "txtNumeCurs";
            this.txtNumeCurs.Size = new System.Drawing.Size(100, 20);
            this.txtNumeCurs.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Adaugare Curs";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(258, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Export Xml";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AdaugareCursuri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FacultateUI.Properties.Resources.descărcare;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNumeCurs);
            this.Controls.Add(this.txtNrCredite);
            this.Controls.Add(this.txtCodCurs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdaugareCursuri";
            this.Text = "AdaugareCursuri";
            this.Load += new System.EventHandler(this.AdaugareCursuri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodCurs;
        private System.Windows.Forms.TextBox txtNrCredite;
        private System.Windows.Forms.TextBox txtNumeCurs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
﻿namespace HarfSayiyaCevirme
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
      this.txtMetin = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.lblSonuc = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // txtMetin
      // 
      this.txtMetin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.txtMetin.Location = new System.Drawing.Point(393, 116);
      this.txtMetin.Name = "txtMetin";
      this.txtMetin.Size = new System.Drawing.Size(241, 30);
      this.txtMetin.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.label1.Location = new System.Drawing.Point(250, 119);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(119, 25);
      this.label1.TabIndex = 1;
      this.label1.Text = "Metni Giriniz";
      // 
      // lblSonuc
      // 
      this.lblSonuc.AutoSize = true;
      this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.lblSonuc.Location = new System.Drawing.Point(434, 215);
      this.lblSonuc.Name = "lblSonuc";
      this.lblSonuc.Size = new System.Drawing.Size(64, 25);
      this.lblSonuc.TabIndex = 2;
      this.lblSonuc.Text = "label2";
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
      this.button1.Location = new System.Drawing.Point(404, 152);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(136, 39);
      this.button1.TabIndex = 3;
      this.button1.Text = "Hesapla";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.lblSonuc);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtMetin);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtMetin;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lblSonuc;
    private System.Windows.Forms.Button button1;
  }
}


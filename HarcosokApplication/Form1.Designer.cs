﻿namespace HarcosokApplication
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
			this.harcosNeveTextBox = new System.Windows.Forms.TextBox();
			this.letrehozasButton = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.hasznaloComboBox = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.kepessegNeveTextBox = new System.Windows.Forms.TextBox();
			this.hozzaadButton = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.leirasTextBox = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.torlesButton = new System.Windows.Forms.Button();
			this.modositButton = new System.Windows.Forms.Button();
			this.harcosokListBox = new System.Windows.Forms.ListBox();
			this.kepessegekListBox = new System.Windows.Forms.ListBox();
			this.kepessegekLeirasaTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Harcos létrehozása:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Név:";
			// 
			// harcosNeveTextBox
			// 
			this.harcosNeveTextBox.Location = new System.Drawing.Point(49, 32);
			this.harcosNeveTextBox.Name = "harcosNeveTextBox";
			this.harcosNeveTextBox.Size = new System.Drawing.Size(147, 20);
			this.harcosNeveTextBox.TabIndex = 2;
			// 
			// letrehozasButton
			// 
			this.letrehozasButton.Location = new System.Drawing.Point(238, 32);
			this.letrehozasButton.Name = "letrehozasButton";
			this.letrehozasButton.Size = new System.Drawing.Size(75, 23);
			this.letrehozasButton.TabIndex = 3;
			this.letrehozasButton.Text = "Létrehozás";
			this.letrehozasButton.UseVisualStyleBackColor = true;
			this.letrehozasButton.Click += new System.EventHandler(this.letrehozasButton_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(577, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "_________________________________________________________________________________" +
    "______________";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 93);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(117, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "Képesség hozzáadása:";
			// 
			// hasznaloComboBox
			// 
			this.hasznaloComboBox.FormattingEnabled = true;
			this.hasznaloComboBox.Location = new System.Drawing.Point(89, 127);
			this.hasznaloComboBox.Name = "hasznaloComboBox";
			this.hasznaloComboBox.Size = new System.Drawing.Size(147, 21);
			this.hasznaloComboBox.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(13, 130);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(54, 13);
			this.label5.TabIndex = 7;
			this.label5.Text = "Használó:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(13, 175);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(57, 13);
			this.label6.TabIndex = 8;
			this.label6.Text = "Képesség:";
			// 
			// kepessegNeveTextBox
			// 
			this.kepessegNeveTextBox.Location = new System.Drawing.Point(89, 172);
			this.kepessegNeveTextBox.Name = "kepessegNeveTextBox";
			this.kepessegNeveTextBox.Size = new System.Drawing.Size(147, 20);
			this.kepessegNeveTextBox.TabIndex = 9;
			// 
			// hozzaadButton
			// 
			this.hozzaadButton.Location = new System.Drawing.Point(16, 210);
			this.hozzaadButton.Name = "hozzaadButton";
			this.hozzaadButton.Size = new System.Drawing.Size(74, 23);
			this.hozzaadButton.TabIndex = 10;
			this.hozzaadButton.Text = "Hozzáad";
			this.hozzaadButton.UseVisualStyleBackColor = true;
			this.hozzaadButton.Click += new System.EventHandler(this.hozzaadButton_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(277, 110);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(40, 13);
			this.label7.TabIndex = 11;
			this.label7.Text = "Leírás:";
			// 
			// leirasTextBox
			// 
			this.leirasTextBox.Location = new System.Drawing.Point(280, 127);
			this.leirasTextBox.Multiline = true;
			this.leirasTextBox.Name = "leirasTextBox";
			this.leirasTextBox.Size = new System.Drawing.Size(282, 71);
			this.leirasTextBox.TabIndex = 12;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(10, 253);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(583, 13);
			this.label8.TabIndex = 13;
			this.label8.Text = "_________________________________________________________________________________" +
    "_______________";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(16, 287);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(56, 13);
			this.label9.TabIndex = 14;
			this.label9.Text = "Harcosok:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(171, 287);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(65, 13);
			this.label10.TabIndex = 15;
			this.label10.Text = "Képességei:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(326, 287);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(92, 13);
			this.label11.TabIndex = 16;
			this.label11.Text = "Képesség leírása:";
			// 
			// torlesButton
			// 
			this.torlesButton.Location = new System.Drawing.Point(174, 538);
			this.torlesButton.Name = "torlesButton";
			this.torlesButton.Size = new System.Drawing.Size(75, 23);
			this.torlesButton.TabIndex = 17;
			this.torlesButton.Text = "Törlés";
			this.torlesButton.UseVisualStyleBackColor = true;
			this.torlesButton.Click += new System.EventHandler(this.torlesButton_Click);
			// 
			// modositButton
			// 
			this.modositButton.Location = new System.Drawing.Point(487, 432);
			this.modositButton.Name = "modositButton";
			this.modositButton.Size = new System.Drawing.Size(75, 23);
			this.modositButton.TabIndex = 18;
			this.modositButton.Text = "Módosít";
			this.modositButton.UseVisualStyleBackColor = true;
			this.modositButton.Click += new System.EventHandler(this.modositButton_Click);
			// 
			// harcosokListBox
			// 
			this.harcosokListBox.FormattingEnabled = true;
			this.harcosokListBox.Location = new System.Drawing.Point(16, 315);
			this.harcosokListBox.Name = "harcosokListBox";
			this.harcosokListBox.Size = new System.Drawing.Size(114, 199);
			this.harcosokListBox.TabIndex = 19;
			// 
			// kepessegekListBox
			// 
			this.kepessegekListBox.FormattingEnabled = true;
			this.kepessegekListBox.Location = new System.Drawing.Point(174, 315);
			this.kepessegekListBox.Name = "kepessegekListBox";
			this.kepessegekListBox.Size = new System.Drawing.Size(116, 199);
			this.kepessegekListBox.TabIndex = 20;
			// 
			// kepessegekLeirasaTextBox
			// 
			this.kepessegekLeirasaTextBox.Location = new System.Drawing.Point(329, 315);
			this.kepessegekLeirasaTextBox.Multiline = true;
			this.kepessegekLeirasaTextBox.Name = "kepessegekLeirasaTextBox";
			this.kepessegekLeirasaTextBox.Size = new System.Drawing.Size(228, 98);
			this.kepessegekLeirasaTextBox.TabIndex = 21;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(599, 573);
			this.Controls.Add(this.kepessegekLeirasaTextBox);
			this.Controls.Add(this.kepessegekListBox);
			this.Controls.Add(this.harcosokListBox);
			this.Controls.Add(this.modositButton);
			this.Controls.Add(this.torlesButton);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.leirasTextBox);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.hozzaadButton);
			this.Controls.Add(this.kepessegNeveTextBox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.hasznaloComboBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.letrehozasButton);
			this.Controls.Add(this.harcosNeveTextBox);
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
		private System.Windows.Forms.TextBox harcosNeveTextBox;
		private System.Windows.Forms.Button letrehozasButton;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox hasznaloComboBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox kepessegNeveTextBox;
		private System.Windows.Forms.Button hozzaadButton;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox leirasTextBox;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button torlesButton;
		private System.Windows.Forms.Button modositButton;
		private System.Windows.Forms.ListBox harcosokListBox;
		private System.Windows.Forms.ListBox kepessegekListBox;
		private System.Windows.Forms.TextBox kepessegekLeirasaTextBox;
	}
}


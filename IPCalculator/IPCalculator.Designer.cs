using System;

namespace IPCalculator
{
	partial class IPCalculator
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
			this.IPBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.IPBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.IPBox3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.IPBox4 = new System.Windows.Forms.TextBox();
			this.lblIPBin1 = new System.Windows.Forms.Label();
			this.lblIPBin2 = new System.Windows.Forms.Label();
			this.lblIPBin3 = new System.Windows.Forms.Label();
			this.lblIPBin4 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cbPreficsMask = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.MaskBox4 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.MaskBox3 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.MaskBox2 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.MaskBox1 = new System.Windows.Forms.TextBox();
			this.lblMaskBin4 = new System.Windows.Forms.Label();
			this.lblMaskBin3 = new System.Windows.Forms.Label();
			this.lblMaskBin2 = new System.Windows.Forms.Label();
			this.lblMaskBin1 = new System.Windows.Forms.Label();
			this.btnNetAddres = new System.Windows.Forms.Button();
			//this.SuspendLayout();
			// 
			// IPBox1
			// 
			this.IPBox1.Location = new System.Drawing.Point(12, 74);
			this.IPBox1.MaxLength = 3;
			this.IPBox1.Name = "IPBox1";
			this.IPBox1.Size = new System.Drawing.Size(26, 20);
			this.IPBox1.TabIndex = 0;
			this.IPBox1.TextChanged += new System.EventHandler(this.AllIPtb_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(44, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(22, 31);
			this.label1.TabIndex = 1;
			this.label1.Text = ".";
			// 
			// IPBox2
			// 
			this.IPBox2.Location = new System.Drawing.Point(72, 73);
			this.IPBox2.MaxLength = 3;
			this.IPBox2.Name = "IPBox2";
			this.IPBox2.Size = new System.Drawing.Size(26, 20);
			this.IPBox2.TabIndex = 2;
			this.IPBox2.TextChanged += new System.EventHandler(this.AllIPtb_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(104, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(22, 31);
			this.label2.TabIndex = 3;
			this.label2.Text = ".";
			// 
			// IPBox3
			// 
			this.IPBox3.Location = new System.Drawing.Point(132, 73);
			this.IPBox3.MaxLength = 3;
			this.IPBox3.Name = "IPBox3";
			this.IPBox3.Size = new System.Drawing.Size(26, 20);
			this.IPBox3.TabIndex = 4;
			this.IPBox3.TextChanged += new System.EventHandler(this.AllIPtb_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(164, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(22, 31);
			this.label3.TabIndex = 5;
			this.label3.Text = ".";
			// 
			// IPBox4
			// 
			this.IPBox4.Location = new System.Drawing.Point(192, 73);
			this.IPBox4.MaxLength = 3;
			this.IPBox4.Name = "IPBox4";
			this.IPBox4.Size = new System.Drawing.Size(26, 20);
			this.IPBox4.TabIndex = 6;
			this.IPBox4.TextChanged += new System.EventHandler(this.AllIPtb_TextChanged);
			// 
			// lblIPBin1
			// 
			this.lblIPBin1.AutoSize = true;
			this.lblIPBin1.Location = new System.Drawing.Point(13, 196);
			this.lblIPBin1.Name = "lblIPBin1";
			this.lblIPBin1.Size = new System.Drawing.Size(25, 13);
			this.lblIPBin1.TabIndex = 7;
			this.lblIPBin1.Text = "123";
			// 
			// lblIPBin2
			// 
			this.lblIPBin2.AutoSize = true;
			this.lblIPBin2.Location = new System.Drawing.Point(338, 196);
			this.lblIPBin2.Name = "lblIPBin2";
			this.lblIPBin2.Size = new System.Drawing.Size(25, 13);
			this.lblIPBin2.TabIndex = 8;
			this.lblIPBin2.Text = "123";
			// 
			// lblIPBin3
			// 
			this.lblIPBin3.AutoSize = true;
			this.lblIPBin3.Location = new System.Drawing.Point(566, 196);
			this.lblIPBin3.Name = "lblIPBin3";
			this.lblIPBin3.Size = new System.Drawing.Size(25, 13);
			this.lblIPBin3.TabIndex = 9;
			this.lblIPBin3.Text = "123";
			// 
			// lblIPBin4
			// 
			this.lblIPBin4.AutoSize = true;
			this.lblIPBin4.Location = new System.Drawing.Point(774, 196);
			this.lblIPBin4.Name = "lblIPBin4";
			this.lblIPBin4.Size = new System.Drawing.Size(25, 13);
			this.lblIPBin4.TabIndex = 10;
			this.lblIPBin4.Text = "123";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(7, 37);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(91, 25);
			this.label4.TabIndex = 11;
			this.label4.Text = "Type IP:";
			// 
			// cbPreficsMask
			// 
			this.cbPreficsMask.AutoSize = true;
			this.cbPreficsMask.Location = new System.Drawing.Point(16, 243);
			this.cbPreficsMask.Name = "cbPreficsMask";
			this.cbPreficsMask.Size = new System.Drawing.Size(80, 17);
			this.cbPreficsMask.TabIndex = 12;
			this.cbPreficsMask.Text = "checkBox1";
			this.cbPreficsMask.UseVisualStyleBackColor = true;
			this.cbPreficsMask.CheckedChanged += new System.EventHandler(this.cbPreficsMask_CheckedChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(13, 267);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(124, 25);
			this.label5.TabIndex = 13;
			this.label5.Text = "Type Mask:";
			// 
			// MaskBox4
			// 
			this.MaskBox4.Location = new System.Drawing.Point(198, 305);
			this.MaskBox4.MaxLength = 3;
			this.MaskBox4.Name = "MaskBox4";
			this.MaskBox4.Size = new System.Drawing.Size(26, 20);
			this.MaskBox4.TabIndex = 20;
			this.MaskBox4.TextChanged += new System.EventHandler(this.AllMaskbox_TextChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(170, 296);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(22, 31);
			this.label6.TabIndex = 19;
			this.label6.Text = ".";
			// 
			// MaskBox3
			// 
			this.MaskBox3.Location = new System.Drawing.Point(138, 305);
			this.MaskBox3.MaxLength = 3;
			this.MaskBox3.Name = "MaskBox3";
			this.MaskBox3.Size = new System.Drawing.Size(26, 20);
			this.MaskBox3.TabIndex = 18;
			this.MaskBox3.TextChanged += new System.EventHandler(this.AllMaskbox_TextChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(110, 295);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(22, 31);
			this.label7.TabIndex = 17;
			this.label7.Text = ".";
			// 
			// MaskBox2
			// 
			this.MaskBox2.Location = new System.Drawing.Point(78, 305);
			this.MaskBox2.MaxLength = 3;
			this.MaskBox2.Name = "MaskBox2";
			this.MaskBox2.Size = new System.Drawing.Size(26, 20);
			this.MaskBox2.TabIndex = 16;
			this.MaskBox2.TextChanged += new System.EventHandler(this.AllMaskbox_TextChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.Location = new System.Drawing.Point(50, 294);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(22, 31);
			this.label8.TabIndex = 15;
			this.label8.Text = ".";
			// 
			// MaskBox1
			// 
			this.MaskBox1.Location = new System.Drawing.Point(18, 306);
			this.MaskBox1.MaxLength = 3;
			this.MaskBox1.Name = "MaskBox1";
			this.MaskBox1.Size = new System.Drawing.Size(26, 20);
			this.MaskBox1.TabIndex = 14;
			this.MaskBox1.TextChanged += new System.EventHandler(this.AllMaskbox_TextChanged);
			// 
			// lblMaskBin4
			// 
			this.lblMaskBin4.AutoSize = true;
			this.lblMaskBin4.Location = new System.Drawing.Point(774, 374);
			this.lblMaskBin4.Name = "lblMaskBin4";
			this.lblMaskBin4.Size = new System.Drawing.Size(25, 13);
			this.lblMaskBin4.TabIndex = 24;
			this.lblMaskBin4.Text = "123";
			// 
			// lblMaskBin3
			// 
			this.lblMaskBin3.AutoSize = true;
			this.lblMaskBin3.Location = new System.Drawing.Point(566, 374);
			this.lblMaskBin3.Name = "lblMaskBin3";
			this.lblMaskBin3.Size = new System.Drawing.Size(25, 13);
			this.lblMaskBin3.TabIndex = 23;
			this.lblMaskBin3.Text = "123";
			// 
			// lblMaskBin2
			// 
			this.lblMaskBin2.AutoSize = true;
			this.lblMaskBin2.Location = new System.Drawing.Point(338, 374);
			this.lblMaskBin2.Name = "lblMaskBin2";
			this.lblMaskBin2.Size = new System.Drawing.Size(25, 13);
			this.lblMaskBin2.TabIndex = 22;
			this.lblMaskBin2.Text = "123";
			// 
			// lblMaskBin1
			// 
			this.lblMaskBin1.AutoSize = true;
			this.lblMaskBin1.Location = new System.Drawing.Point(13, 374);
			this.lblMaskBin1.Name = "lblMaskBin1";
			this.lblMaskBin1.Size = new System.Drawing.Size(25, 13);
			this.lblMaskBin1.TabIndex = 21;
			this.lblMaskBin1.Text = "123";
			// 
			// btnNetAddres
			// 
			this.btnNetAddres.Location = new System.Drawing.Point(12, 407);
			this.btnNetAddres.Name = "btnNetAddres";
			this.btnNetAddres.Size = new System.Drawing.Size(223, 23);
			this.btnNetAddres.TabIndex = 25;
			this.btnNetAddres.Text = "Calculate network address";
			this.btnNetAddres.UseVisualStyleBackColor = true;
			this.btnNetAddres.Click += new System.EventHandler(this.btnNetAddres_Click);
			// 
			// IPsCalculator
			// 
			/*this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1602, 637);
			this.Controls.Add(this.btnNetAddres);
			this.Controls.Add(this.lblMaskBin4);
			this.Controls.Add(this.lblMaskBin3);
			this.Controls.Add(this.lblMaskBin2);
			this.Controls.Add(this.lblMaskBin1);
			this.Controls.Add(this.MaskBox4);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.MaskBox3);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.MaskBox2);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.MaskBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cbPreficsMask);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblIPBin4);
			this.Controls.Add(this.lblIPBin3);
			this.Controls.Add(this.lblIPBin2);
			this.Controls.Add(this.lblIPBin1);
			this.Controls.Add(this.IPBox4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.IPBox3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.IPBox2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.IPBox1);
			this.Name = "IPsCalculator";
			this.Text = "IPsCalculator";
			this.ResumeLayout(false);
			this.PerformLayout();*/

		}

		private void AllMaskbox_TextChanged(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void cbPreficsMask_CheckedChanged(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void AllIPtb_TextChanged(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		private void btnNetAddres_Click(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		#endregion

		private System.Windows.Forms.TextBox IPBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox IPBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox IPBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox IPBox4;
		private System.Windows.Forms.Label lblIPBin1;
		private System.Windows.Forms.Label lblIPBin2;
		private System.Windows.Forms.Label lblIPBin3;
		private System.Windows.Forms.Label lblIPBin4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox cbPreficsMask;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox MaskBox4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox MaskBox3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox MaskBox2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox MaskBox1;
		private System.Windows.Forms.Label lblMaskBin4;
		private System.Windows.Forms.Label lblMaskBin3;
		private System.Windows.Forms.Label lblMaskBin2;
		private System.Windows.Forms.Label lblMaskBin1;
		private System.Windows.Forms.Button btnNetAddres;
	}
}


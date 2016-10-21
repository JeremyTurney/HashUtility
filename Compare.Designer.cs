namespace HashDB.LocalUtility.Win
{
	partial class Compare
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compare));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.HashValue = new System.Windows.Forms.TextBox();
			this.ExpectedValue = new System.Windows.Forms.TextBox();
			this.Compare1 = new System.Windows.Forms.Button();
			this.BackCompare = new System.Windows.Forms.Button();
			this.HashText = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(77, 218);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 13);
			this.label1.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(29, 294);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 17);
			this.label2.TabIndex = 9;
			this.label2.Text = "Hash Value";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(29, 343);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(102, 17);
			this.label3.TabIndex = 10;
			this.label3.Text = "Expected Value";
			// 
			// HashValue
			// 
			this.HashValue.Location = new System.Drawing.Point(132, 294);
			this.HashValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.HashValue.Name = "HashValue";
			this.HashValue.Size = new System.Drawing.Size(320, 20);
			this.HashValue.TabIndex = 11;
			this.HashValue.TextChanged += new System.EventHandler(this.HashValue_TextChanged);
			// 
			// ExpectedValue
			// 
			this.ExpectedValue.Location = new System.Drawing.Point(132, 343);
			this.ExpectedValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.ExpectedValue.Name = "ExpectedValue";
			this.ExpectedValue.Size = new System.Drawing.Size(320, 20);
			this.ExpectedValue.TabIndex = 12;
			// 
			// Compare1
			// 
			this.Compare1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Compare1.Location = new System.Drawing.Point(31, 413);
			this.Compare1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Compare1.Name = "Compare1";
			this.Compare1.Size = new System.Drawing.Size(85, 28);
			this.Compare1.TabIndex = 18;
			this.Compare1.Text = "Compare";
			this.Compare1.UseVisualStyleBackColor = true;
			this.Compare1.Click += new System.EventHandler(this.Compare1_Click);
			// 
			// BackCompare
			// 
			this.BackCompare.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BackCompare.Location = new System.Drawing.Point(232, 413);
			this.BackCompare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.BackCompare.Name = "BackCompare";
			this.BackCompare.Size = new System.Drawing.Size(85, 28);
			this.BackCompare.TabIndex = 19;
			this.BackCompare.Text = "Back";
			this.BackCompare.UseVisualStyleBackColor = true;
			this.BackCompare.Click += new System.EventHandler(this.BackCompare_Click);
			// 
			// HashText
			// 
			this.HashText.Font = new System.Drawing.Font("Tahoma", 12F);
			this.HashText.Location = new System.Drawing.Point(46, 190);
			this.HashText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.HashText.Name = "HashText";
			this.HashText.Size = new System.Drawing.Size(469, 84);
			this.HashText.TabIndex = 20;
			this.HashText.Text = "Enter expected hash value and click compare to compare hash value to expected has" +
    "h value. ";
			this.HashText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.HashText.Click += new System.EventHandler(this.HashText_Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(439, 413);
			this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(85, 28);
			this.button1.TabIndex = 21;
			this.button1.Text = "Exit";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(8, 30);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(545, 192);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 22;
			this.pictureBox1.TabStop = false;
			// 
			// Compare
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(561, 470);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.HashText);
			this.Controls.Add(this.BackCompare);
			this.Controls.Add(this.Compare1);
			this.Controls.Add(this.ExpectedValue);
			this.Controls.Add(this.HashValue);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "Compare";
			this.Text = "Compare";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox HashValue;
		private System.Windows.Forms.TextBox ExpectedValue;
		private System.Windows.Forms.Button Compare1;
		private System.Windows.Forms.Button BackCompare;
		private System.Windows.Forms.Label HashText;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
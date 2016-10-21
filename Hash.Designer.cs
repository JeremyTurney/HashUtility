namespace HashDB.LocalUtility.Win
{
	partial class Hash
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hash));
			this.Upload = new System.Windows.Forms.Button();
			this.Hash1 = new System.Windows.Forms.Button();
			this.Back = new System.Windows.Forms.Button();
			this.HashLogo = new System.Windows.Forms.PictureBox();
			this.FilePath = new System.Windows.Forms.TextBox();
			this.HashText = new System.Windows.Forms.Label();
			this.MD5 = new System.Windows.Forms.RadioButton();
			this.SHA1 = new System.Windows.Forms.RadioButton();
			this.SHA256 = new System.Windows.Forms.RadioButton();
			this.SHA512 = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.Compare = new System.Windows.Forms.Button();
			this.HashExit = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.HashLogo)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Upload
			// 
			this.Upload.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Upload.Location = new System.Drawing.Point(47, 421);
			this.Upload.Name = "Upload";
			this.Upload.Size = new System.Drawing.Size(128, 43);
			this.Upload.TabIndex = 3;
			this.Upload.Text = "Browse";
			this.Upload.UseVisualStyleBackColor = true;
			this.Upload.Click += new System.EventHandler(this.Upload_Click);
			// 
			// Hash1
			// 
			this.Hash1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Hash1.Location = new System.Drawing.Point(47, 515);
			this.Hash1.Name = "Hash1";
			this.Hash1.Size = new System.Drawing.Size(128, 43);
			this.Hash1.TabIndex = 4;
			this.Hash1.Text = "Hash";
			this.Hash1.UseVisualStyleBackColor = true;
			this.Hash1.Click += new System.EventHandler(this.Hash1_Click);
			// 
			// Back
			// 
			this.Back.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Back.Location = new System.Drawing.Point(353, 664);
			this.Back.Name = "Back";
			this.Back.Size = new System.Drawing.Size(128, 43);
			this.Back.TabIndex = 5;
			this.Back.Text = "Back";
			this.Back.UseVisualStyleBackColor = true;
			this.Back.Click += new System.EventHandler(this.Back_Click);
			// 
			// HashLogo
			// 
			this.HashLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.HashLogo.Image = ((System.Drawing.Image)(resources.GetObject("HashLogo.Image")));
			this.HashLogo.Location = new System.Drawing.Point(12, 12);
			this.HashLogo.Name = "HashLogo";
			this.HashLogo.Padding = new System.Windows.Forms.Padding(5);
			this.HashLogo.Size = new System.Drawing.Size(817, 296);
			this.HashLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.HashLogo.TabIndex = 6;
			this.HashLogo.TabStop = false;
			// 
			// FilePath
			// 
			this.FilePath.AllowDrop = true;
			this.FilePath.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FilePath.Location = new System.Drawing.Point(204, 431);
			this.FilePath.Name = "FilePath";
			this.FilePath.Size = new System.Drawing.Size(583, 27);
			this.FilePath.TabIndex = 7;
			this.FilePath.TextChanged += new System.EventHandler(this.FilePath_TextChanged);
			this.FilePath.DragDrop += new System.Windows.Forms.DragEventHandler(this.FilePath_DragDrop);
			this.FilePath.DragEnter += new System.Windows.Forms.DragEventHandler(this.FilePath_DragEnter);
			// 
			// HashText
			// 
			this.HashText.Font = new System.Drawing.Font("Tahoma", 12F);
			this.HashText.Location = new System.Drawing.Point(69, 246);
			this.HashText.Name = "HashText";
			this.HashText.Size = new System.Drawing.Size(704, 149);
			this.HashText.TabIndex = 8;
			this.HashText.Text = resources.GetString("HashText.Text");
			this.HashText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.HashText.Click += new System.EventHandler(this.HashText_Click);
			// 
			// MD5
			// 
			this.MD5.AutoSize = true;
			this.MD5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MD5.Location = new System.Drawing.Point(34, 31);
			this.MD5.Name = "MD5";
			this.MD5.Size = new System.Drawing.Size(75, 28);
			this.MD5.TabIndex = 10;
			this.MD5.TabStop = true;
			this.MD5.Text = "MD5";
			this.MD5.UseVisualStyleBackColor = true;
			// 
			// SHA1
			// 
			this.SHA1.AutoSize = true;
			this.SHA1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SHA1.Location = new System.Drawing.Point(164, 31);
			this.SHA1.Name = "SHA1";
			this.SHA1.Size = new System.Drawing.Size(83, 28);
			this.SHA1.TabIndex = 11;
			this.SHA1.TabStop = true;
			this.SHA1.Text = "SHA1";
			this.SHA1.UseVisualStyleBackColor = true;
			// 
			// SHA256
			// 
			this.SHA256.AutoSize = true;
			this.SHA256.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SHA256.Location = new System.Drawing.Point(305, 31);
			this.SHA256.Name = "SHA256";
			this.SHA256.Size = new System.Drawing.Size(105, 28);
			this.SHA256.TabIndex = 12;
			this.SHA256.TabStop = true;
			this.SHA256.Text = "SHA256";
			this.SHA256.UseVisualStyleBackColor = true;
			// 
			// SHA512
			// 
			this.SHA512.AutoSize = true;
			this.SHA512.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.SHA512.Location = new System.Drawing.Point(465, 31);
			this.SHA512.Name = "SHA512";
			this.SHA512.Size = new System.Drawing.Size(105, 28);
			this.SHA512.TabIndex = 13;
			this.SHA512.TabStop = true;
			this.SHA512.Text = "SHA512";
			this.SHA512.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.SHA512);
			this.groupBox1.Controls.Add(this.SHA256);
			this.groupBox1.Controls.Add(this.SHA1);
			this.groupBox1.Controls.Add(this.MD5);
			this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(189, 499);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(598, 74);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Choose Hash Type";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(43, 601);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(154, 24);
			this.label1.TabIndex = 15;
			this.label1.Text = "Calculated Hash";
			// 
			// textBox1
			// 
			this.textBox1.AcceptsReturn = true;
			this.textBox1.Location = new System.Drawing.Point(204, 602);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(583, 26);
			this.textBox1.TabIndex = 16;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// Compare
			// 
			this.Compare.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Compare.Location = new System.Drawing.Point(47, 664);
			this.Compare.Name = "Compare";
			this.Compare.Size = new System.Drawing.Size(128, 43);
			this.Compare.TabIndex = 17;
			this.Compare.Text = "Compare";
			this.Compare.UseVisualStyleBackColor = true;
			this.Compare.Click += new System.EventHandler(this.Compare_Click);
			// 
			// HashExit
			// 
			this.HashExit.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HashExit.Location = new System.Drawing.Point(659, 664);
			this.HashExit.Name = "HashExit";
			this.HashExit.Size = new System.Drawing.Size(128, 43);
			this.HashExit.TabIndex = 18;
			this.HashExit.Text = "Exit";
			this.HashExit.UseVisualStyleBackColor = true;
			this.HashExit.Click += new System.EventHandler(this.HashExit_Click);
			// 
			// Hash
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(841, 723);
			this.Controls.Add(this.HashExit);
			this.Controls.Add(this.Compare);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.HashText);
			this.Controls.Add(this.FilePath);
			this.Controls.Add(this.HashLogo);
			this.Controls.Add(this.Back);
			this.Controls.Add(this.Hash1);
			this.Controls.Add(this.Upload);
			this.Name = "Hash";
			this.Text = "Hash";
			((System.ComponentModel.ISupportInitialize)(this.HashLogo)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Upload;
		private System.Windows.Forms.Button Hash1;
		private System.Windows.Forms.Button Back;
		private System.Windows.Forms.PictureBox HashLogo;
		private System.Windows.Forms.TextBox FilePath;
		private System.Windows.Forms.Label HashText;
		private System.Windows.Forms.RadioButton MD5;
		private System.Windows.Forms.RadioButton SHA1;
		private System.Windows.Forms.RadioButton SHA256;
		private System.Windows.Forms.RadioButton SHA512;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button Compare;
		private System.Windows.Forms.Button HashExit;
		private System.Windows.Forms.TextBox textBox1;
	}
}
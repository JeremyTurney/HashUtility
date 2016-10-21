namespace HashDB.LocalUtility.Win
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.Hash = new System.Windows.Forms.Button();
			this.Search = new System.Windows.Forms.Button();
			this.Exit = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.HashText = new System.Windows.Forms.Label();
			this.HashLogo = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.HashLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// Hash
			// 
			this.Hash.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Hash.Location = new System.Drawing.Point(27, 408);
			this.Hash.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Hash.Name = "Hash";
			this.Hash.Size = new System.Drawing.Size(85, 28);
			this.Hash.TabIndex = 1;
			this.Hash.Text = "Hash";
			this.Hash.UseVisualStyleBackColor = true;
			this.Hash.Click += new System.EventHandler(this.Hash_Click);
			// 
			// Search
			// 
			this.Search.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Search.Location = new System.Drawing.Point(233, 408);
			this.Search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Search.Name = "Search";
			this.Search.Size = new System.Drawing.Size(85, 28);
			this.Search.TabIndex = 2;
			this.Search.Text = "Search";
			this.Search.UseVisualStyleBackColor = true;
			// 
			// Exit
			// 
			this.Exit.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Exit.Location = new System.Drawing.Point(439, 408);
			this.Exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Exit.Name = "Exit";
			this.Exit.Size = new System.Drawing.Size(85, 28);
			this.Exit.TabIndex = 3;
			this.Exit.Text = "Exit";
			this.Exit.UseVisualStyleBackColor = true;
			this.Exit.Click += new System.EventHandler(this.Exit_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(265, 377);
			this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(0, 0);
			this.button1.TabIndex = 4;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// HashText
			// 
			this.HashText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HashText.Location = new System.Drawing.Point(46, 207);
			this.HashText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.HashText.Name = "HashText";
			this.HashText.Size = new System.Drawing.Size(469, 84);
			this.HashText.TabIndex = 9;
			this.HashText.Text = resources.GetString("HashText.Text");
			this.HashText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// HashLogo
			// 
			this.HashLogo.Image = ((System.Drawing.Image)(resources.GetObject("HashLogo.Image")));
			this.HashLogo.Location = new System.Drawing.Point(8, 8);
			this.HashLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.HashLogo.Name = "HashLogo";
			this.HashLogo.Size = new System.Drawing.Size(545, 192);
			this.HashLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.HashLogo.TabIndex = 0;
			this.HashLogo.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(561, 470);
			this.Controls.Add(this.HashText);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Exit);
			this.Controls.Add(this.Search);
			this.Controls.Add(this.Hash);
			this.Controls.Add(this.HashLogo);
			this.DoubleBuffered = true;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "Form1";
			this.Text = "Home ";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.HashLogo)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button Hash;
		private System.Windows.Forms.Button Search;
		private System.Windows.Forms.Button Exit;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label HashText;
		private System.Windows.Forms.PictureBox HashLogo;
	}
}


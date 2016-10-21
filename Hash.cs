using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace HashDB.LocalUtility.Win
{
	public partial class Hash : Form
	{
		public Form1 RefToForm1 { get; set; }

		public string userSelectedFilePath
		{
			get
			{
				return FilePath.Text;
			}
			set
			{
				FilePath.Text = value;
			}
		}

		public Hash()
		{
			InitializeComponent();
		}

		private void Upload_Click(object sender, EventArgs e)
		{
			LoadNewFile();
		}

		private void LoadNewFile()
		{
			OpenFileDialog open = new OpenFileDialog();
			System.Windows.Forms.DialogResult results = open.ShowDialog();
			if (results == DialogResult.OK)
			{
				userSelectedFilePath = open.FileName;
			}
		}

		private void Compare_Click(object sender, EventArgs e)
		{
			Compare c = new Compare(textBox1.Text);
			c.RefToHash = this;
			this.Visible = false;
			c.Show();
			
		}

		private void HashExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void Back_Click(object sender, EventArgs e)
		{
			this.Close();
			RefToForm1.Show();
		}

		private void FilePath_TextChanged(object sender, EventArgs e)
		{
			
		}
		private void FilePath_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.All;

		}

		private void FilePath_DragEnter_1(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.All;

		}

		private void FilePath_DragDrop(object sender, DragEventArgs e)
		{
			string[] files = (string []) e.Data.GetData(DataFormats.FileDrop, false);

				foreach (string file in files)
				{
					FilePath.Text = file;
				}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void Hash1_Click(object sender, EventArgs e)
		{
			FileAttributes attribute = File.GetAttributes(FilePath.Text);
			if ((attribute & FileAttributes.Directory) == FileAttributes.Directory)
			{
				MessageBox.Show("Please upload a file and not a directory");
			}
			else
			{
				var fi = new FileInfo(FilePath.Text);
				var st = fi.OpenRead();
				var hash = ProphetsWay.Utilities.HashUtility.GenerateHashes(st);

				if (MD5.Checked)
				{
					textBox1.Text = MD5_Value();

					//textBox1.Text = hash.MD5;

				}
				else if (SHA1.Checked)
				{
					textBox1.Text = getSHA1(FilePath.Text);
					//textBox1.Text = hash.SHA1;
				}
				else if (SHA256.Checked)
				{
					//textBox1.Text = getSHA256(FilePath.Text);
					textBox1.Text = hash.SHA256;
				}
				else if (SHA512.Checked)
				{
					//textBox1.Text = getSHA512(FilePath.Text);
					textBox1.Text = hash.SHA512;
				}
				else
				{
					MessageBox.Show("Please select what hash algorithm to use");
				}
			}
		}

		private void HashText_Click(object sender, EventArgs e)
		{

		}

		static string MD5_Hash(MD5 md5Hash, string file)
		{
			byte[] computes = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(file)); //convert file to byte array and compute hash

			StringBuilder collector = new StringBuilder(); // create a string builder to collect bytes

			for (int i = 0; i < computes.Length; i++) // loops through each byte and converts to a hexadecimal
			{
				collector.Append(computes[i].ToString("x2"));
			}

			return collector.ToString();
		}

		private string MD5_Value()
		{
			string fileToHash = FilePath.Text;

			using (MD5 md5Hash = System.Security.Cryptography.MD5.Create())
			{
				string hashing = MD5_Hash(md5Hash, fileToHash);
				return hashing;
			}
		}

		public string getSHA1 (string text)
		{
			SHA1CryptoServiceProvider s = new SHA1CryptoServiceProvider();
			s.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
			byte[] r = s.Hash;
			StringBuilder sb = new StringBuilder();

			foreach (byte b in r)
			{
				sb.Append(b.ToString("x2"));
			}

			return sb.ToString();
		}

		/*public string getSHA256 (string text)
		{
			SHA256CryptoServiceProvider s = new SHA256CryptoServiceProvider();
			s.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
			byte[] r = s.Hash;
			StringBuilder sb = new StringBuilder();

			foreach (byte b in r)
			{
				sb.Append(b.ToString("x2"));
			}

			return sb.ToString();
		}

		public string getSHA512 (string text)
		{
			SHA512CryptoServiceProvider s = new SHA512CryptoServiceProvider();
			s.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
			byte[] r = s.Hash;
			StringBuilder sb = new StringBuilder();

			foreach (byte b in r)
			{
				sb.Append(b.ToString("x2"));
			}

			return sb.ToString();
		}*/
	}
}

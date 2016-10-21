using System;
using System.Windows.Forms;

namespace HashDB.LocalUtility.Win
{
	public partial class Compare : Form
	{
		public Hash RefToHash { get; set; }

		public Compare(string sent)
		{
			InitializeComponent();
			HashValue.Text = sent;
		}

		private void HashText_Click(object sender, EventArgs e)
		{

		}

		private void Compare1_Click(object sender, EventArgs e)
		{

			if (HashValue.Text == "")
			{
				MessageBox.Show("No hash value entered. Please enter a hash value or go back to previous screen and re-hash file.");

			}
			else if (ExpectedValue.Text == "")
			{
				MessageBox.Show("No expected hash value entered. Please enter an expected hash value.");

			}
			else
			{
				if (HashValue.Text == ExpectedValue.Text)
				{
					MessageBox.Show("Hash Values are the same");
				}
				else
				{
					MessageBox.Show("Hash Values are different");
				}
			}
		}

		private void BackCompare_Click(object sender, EventArgs e)
		{
			RefToHash.Show();
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void HashValue_TextChanged(object sender, EventArgs e)
		{
			
		}

	}
}

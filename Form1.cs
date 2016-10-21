using System;
using System.Windows.Forms;

namespace HashDB.LocalUtility.Win
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void Hash_Click(object sender, EventArgs e)
		{
			Hash h = new Hash();
			h.RefToForm1 = this;
			this.Visible = false;
			h.Show();
			
		}

		private void Exit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}

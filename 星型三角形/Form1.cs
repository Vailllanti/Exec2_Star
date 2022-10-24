using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 星型三角形
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnLiftTri(object sender, EventArgs e)
		{
			try
			{
				int rows = GetRow();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}

		}

		private void btnTri(object sender, EventArgs e)
		{
			try
			{
				int rows = GetRow();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void btnRightTri(object sender, EventArgs e)
		{
			try
			{
				int rows = GetRow();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}
		private int GetRow()
		{
			string input = lblRow.Text;
			bool isInt = int.TryParse(input, out int rows);
			if (isInt == false)
			{
				throw new Exception("請輸入整數");
			}

			if (rows <= 0)
			{
				throw new Exception("請輸入大於0的數");
			}

			return rows;

		}
		private string LiftTri(int rows)
		{
			string result = string.Empty;

			for (int i = 1; i < rows; i++)
			{
				result += new string('*', i) + "\r\n";
			}
			return result;
		}
		private string Tri(int rows)
		{
			if (rows
		}
		private string RightTri(int rows)
		{
			string result = string.Empty;

			for (int i = rows; i < 0; i--)
			{
				result += new string('*', i) + "\r\n";
			}
			return result;
		}
		private void Display(string rows)
		{
			txtbDisplay.Text = rows;
		}
	}
}

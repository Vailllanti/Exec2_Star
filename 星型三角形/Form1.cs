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

		private void BtnLiftTri(object sender, EventArgs e)
		{
			int rows = 0;
			try
			{
				rows = GetRow();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			string result = LiftTri(rows);
			Display(result);
		}

		private void BtnTri(object sender, EventArgs e)
		{
			int rows = 0;
			try
			{
				rows = GetRow();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			string stars = Tri(rows);
			Display(stars);
		}

		private void BtnRightTri(object sender, EventArgs e)
		{
			int rows = 0;
			try
			{
				rows = GetRow();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			string result = RightTri(rows);
			Display(result);
		}

		private int GetRow()
		{
			string input = txtbRow.Text;
			bool isInt = int.TryParse(input, out int rows);
			
			if (isInt == false)
			{
				throw new Exception("請輸入整數");
			}

			if (rows <= 0 || rows >10)
			{
				throw new Exception("請輸入介於1~10的數字");
			}
			return rows;
		}


		private string LiftTri(int rows)
		{
			string result = string.Empty;

			for (int i = 1; i <= rows; i++)
			{
				result += new string('*', i) + "\r\n";
			}
			return result;
		}


		private string Tri(int rows)
		{
			string result = string.Empty;

			for (int i = 1; i <= rows; i++)
			{
				result += (new string(' ', rows - i) + new string('*', 2 * i - 1) + "\r\n");
			}
			return result;
		}

		private string RightTri(int rows)
		{
			string result = string.Empty;

			for (int i = 1; i <= rows; i++)
			{
				result += (new string(' ', rows - i) + new string('*', i) + "\r\n");
			}
			return result;
		}

		private void Display(string rows)
		{
			txtbDisplay.Text = rows;
		}
	}
}

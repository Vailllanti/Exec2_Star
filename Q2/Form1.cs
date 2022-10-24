using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
	public partial class Form1 : Form
	{
		//Button click 時, 用 Label 顯示目前系統時間及問候語(用兩行呈現)
		public Form1()
		{
			InitializeComponent();
		}

		private void btnShowTime_Click(object sender, EventArgs e)
		{
			Greeting();
			Display();
		}
		private DateTime dt = DateTime.Now;
		
		private string greeting = String.Empty;
		
		private void Greeting()
		{
			DateTime noon = DateTime.Today.AddHours(12);
			DateTime night = noon.AddHours(6);

			if (dt > night)
			{
				greeting = "晚安";
			}
			else if (dt > noon)
			{
				greeting = "午安";
			}
			else
			{
				greeting = "早安";
			}
		}
		private void Display()
		{
			lblShowTime.Text = dt.ToString("現在時間: yyyy/MM/dd HH:mm:ss ")+ "\r\n" + greeting;

		}
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace generators
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void buttonStart_Click(object sender, EventArgs e)
		{
			squareMethod();
			fibonacciMethod();
		}

		private void squareMethod()
		{
			textBoxSquare.Clear();
			string number = textBoxKey.Text;

			if (number.Length % 2 != 0)
				number += "0";
			int n = number.Length / 2;
			number = "0," + number;

			for (int i = 0; i < 17; i++)
			{
				double tmp = Double.Parse(number);
				tmp *= tmp;

				number = tmp.ToString();
				while (number.Length < 4 * n + 2)
					number += "0";
				number = "0," + number.Substring(2 + n, 2 * n);

				textBoxSquare.AppendText(number + "\n");
			}
		}

		private void fibonacciMethod()
		{
			textBoxFib.Clear();
			int a = 17 - 17, b = 17 - 5;
			List<double> list = new List<double>();

			foreach (string num in textBoxSquare.Text.Split('\n'))
			{
				double tmp;

				if(Double.TryParse(num, out tmp))
					list.Add(tmp);
			}

			for (int i = 0; i < 17; i++)
			{
				double newNum;

				if (list[a] >= list[b])
					newNum = list[a] - list[b];
				else
					newNum = list[a] - list[b] + 1;
				list.RemoveAt(0);
				list.Add(newNum);

				textBoxFib.AppendText(newNum.ToString("f" + textBoxKey.TextLength) + "\n");
			}
		}
	}
}

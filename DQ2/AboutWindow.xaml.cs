﻿using System.Windows;
using System.Windows.Input;

namespace DQ2
{
	/// <summary>
	/// AboutWindow.xaml の相互作用ロジック
	/// </summary>
	public partial class AboutWindow : Window
	{
		public AboutWindow()
		{
			InitializeComponent();
		}

		private void LabelHP_MouseDown(object sender, MouseButtonEventArgs e)
		{
			System.Diagnostics.Process.Start("http://kamemushi.esy.es/");
		}
	}
}

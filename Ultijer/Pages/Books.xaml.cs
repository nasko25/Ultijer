﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Ultijer.Pages
{
	/// <summary>
	/// Interaction logic for Books.xaml
	/// </summary>
	public partial class Books : Page
	{
		public Books()
		{
			InitializeComponent();
		}

		public void OnClick(object sender, RoutedEventArgs e) {
			var myDoubleAnimation = new DoubleAnimation
			{
				From = 1.0,
				To = 0.0,
				Duration = new Duration(TimeSpan.FromSeconds(5))
		};
		}
	}
}

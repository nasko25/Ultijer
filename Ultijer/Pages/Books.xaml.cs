using System;
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
		private Storyboard storyboard;
		public Books()
		{
			InitializeComponent();

			var myDoubleAnimation = new DoubleAnimation
			{
				From = 1.0,
				To = 0.0,
				Duration = new Duration(TimeSpan.FromSeconds(5))
			};

			storyboard = new Storyboard();
			storyboard.Children.Add(myDoubleAnimation);
			Storyboard.SetTargetName(myDoubleAnimation, MyRectangle.Name);
			/*
			 * For more information about TargetProperty syntax and for additional examples, see the Storyboards Overview.
			 * https://docs.microsoft.com/en-us/dotnet/framework/wpf/graphics-multimedia/storyboards-overview
			 */
			Storyboard.SetTargetProperty(myDoubleAnimation, new PropertyPath(Rectangle.OpacityProperty));
		}

		public void OnClick(object sender, RoutedEventArgs e) {
			storyboard.Begin(this);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ultijer
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		Grid home, movies;
		bool removed_home = false, removed_movies = false;
		public MainWindow()
		{
			InitializeComponent();
			home = Home;
			parent.Children.Remove(this.home); removed_home = true;
			movies = Movies;
			parent.Children.Remove(this.movies); removed_movies = true;
		}
		public void OnButtonClick(object sender, RoutedEventArgs e) {
			if (j_n.Content.Equals("Journal")) {
				j_n.Content = "Notes";
			}
			else if (j_n.Content.Equals("Notes"))
			{
				j_n.Content = "Journal";
			}
			if (removed_home)
			{
				parent.Children.Add(home);
				removed_home = false;
			}
			else {
				parent.Children.Remove(home);
				removed_home = true;
			}
			if (sender.Equals(movies_button)) {
				MessageBox.Show("YOU SELECTED THE MOVIES BUTTON");
			}
		} 
	}
}

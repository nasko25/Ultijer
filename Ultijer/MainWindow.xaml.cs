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
	/// 

	// TODO probably the OnButtonClick(..., ...) should be implemented with a switch statement  !!!!
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
			String sender_string = sender.ToString().Substring(sender.ToString().IndexOf(":") + 2); // 2. because there is : and a space too much
			if (j_n.Content.Equals("Journal") && sender_string.Equals("Journal")) {
				j_n.Content = "Notes";
			}
			else if (j_n.Content.Equals("Notes") && sender_string.Equals("Notes"))
			{
				j_n.Content = "Journal";
			}
			if (removed_home && sender.Equals(home_button))
			{
				parent.Children.Add(home);
				removed_home = false;
			}
			else if (!removed_home && !sender.Equals(home_button)) {
				parent.Children.Remove(home);
				removed_home = true;
			}
			if (sender.Equals(movies_button) && removed_movies)
			{
				parent.Children.Add(movies);
				removed_movies = false;
				MessageBox.Show("YOU SELECTED THE MOVIES BUTTON");
			}
			else if (!sender.Equals(movies_button) && !removed_movies) {
				parent.Children.Remove(movies);
				removed_movies = true;
			}
			// TODO instead of remopving the elements in the view one by one, try to remove them all together like:
			/* foreach (System.Windows.UIElement i in parent.Children) {
				parent.Children.Remove(i);
			}
			in all cases when a button is pressed, and parent.Children is not null.
			*/ 
		} 
	}
}

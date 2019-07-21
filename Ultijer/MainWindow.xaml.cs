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

	public partial class MainWindow : Window
	{
		bool removed_home = false, removed_movies = false, removed_books = false;
		public MainWindow()
		{
			InitializeComponent();
			removed_home = true;
			removed_movies = true;
			removed_books = true;
		}
		public void OnButtonClick(object sender, RoutedEventArgs e) {
			if (j_n.Content.Equals("Journal") && sender.Equals(j_n)) {
				j_n.Content = "Notes";
			}
			else if (j_n.Content.Equals("Notes") && sender.Equals(j_n))
			{
				j_n.Content = "Journal";
			}
			if (removed_home && sender.Equals(home_button) && j_n.Content.Equals("Journal"))
			{
				_mainFrame.Navigate(new Pages.Home());
				removed_home = false;
			}
			else if (!removed_home && !sender.Equals(home_button)) {
				_mainFrame.Navigate(new Pages.EmptyPage());
				removed_home = true;
			}
			if (sender.Equals(movies_button) && removed_movies && j_n.Content.Equals("Journal"))
			{
				_mainFrame.Navigate(new Pages.Movies());
				removed_movies = false;
				MessageBox.Show("YOU SELECTED THE MOVIES BUTTON");
			}
			else if (!sender.Equals(movies_button) && !removed_movies) {
				_mainFrame.Navigate(new Pages.EmptyPage());
				removed_movies = true;
			}

			if (sender.Equals(books_button) && removed_books && j_n.Content.Equals("Journal"))
			{
				_mainFrame.Navigate(new Pages.Books());
				removed_books = false;
			}
			else if (!sender.Equals(books_button) && !removed_books)
			{
				_mainFrame.Navigate(new Pages.EmptyPage());
				removed_books = true;
			}
		} 
	}
}

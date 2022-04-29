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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for BookDetails.xaml
    /// </summary>
    public partial class BookDetails : Window
    {
        public BookDetails()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MainWindow main = this.Owner as MainWindow;


        }

        private void lbfirst_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Book selectedBook = lbfirst.SelectedItem as Book;

            if (selectedBook != null)
            {
                BookName.Text = selectedBook.GetName();
                BookPrice.Text = selectedBook.GetPrice();
                BookAuthor.Text = selectedBook.GetAuthor();
                BookImage.Source = new BitmapImage(new Uri(selectedBook.Image, UriKind.RelativeOrAbsolute));
            }
        }
    }
}

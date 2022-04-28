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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Book> books = new List<Book>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Book b1 = new Book() { Name = "The Way of Kings", Price = 10, Author = "Brandon Sanderson", Description = "Shallan, a minor lighteyed woman whose family and lands are in danger, hatches a daring plot to switch a broken Soulcaster (a device that allows people to change objects to other things) with a working one belonging to Jasnah Kholin, sister of the Alethi king.", Type = "Adventure"};
            Book b2 = new Book() { Name = "Harry Potter and the philosopher's stone", Price = 7, Author = "J.K. Rowling", Description = "It is a story about Harry Potter, an orphan brought up by his aunt and uncle because his parents were killed when he was a baby. Harry is unloved by his uncle and aunt but everything changes when he is invited to join Hogwarts School of Witchcraft and Wizardry and he finds out he's a wizard.", Type = "Adventure" };
            Book b3 = new Book() { Name = "Outlander", Price = 9, Author = "Diana Gabaldon", Description = "A man with a faded, well-worn notebook open in his lap. A woman experiencing a morning ritual she doesn’t understand. Until he begins to read to her.  The Notebook is an achingly tender story about the enduring power of love, a story of miracles that will stay with you forever. Set amid the austere beauty of coastal North Carolina in 1946, The Notebook begins with the story of Noah Calhoun, a rural Southerner returned home from World War II. Noah, thirty-one, is restoring a plantation home to its former glory, and he is haunted by images of the beautiful girl he met fourteen years earlier, a girl he loved like no other. Unable to find her, yet unwilling to forget the summer they spent together, Noah is content to live with only memories. . . until she unexpectedly returns to his town to see him once again. Allie Nelson, twenty-nine, is now engaged to another man, but realizes that the original passion she felt for Noah has not dimmed with the passage of time. Still, the obstacles that once ended their previous relationship remain, and the gulf between their worlds is too vast to ignore. With her impending marriage only weeks away, Allie is forced to confront her hopes and dreams for the future, a future that only she can shape. Like a puzzle within a puzzle, the story of Noah and Allie is just beginning. As it unfolds, their tale miraculously becomes something different, with much higher stakes. The result is a deeply moving portrait of love itself, the tender moments, and fundamental changes that affect us all. Shining with a beauty that is rarely found in current literature, The Notebook establishes Nicholas Sparks as a classic storyteller with a unique insight into the only emotion that really matters.", Type = "Romance" };
            Book b4 = new Book() { Name = "The Notebook", Price = 13, Author = "Nicholas Sparks", Description = "The Notebook is an achingly tender story about the enduring power of love, a story of miracles that will stay with you forever. Set amid the austere beauty of coastal North Carolina in 1946, The Notebook begins with the story of Noah Calhoun, a rural Southerner returned home from World War II.", Type = "Romance" };
            Book b5 = new Book() { Name = "The Duke and I", Price = 11, Author = "Julia Quinn", Description = "mon Basset, Duke of Hastings, has sworn never to marry. Daphne Bridgerton has sworn to marry only for love. They make a bargain and fake a courtship to keep the ton's matchmakers at bay–but what happens when the charade becomes all too real?", Type = "Romance" };
            Book b6 = new Book() { Name = "Dune", Price = 5, Author = "Frank Herbert", Description = "Dune is a 1965 epic science fiction novel by American author Frank Herbert, originally published as two separate serials in Analog magazine. It tied with Roger Zelazny's This Immortal for the Hugo Award in 1966 and it won the inaugural Nebula Award for Best Novel. It is the first installment of the Dune saga.", Type = "Sci-fi" };
            Book b7 = new Book() { Name = "Frankenstein", Price = 5, Author = "Mary Shelley", Description = "Frankenstein; or, The Modern Prometheus is an 1818 novel written by English author Mary Shelley. Frankenstein tells the story of Victor Frankenstein, a young scientist who creates a sapient creature in an unorthodox scientific experiment.", Type = "Sci-fi" };
            Book b8 = new Book() { Name = "Hyperion", Price = 7, Author = "Dan Simmons", Description = "Hyperion is a 1989 science fiction novel by American author Dan Simmons. The first book of his Hyperion Cantos, it won the Hugo Award for best novel. The plot of the novel features multiple time-lines and characters. It follows a similar structure to The Canterbury Tales by Geoffrey Chaucer.", Type = "Sci-fi" };
            Book b9 = new Book() { Name = "Neuromancer", Price = 6, Author = "William Gibson", Description = "Neuromancer is a 1984 science fiction novel by American-Canadian writer William Gibson. Considered one of the earliest and best-known works in the cyberpunk genre, it is the only novel to win the Nebula Award, the Philip K. Dick Award, and the Hugo Award.", Type = "Sci-fi" };
            Book b10 = new Book() { Name = "Treasure Island", Price = 5, Author = "Robert Louis Stevenson", Description = "Treasure Island is an adventure novel by Scottish author Robert Louis Stevenson, telling a story of buccaneers and buried gold. It is considered a coming-of-age story and is noted for its atmosphere, characters, and action.", Type = "Adventure" };

            books.Add(b1);
            books.Add(b2);
            books.Add(b3);
            books.Add(b4);
            books.Add(b5);
            books.Add(b6);
            books.Add(b7);
            books.Add(b8);
            books.Add(b9);
            books.Add(b10);

            lbfirst.ItemsSource = books;
        }
    }
}

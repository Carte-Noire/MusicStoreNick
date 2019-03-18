using MusicStoreDataNick;
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

namespace MusicStoreNick
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            IList<Genre> genreList = GenreRepository.GetGenres();
            Genre_Combobox.ItemsSource = genreList;


        }

        private void Genre_Combobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            albumDataGrid.ItemsSource = AlbumRepository.GetAlbumsByGenre(Convert.ToInt32(Genre_Combobox.SelectedValue));
            //albumDataGrid.ItemsSource = ArtistRepository.GetArtistNameById(Convert.ToInt32(Genre_Combobox.SelectedValue));

        }

    }

    
}

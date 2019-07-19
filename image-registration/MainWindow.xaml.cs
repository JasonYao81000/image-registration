using Microsoft.Win32;
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

namespace image_registration {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void MenuItem_Open_File_Click(object sender, RoutedEventArgs e) {
            var dlg = new OpenFileDialog {
                // Set filter for file extension and default file extension.
                DefaultExt = ".png",
                Filter = "All Images Files (*.png;*.jpeg;*.gif;*.jpg;*.bmp;*.tiff;*.tif)|*.png;*.jpeg;*.gif;*.jpg;*.bmp;*.tiff;*.tif" +
                        "|PNG Portable Network Graphics (*.png)|*.png" +
                        "|JPEG File Interchange Format (*.jpg *.jpeg *jfif)|*.jpg;*.jpeg;*.jfif" +
                        "|BMP Windows Bitmap (*.bmp)|*.bmp" +
                        "|TIF Tagged Imaged File Format (*.tif *.tiff)|*.tif;*.tiff" +
                        "|GIF Graphics Interchange Format (*.gif)|*.gif",
            };
            // Display OpenFileDialog by calling ShowDialog method.
            if (dlg.ShowDialog() == true) {
                var filename = dlg.FileName;
                MainImage.Source = new BitmapImage(new Uri(filename));
            }
        }
        private void MenuItem_Exit_Click(object sender, RoutedEventArgs e) {
            Close();
        }
    }
}

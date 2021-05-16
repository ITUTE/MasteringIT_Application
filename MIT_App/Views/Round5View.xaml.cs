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
using System.IO;

namespace MIT_App.Views
{
    /// <summary>
    /// Interaction logic for Round5View.xaml
    /// </summary>
    public partial class Round5View : Window
    {
        public Round5View()
        {
            InitializeComponent();
            
        }

        public void CutImage()
        {
            /*int count = 0;
            BitmapImage src = new BitmapImage(new Uri("/Image/avt2_pro.png", UriKind.Relative));
            Hinh.Source = new CroppedBitmap(src, new Int32Rect(0, 0, 10, 10));*/
            
            //for (int i = 0; i < 3; i++)
            //    for (int j = 0; j < 3; j++)
            //        objImg[count++] = new CroppedBitmap(src, new Int32Rect(j * 120, i * 120, 120, 120));
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            CutImage();
        }

        private void Image_Loaded(object sender, RoutedEventArgs e)
        {
            Border border = (Border)sender;
            BitmapSource bitmapSource = (BitmapSource)this.Resources["masterImage"];            
            Int32 width = (Int32)bitmapSource.PixelWidth / 5;
            Int32 height = (Int32)bitmapSource.PixelHeight / 2;
            Int32Rect dropframe = new Int32Rect(0, 0, width, height);

            //Tạo frame cho từng vị trí
            switch (border.Name[border.Name.Length-1]) 
            { 
                case '0':
                    dropframe.X = 0;
                    dropframe.Y = 0;
                    break;
                case '1':
                    dropframe.X = width;
                    dropframe.Y = 0;
                    break;
                case '2':
                    dropframe.X = width*2;
                    dropframe.Y = 0;
                    break;
                case '3':
                    dropframe.X = width*3;
                    dropframe.Y = 0;
                    break;
                case '4':
                    dropframe.X = width*4;
                    dropframe.Y = 0;
                    break;
                case '5':
                    dropframe.X = 0;
                    dropframe.Y = height;
                    break;
                case '6':
                    dropframe.X = width;
                    dropframe.Y = height;
                    break;
                case '7':
                    dropframe.X = width*2;
                    dropframe.Y = height;
                    break;
                case '8':
                    dropframe.X = width*3;
                    dropframe.Y = height;
                    break;
                case '9':
                    dropframe.X = width*4;
                    dropframe.Y = height;
                    break;
            };      
            
            //Cắt vs frame
            CroppedBitmap cb = new CroppedBitmap(bitmapSource, dropframe);
            border.Background = new ImageBrush(cb);
        }
    }
}

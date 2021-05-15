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
            int count = 0;
            BitmapImage src = new BitmapImage(new Uri("/Image/avt2_pro.png", UriKind.Relative));
            Rectangle imagerect = new Rectangle();
           
            
            //for (int i = 0; i < 3; i++)
            //    for (int j = 0; j < 3; j++)
            //        objImg[count++] = new CroppedBitmap(src, new Int32Rect(j * 120, i * 120, 120, 120));
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            CutImage();
        }
    }
}

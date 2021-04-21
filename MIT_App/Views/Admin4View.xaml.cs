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

namespace MIT_App.Views
{
    /// <summary>
    /// Interaction logic for Admin4View.xaml
    /// </summary>
    public partial class Admin4View : Window
    {
        public Admin4View()
        {
            InitializeComponent();
        }
        private async void Answer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Border button = (Border)sender;
            await Task.Run(() => {
                Dispatcher.Invoke(() =>
                {
                    if (button.Background == Brushes.Transparent)// chưa được chọn -> chọn
                    {
                        button.Background = button.BorderBrush;
                        ((TextBlock)button.Child).Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
                    }
                    else // đã được chọn -> hủy chọn
                    {
                        button.Background = Brushes.Transparent;
                        ((TextBlock)button.Child).Foreground = button.BorderBrush;
                    }
                });

            });

            /*button.Background = new SolidColorBrush(Color.FromRgb(219, 106, 5));
            ((TextBlock)answer.Child).Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            AnswerValue = answer.Name.ToString().Trim()[6];*/
        }

    }
}

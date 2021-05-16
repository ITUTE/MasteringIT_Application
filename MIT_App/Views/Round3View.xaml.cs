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
    /// Interaction logic for Round3.xaml
    /// </summary>
    public partial class Round3View : Window
    {
        double mouseX = 0;
        double mouseY = 0;
        bool isMouseDown = false;
        public Round3View()
        {
            InitializeComponent();
            Button button = new Button();
            Canvas.SetLeft(button, 0);
            Canvas.SetTop(button, 0);
            button.Content = "Nguỹenn dgbksj ehfvh Tring Tin";
            button.FontSize = 20;
            button.MaxWidth = 200;
            button.MinHeight = 100;
            button.Template = (ControlTemplate)this.Resources["ButtonEllip"];
            button.PreviewMouseDown += Button_PreviewMouseDown;
            button.PreviewMouseMove += Button_PreviewMouseMove;
            button.PreviewMouseUp += Button_PreviewMouseUp;
            MainPage.Children.Add(button);            
        }

        private void Button_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            isMouseDown = false;
        }

        private void Button_PreviewMouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                double x = e.GetPosition(this).X - mouseX;
                double y = e.GetPosition(this).Y - mouseY;
                Button button = (Button)sender;
                double newPositionX = Canvas.GetLeft(button) + x;
                double newPositionY = Canvas.GetTop(button) + y;
                if (newPositionX + button.ActualWidth > MainPage.ActualWidth || newPositionY + button.ActualHeight > MainPage.ActualHeight || newPositionX < 0 || newPositionY < 0)
                {
                    return;
                };
                Canvas.SetLeft(button, newPositionX);
                Canvas.SetTop(button, newPositionY);
                mouseX = e.GetPosition(this).X;
                mouseY = e.GetPosition(this).Y;
            }
        }

        private void Button_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            mouseX = e.GetPosition(this).X;
            mouseY = e.GetPosition(this).Y;
            isMouseDown = true;
        }

        private void Button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            mouseX = e.GetPosition(this).X;
            mouseY = e.GetPosition(this).Y;
            isMouseDown = true;
        }

        private void Button_MouseUp(object sender, MouseButtonEventArgs e)
        {
            isMouseDown = false;
        }

        private void Button_MouseMove(object sender, MouseEventArgs e)
        {            
            if (isMouseDown)
            {
                double x = e.GetPosition(this).X - mouseX;
                double y = e.GetPosition(this).Y - mouseY;
                Button button = (Button)sender;
                double newPositionX = Canvas.GetLeft(button) + x;
                double newPositionY = Canvas.GetTop(button) + y;
                if (newPositionX + button.ActualWidth > MainPage.ActualWidth || newPositionY + button.ActualHeight > MainPage.ActualHeight || newPositionX < 0 || newPositionY < 0)
                {
                    return;
                };
                Canvas.SetLeft(button, newPositionX);
                Canvas.SetTop(button, newPositionY);
                mouseX = e.GetPosition(this).X;
                mouseY = e.GetPosition(this).Y;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace MIT_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Round1View : Window
    {
        DispatcherTimer timer; // đếm giờ
        DateTime CountdownTime; // value của bộ đếm
        float color; // màu của progressBar
        double countdownTimeQ1 = 10; // thời gian tổng của bộ đếm
        double countdownStep = 0.01; // Mỗi bước nhảy mất 0.01s

        bool CanSelectAnswer = false; // chỉ chọn Answer trong thời gian Progress chạy
        char AnswerValue = 'X'; // Answer đã chọn: mặc định X-chưa chọn

        public Round1View()
        {
            InitializeComponent();           
        }

        private void BeginQuestion()
        {
            CanSelectAnswer = true;
            ClearAnswer();
            runProgressBar();
        }

        private void runProgressBar()
        {            
            CountdownTime = new DateTime(1900, 1, 1, 00, 00, (int)countdownTimeQ1, 00);
            color = 0;
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(countdownStep);
            timer.Tick += Timer_Tick;
            timer.Start();
            ProgressBar.Width = 0;
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (ProgressBar.Width < this.Width - 40)
            {
                color += (float)(255 / (countdownTimeQ1 / countdownStep));
                byte step = Byte.Parse(((int)color).ToString());

                CountdownTime = CountdownTime.AddSeconds(-countdownStep);
                CountdownTimer.Text = CountdownTime.ToString("ss:ff");
                CountdownTimer.Foreground = new SolidColorBrush(Color.FromRgb(step, 0, 0));

                ProgressBar.Background = new SolidColorBrush(Color.FromRgb(step, 0, 0));
                ProgressBar.Width += (this.Width - 40)/ (countdownTimeQ1 / countdownStep);
            }
            else
            {
                CanSelectAnswer = false;
                timer.Stop();
            }
        }

        private async Task ClearAnswer()
        {
            await Task.Run(() =>
            {
                AnswerValue = 'X';
                Dispatcher.Invoke(() =>
                {
                    AnswerA.Background = Brushes.Transparent;
                    AnswerB.Background = Brushes.Transparent;
                    AnswerC.Background = Brushes.Transparent;
                    AnswerD.Background = Brushes.Transparent;
                });

            });
        }

        private async void Answer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (CanSelectAnswer)
            {
                await ClearAnswer();
                await Task.Run(() =>
                {
                    Border answer = (Border)sender;
                    Dispatcher.Invoke(() =>
                    {
                        answer.Background = new SolidColorBrush(Color.FromRgb(141, 210, 138));
                        AnswerValue = answer.Name.ToString().Trim()[6];
                    });
                });

            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            BeginQuestion();
        }
    }
}

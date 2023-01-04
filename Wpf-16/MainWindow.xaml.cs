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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_16
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void but1_Click(object sender, RoutedEventArgs e)
        {
            //DoubleAnimation doubleAnimation = new DoubleAnimation();
            ////doubleAnimation.From = 100;
            //doubleAnimation.To = 300;
            ////doubleAnimation.By = 200;
            ////doubleAnimation.AccelerationRatio = 0.5;
            ////doubleAnimation.SpeedRatio = 0.5;
            ////doubleAnimation.AutoReverse = true;
            ////doubleAnimation.RepeatBehavior= new RepeatBehavior(TimeSpan.FromSeconds(6));
            //doubleAnimation.FillBehavior = FillBehavior.HoldEnd;
            //doubleAnimation.Duration = TimeSpan.FromSeconds(2);
            //but1.BeginAnimation(Button.WidthProperty, doubleAnimation);
            //but1.BeginAnimation(Button.HeightProperty, doubleAnimation);
            //ColorAnimation colorAnimation= new ColorAnimation();
            //colorAnimation.From = Colors.Red;
            //colorAnimation.To = Colors.Green;
            //colorAnimation.Duration = TimeSpan.FromSeconds(2);
            //but1.Background= new SolidColorBrush(Colors.White);
            //but1.Background.BeginAnimation(SolidColorBrush.ColorProperty, colorAnimation);

        }
    }
}

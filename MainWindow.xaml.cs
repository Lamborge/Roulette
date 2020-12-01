using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Threading;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Rulette
{
   
    public partial class MainWindow : Window
    {

        int[] nums = new int[3];
        bool win;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SpinB_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();

            nums[0] = rnd.Next(10);
            nums[1] = rnd.Next(10);
            nums[2] = rnd.Next(10);
            N1.Text = Convert.ToString(nums[0]);
            N2.Text = Convert.ToString(nums[1]);
            N3.Text = Convert.ToString(nums[2]);

            if (nums[0] == nums[1] && nums[1] == nums[2])
            {
                win = true;
            }
            else
            {
                win = false;
            }

            if (!win)
            {
                ResText.Text = "You lose!";
                ResText.Foreground = new SolidColorBrush(Color.FromRgb(200, 0, 0));
            }
            else if (win)
            {
                ResText.Text = "You win!";
                ResText.Foreground = new SolidColorBrush(Color.FromRgb(0, 222, 48));
            }
            
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            Grid.Background = new SolidColorBrush(Color.FromRgb(31, 31, 31));
            N1.Foreground = Brushes.White;
            N2.Foreground = Brushes.White;
            N3.Foreground = Brushes.White;
            DarkTheme.Foreground = Brushes.White;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Grid.Background = Brushes.White;
            N1.Foreground = Brushes.Black;
            N2.Foreground = Brushes.Black;
            N3.Foreground = Brushes.Black;
            DarkTheme.Foreground = Brushes.Black;
        }
    }
}

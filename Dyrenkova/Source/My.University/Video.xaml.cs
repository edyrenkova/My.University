using System;
using System.Media;
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

namespace My.University
{
    /// <summary>
    /// Логика взаимодействия для Video.xaml
    /// </summary>
    public partial class Video : Window
    {
        public Video()
        {
            InitializeComponent();
        }

        private void grad_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void textBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Uri uri = new Uri("https://www.youtube.com/results?search_query="+textBox.Text);
            wb_video.Source = uri;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("https://www.youtube.com/results?search_query=" + textBox.Text);
            wb_video.Source = uri;
            
        }
    }
}

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

namespace My.University
{
    /// <summary>
    /// Логика взаимодействия для AboutAuthor.xaml
    /// </summary>
    public partial class AboutAuthor : Window
    {
        public AboutAuthor()
        {
            InitializeComponent();
        }
      
        private void Image_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Hide();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}

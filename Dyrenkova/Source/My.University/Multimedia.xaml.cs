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
    /// Interaction logic for Multimedia.xaml
    /// </summary>
    public partial class Multimedia : Window
    {
        public Multimedia()
        {
            InitializeComponent();
        }

        private void Multi_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Photo ph = new Photo();
            ph.Show();
            this.Hide();
        }
    }
}

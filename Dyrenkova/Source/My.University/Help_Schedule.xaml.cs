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
using System.Windows.Xps.Packaging;

namespace My.University
{
    /// <summary>
    /// Логика взаимодействия для Help_Schedule.xaml
    /// </summary>
    public partial class Help_Schedule : Window
    {
        public Help_Schedule()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            XpsDocument doc = new XpsDocument(Environment.CurrentDirectory + "\\help\\schedule_help.xps", FileAccess.Read);
            documentViewer.Document = doc.GetFixedDocumentSequence();
        }
    }
}

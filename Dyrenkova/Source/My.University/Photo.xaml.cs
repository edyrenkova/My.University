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
using System.Data.OleDb;
using System.Data;


namespace My.University
{
    /// <summary>
    /// Interaction logic for Photo.xaml
    /// </summary>
    public partial class Photo : Window
    {
        public Photo()
        {
            InitializeComponent();
        }
        DirectoryInfo di = new DirectoryInfo(Settings.gallery_folder_name);
        ImageSourceConverter converter = new ImageSourceConverter();
        List<FileInfo> files = new List<FileInfo>();
        List<string> people = new List<string>();
        int n = 1;
        int nmax = 0;
        
        private void Window_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btn_left_Click(object sender, RoutedEventArgs e)
        {
            if (n == 2)
            {
                btn_left.Visibility = Visibility.Hidden;
            }
                btn_right.Visibility = Visibility.Visible;
                n--;
                img_main.Source = (ImageSource)converter.ConvertFromString(Settings.gallery_folder_name+"\\" + textBlock1.Text + n.ToString() + ".jpg");
            
        }

        private void grad_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string[] text = File.ReadAllLines(Settings.gallery_folder_name + "\\people.txt");
            btn_right.Visibility = Visibility.Visible;
            btn_left.Visibility = Visibility.Hidden;
            nmax = 0;
            n = 1;
            textBlock1.Text = people[listBox.SelectedIndex];
            img_main.Source = (ImageSource)converter.ConvertFromString(Settings.gallery_folder_name + "\\" +textBlock1.Text+n.ToString()+".jpg");
            for (int i = 0; i < di.GetFiles().Count(); i++)
            {
                if (di.GetFiles()[i].Name.Contains(textBlock1.Text))
                {
                    nmax++;
                }
            }
            for (int i = 0; i < text.Count(); i++)
            {
                if ((text[i]+" ") == textBlock1.Text)
                {
                    textBlock2.Text = text[i + 1];
                    break;
                }
            }
        }

        private void btn_right_Click(object sender, RoutedEventArgs e)
        {

            if (n == nmax - 1)
            {
                btn_right.Visibility = Visibility.Hidden;
            }
                n++;
                btn_left.Visibility = Visibility.Visible;
            img_main.Source = (ImageSource)converter.ConvertFromString(Settings.gallery_folder_name + "\\" + textBlock1.Text + n.ToString() + ".jpg");
           
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            listBox.SelectedIndex = 0;
            files = di.GetFiles().ToList();
            for (int i = 0; i < files.Count; i++)
            {
                string a = files[i].Name.Remove(files[i].Name.Length - 5);
                if(files[i].Name.Contains("1"))
                people.Add(a);

            }
            for (int i = 0; i <people.Count; i++)
            {
                ImageSourceConverter converter = new ImageSourceConverter();
                string path1 = Settings.gallery_folder_name + "\\" + people[i] + "1.jpg";
                listBox.Items.Add(new Image() { Source = (ImageSource)converter.ConvertFromString(path1), Height=175, Stretch=Stretch.Uniform });

            }
           

        }
    }
}

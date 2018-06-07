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
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace My.University
{
    /// <summary>
    /// Логика взаимодействия для News.xaml
    /// </summary>
    public partial class News : Window
    {
        public News()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        private void grad_MouseDown(object sender, MouseButtonEventArgs e)
        {
            wb_socnet.Source = null;
            Menu m = new Menu();
            m.Visibility=Visibility.Visible;
            this.Hide();
        }

        private void w_News_Loaded(object sender, RoutedEventArgs e)
        {
            tv_item1.IsSelected = true;
            string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"" + Settings.public_db_name + "\"";
            string CommandText = "SELECT Univ_in_social_net.Name_net, Univ_in_social_net.Address, Social_networks.Picture FROM Social_networks INNER JOIN Univ_in_social_net ON Social_networks.Name_social_net = Univ_in_social_net.Name_net";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, ConnectionString);
            dataAdapter.Fill(ds, "social_networks");
            List<Image> icons = new List<Image>();
            for (int i = 0; i < ds.Tables["social_networks"].Rows.Count; i++)
            {
                Image img = new Image();
                ImageSourceConverter imgsc = new ImageSourceConverter();
                img.Source = (ImageSource)imgsc.ConvertFromString(Settings.public_folder_name + "\\" + ds.Tables["social_networks"].Rows[i].ItemArray[2].ToString());
                img.Stretch = Stretch.Uniform;
                img.Cursor = Cursors.Hand;
                img.Margin = new Thickness(15, 25, 15, 25);
                img.ToolTip = ds.Tables["social_networks"].Rows[i].ItemArray[1].ToString();
                img.MouseDown += new MouseButtonEventHandler(img_MouseDown);
                icons.Add(img);
                stp_icons.Children.Add(icons[i]);
            }
            
        }
            private void img_MouseDown(object sender, RoutedEventArgs e)
        {
            wb_socnet.Visibility = Visibility.Visible;
            Image img = e.Source as Image;
            wb_socnet.Source = new Uri(img.ToolTip.ToString());
            image.Visibility = Visibility.Collapsed;
        }
        private void w_News_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
            
        }
        private void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            try
            {
                if (tv_univ.SelectedItem != null)
                {

                    TreeViewItem tvi = new TreeViewItem();
                    tvi = (TreeViewItem)tv_univ.SelectedItem;
                    string s = tvi.Header.ToString();
                    wb_docs.Navigate(Settings.top_folder_name + "\\" + s + ".htm");
                    

                }
            }
            catch {}
        }
    }
}

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

namespace My.University
{
    /// <summary>
    /// Логика взаимодействия для Addresses.xaml
    /// </summary>
    public partial class Addresses : Window
    {
        public Addresses()
        {
            InitializeComponent();
        }
        string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"" + Settings.campus_db_name + "\"";
        string CommandText;
        DataTable dt = new DataTable();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.Title = Libraries.table;
            dt.Clear();
            switch (Libraries.table)
            {
                case "Libraries":
                    CommandText = "SELECT libraries.Name_lib, libraries.PhoneNumber_lib, libraries.Address, libraries.Hours_of_work FROM libraries";
                    lbl_type.Text = "Libraries";
                    break;
                case "Colleges":
                    CommandText = "SELECT Schools_and_Colleges.Name_sch, Schools_and_Colleges.Phone_num_office, Schools_and_Colleges.Address_office, Schools_and_Colleges.About_school FROM Schools_and_Colleges";
                    lbl_type.Text = "Colleges";
                    label_Copy2.FontSize = 20;
                    ImageSourceConverter im = new ImageSourceConverter();
                    image_Copy1.Source = null;
                    image_Copy1.Source = (ImageSource)(im.ConvertFromString(Environment.CurrentDirectory+"\\other\\certificate.png"));
                    break;
                case "Hospitals":
                    CommandText = "SELECT Hospitals.Name_h, Hospitals.Phone_num, Hospitals.Address, Hospitals.Hours_of_work FROM Hospitals";
                    lbl_type.Text = "Hospitals";
                    break;
                case "Shops and Cafes":
                    CommandText = "SELECT shops.Name_, shops.PhoneNumber_, shops.Address_, shops.Hours_of_work FROM shops";
                    lbl_type.Text = "Shops and Cafes";
                    break;
            }
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, ConnectionString);
            dataAdapter.Fill(dt);
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                listBox.Items.Add(dt.Rows[i].ItemArray[0]);
            }
            if (listBox.SelectedIndex != -1)
            {
                label.Text = listBox.SelectedItem.ToString();
                label_Copy.Content = dt.Rows[listBox.SelectedIndex].ItemArray[1].ToString();
                label_Copy1.Text = dt.Rows[listBox.SelectedIndex].ItemArray[2].ToString();
                label_Copy2.Text = dt.Rows[listBox.SelectedIndex].ItemArray[3].ToString();
            }
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            label.Text = listBox.SelectedItem.ToString();
            label_Copy.Content = dt.Rows[listBox.SelectedIndex].ItemArray[1].ToString();
            label_Copy1.Text = dt.Rows[listBox.SelectedIndex].ItemArray[2].ToString();
            label_Copy2.Text = dt.Rows[listBox.SelectedIndex].ItemArray[3].ToString();

        }
    }
}

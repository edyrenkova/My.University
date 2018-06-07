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
using AcroPDFLib;


namespace My.University
{
    /// <summary>
    /// Логика взаимодействия для Libraries.xaml
    /// </summary>
    public partial class Libraries : Window
    {
        public Libraries()
        {
            InitializeComponent();
        }
        public static string table;
        private void grad_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();
        }

        private void Campus_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void library_MouseDown(object sender, MouseButtonEventArgs e)
        {
            table = "Libraries";
            Addresses a = new Addresses();
            a.ShowDialog();
        }
        
        private void hospital_MouseDown(object sender, MouseButtonEventArgs e)
        {
            table = "Hospitals";
            Addresses a = new Addresses();
            a.ShowDialog();
        }

        private void school_MouseDown(object sender, MouseButtonEventArgs e)
        {
            table = "Colleges";
            Addresses a = new Addresses();
            a.ShowDialog();
        }

        private void shop_MouseDown(object sender, MouseButtonEventArgs e)
        {
            table = "Shops and Cafes";
            Addresses a = new Addresses();
            a.ShowDialog();
        }
    }
    }


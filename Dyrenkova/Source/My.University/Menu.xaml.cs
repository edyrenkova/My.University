﻿using System;
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
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

       
        private void w_menu_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Photo ph = new Photo();
            ph.Show();
            this.Hide();
        }

        private void Rectangle_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            Schedule2 sch = new Schedule2();
            sch.Show();
            this.Hide();
        }

        private void Rectangle_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            News n = new News();
            n.Show();
            this.Hide();
        }

        private void Rectangle_MouseDown_4(object sender, MouseButtonEventArgs e)
        {
            Libraries l = new Libraries();
            l.Show();
            this.Hide();
        }
        private void grad_MouseDown(object sender, MouseButtonEventArgs e)
        {
            AboutAuthor aa = new AboutAuthor();
            aa.Show();
            this.Hide();
        }

        private void Rectangle_MouseDown_6(object sender, MouseButtonEventArgs e)
        {
            Settings s = new Settings();
            s.Show();
            this.Hide();
        }

        private void w_menu_Loaded(object sender, RoutedEventArgs e)
        {
            ImageSourceConverter im = new ImageSourceConverter();
            image.Source= (ImageSource)(im.ConvertFromString(Environment.CurrentDirectory + "\\other\\logo.jpg"));
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}

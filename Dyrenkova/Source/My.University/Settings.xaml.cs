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
using System.Windows.Forms;

namespace My.University
{
    /// <summary>
    /// Логика взаимодействия для Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        public Settings()
        {
            InitializeComponent();
        }
        public static string schedule_db_name = Environment.CurrentDirectory + "\\schedule.mdb";
        public static string gallery_folder_name = Environment.CurrentDirectory + "\\famous_alumni";
        public static string top_folder_name = Environment.CurrentDirectory + "\\top_universities";
        public static string campus_db_name = Environment.CurrentDirectory + "\\schedule.mdb";
        public static string public_db_name = Environment.CurrentDirectory + "\\schedule.mdb";
        public static string public_folder_name = Environment.CurrentDirectory + "\\social_networks_icons";
        public static string schedule_save_folder_name = Environment.CurrentDirectory;
        public static string icon_name = Environment.CurrentDirectory + "\\other\\logo.jpg";
        private void grad_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
           System.Windows.Application.Current.Shutdown();
        }

        private void schedule_db_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Access 2000-2003 (*.mdb)|*.mdb";
            op.InitialDirectory = schedule_db_name;
            if (op.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                schedule_db_name = op.FileName;
                schedule_db.Text = schedule_db_name;
            }
        }

        private void alumni_dir_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.ValidateNames = false; op.CheckFileExists = false;
            op.FileName = "Folder Selection";
            op.InitialDirectory = gallery_folder_name;
            if (op.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gallery_folder_name = op.FileName.Remove(op.FileName.Length - 17, 17);
                alumni_dir.Text = gallery_folder_name;
            }

        }

        private void campus_db_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Access 2000-2003 (*.mdb)|*.mdb";
            op.InitialDirectory = campus_db_name;
            if (op.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                campus_db_name = op.FileName;
                campus_db.Text = campus_db_name;
            }
        }

        private void net_db_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Access 2000-2003 (*.mdb)|*.mdb";
            op.InitialDirectory =public_db_name;
            if (op.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                public_db_name = op.FileName;
                net_db.Text = public_db_name;
            }
        }

        private void top_dir_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.ValidateNames = false; op.CheckFileExists = false;
            op.FileName = "Folder Selection";
            op.InitialDirectory = top_folder_name;
            if (op.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                top_folder_name = op.FileName.Remove(op.FileName.Length - 17, 17);
                top_dir.Text = top_folder_name;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            top_dir.Text = top_folder_name;
            net_db.Text = public_db_name;
            campus_db.Text = campus_db_name;
            alumni_dir.Text = gallery_folder_name;
            schedule_db.Text = schedule_db_name;
            schedule_save_folder.Text = schedule_save_folder_name;
            icon_picture.Text = icon_name;
        }
        private void schedule_save_Copy_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.ValidateNames = false; op.CheckFileExists = false;
            op.FileName = "Folder Selection";
            op.InitialDirectory = schedule_save_folder_name;
            if (op.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                schedule_save_folder_name = op.FileName.Remove(op.FileName.Length - 17, 17);
                schedule_save_folder.Text = schedule_save_folder_name;
            }
        }

        private void icon_picture_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            op.InitialDirectory = public_db_name;
            if (op.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                icon_name = op.FileName;
                icon_picture.Text = icon_name;
            }

        }
    }
}

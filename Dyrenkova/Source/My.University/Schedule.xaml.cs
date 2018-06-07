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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Data.OleDb;

namespace My.University
{
    /// <summary>
    /// Логика взаимодействия для Schedule.xaml
    /// </summary>
    public partial class Schedule : Window
    {
        public Schedule()
        {
            InitializeComponent();
        }
        static string CommandText = "";
        static string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"" + Environment.CurrentDirectory.ToString() + "\\kval1.mdb\"";
        OleDbDataAdapter dataAdapter =
new OleDbDataAdapter(CommandText, ConnectionString);
        DataSet ds = new DataSet();
        List<Lesson> result = new List<Lesson>();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            ds.Tables.Add("curriculum");
            dataGrid2.Columns.Add(new DataGridCheckBoxColumn());
            CommandText = "SELECT specialties.Code FROM specialties WHERE(((specialties.type) = 'major'))";
            OleDbDataAdapter dataAdapter =
new OleDbDataAdapter(CommandText, ConnectionString);
            dataAdapter.Fill(ds, "specialties");
            for (int i = 0; i < ds.Tables["specialties"].Rows.Count; i++)
            {
                ComboBoxItem cmb = new ComboBoxItem();
                cmb.Content = ds.Tables["specialties"].Rows[i].ItemArray.GetValue(0).ToString();
                cmb_major.Items.Add(cmb);
            }

            dataAdapter.SelectCommand.CommandText = "SELECT specialties.Code FROM specialties WHERE(((specialties.type) = 'minor'))";
            ds.Clear();
            dataAdapter.Fill(ds, "specialties");
            for (int i = 0; i < ds.Tables["specialties"].Rows.Count; i++)
            {
                ComboBoxItem cmb = new ComboBoxItem();
                cmb.Content = ds.Tables["specialties"].Rows[i].ItemArray.GetValue(0).ToString();
                cmb_minor.Items.Add(cmb);
            }


        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }



        private void button_Click(object sender, RoutedEventArgs e)
        {
            ds.Clear();
            string CommandText1 = "SELECT specialties.Code, directions.name_d, credits.credits FROM specialties INNER JOIN (directions INNER JOIN credits ON directions.code_d = credits.direction) ON specialties.Code = credits.specialty WHERE (((specialties.Code) = '" + cmb_major.Text + "'))";
            string CommandText = "SELECT specialties.Code, directions.name_d, credits.credits FROM specialties INNER JOIN (directions INNER JOIN credits ON directions.code_d = credits.direction) ON specialties.Code = credits.specialty WHERE (((specialties.Code) = '" + cmb_minor.Text + "'))";
            OleDbDataAdapter dataAdapter1 =
new OleDbDataAdapter(CommandText1, ConnectionString);
            OleDbDataAdapter dataAdapter =
new OleDbDataAdapter(CommandText, ConnectionString);
            dataAdapter.Fill(ds, "specialties");
            dataAdapter1.Fill(ds, "specialties");
            dataGrid.ItemsSource = ds.Tables["specialties"].DefaultView;

        }

        private void grad_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();
            
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                ds.Tables["curriculum"].Clear();
                if (dataGrid.SelectedCells != null)
                {
                    DataGridCellInfo dgci = new DataGridCellInfo(dataGrid.Items[dataGrid.SelectedIndex], dataGrid.Columns[1]);
                    var item = dgci.Column.GetCellContent(dgci.Item) as TextBlock;
                    string CommandText = "SELECT directions.name_d, subjects.Name_cl, curriculum.Day, curriculum.time_start, curriculum.time_end, curriculum.type, curriculum.Address, Teachers.Name_teacher FROM Teachers INNER JOIN (directions INNER JOIN(subjects INNER JOIN curriculum ON subjects.Code = curriculum.code_class) ON directions.code_d = subjects.direction) ON Teachers.Code = curriculum.teacher WHERE(((directions.name_d) = '" + item.Text + "'));";
                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, ConnectionString);
                    dataAdapter.Fill(ds, "curriculum");
                    dataGrid2.ItemsSource = ds.Tables["curriculum"].DefaultView;

                }
            }
            catch (ArgumentException) { }
        }

        private void button3_Click_1(object sender, RoutedEventArgs e)
        {
            dataGrid1.ItemsSource = "";
            if (dataGrid2.Items.Count > 0)
            {
                for (int i = 0; i < dataGrid2.Items.Count; i++)
                {
                    DataGridCellInfo dir2 = new DataGridCellInfo(dataGrid2.Items[i], dataGrid2.Columns[0]);
                    var chb = dir2.Column.GetCellContent(dir2.Item) as CheckBox;
                    if (chb.IsChecked == true)
                    {
                        DataGridCellInfo inamed = new DataGridCellInfo(dataGrid2.Items[i], dataGrid2.Columns[1]);
                        DataGridCellInfo iname = new DataGridCellInfo(dataGrid2.Items[i], dataGrid2.Columns[2]);
                        DataGridCellInfo iday = new DataGridCellInfo(dataGrid2.Items[i], dataGrid2.Columns[3]);
                        DataGridCellInfo itime_start = new DataGridCellInfo(dataGrid2.Items[i], dataGrid2.Columns[4]);
                        DataGridCellInfo itime_end = new DataGridCellInfo(dataGrid2.Items[i], dataGrid2.Columns[5]);
                        DataGridCellInfo itype = new DataGridCellInfo(dataGrid2.Items[i], dataGrid2.Columns[6]);
                        DataGridCellInfo iaddress = new DataGridCellInfo(dataGrid2.Items[i], dataGrid2.Columns[7]);
                        DataGridCellInfo iteacher = new DataGridCellInfo(dataGrid2.Items[i], dataGrid2.Columns[8]);
                        var name = iname.Column.GetCellContent(iname.Item) as TextBlock;
                        var named = inamed.Column.GetCellContent(iname.Item) as TextBlock;
                        var day = iday.Column.GetCellContent(iday.Item) as TextBlock;
                        var time_start = itime_start.Column.GetCellContent(itime_start.Item) as TextBlock;
                        var time_end = itime_end.Column.GetCellContent(itime_end.Item) as TextBlock;
                        var type = itype.Column.GetCellContent(itype.Item) as TextBlock;
                        var address = iaddress.Column.GetCellContent(iaddress.Item) as TextBlock;
                        var teacher = iteacher.Column.GetCellContent(iteacher.Item) as TextBlock;
                       // result.Add(new Lesson(named.Text, name.Text, day.Text, time_start.Text, time_end.Text, type.Text, address.Text, teacher.Text));
                    }
                }

                dataGrid1.ItemsSource = result;
            }
        }

        private void dataGrid1_LoadingRow_1(object sender, DataGridRowEventArgs e)
        {
            //for (int j = 0; j < result.Count; j++)
            //{
            //    if (result[e.Row.GetIndex()].Name == result[j].Name && result[e.Row.GetIndex()].Type == result[j].Type && e.Row.GetIndex() != j)
            //    {
            //        e.Row.Background = Brushes.Red;
            //    }
            //    else
            //    if ((result[e.Row.GetIndex()].Day == result[j].Day && e.Row.GetIndex() != j))
            //    {
            //        DateTime dtstarti = new DateTime(2000, 10, 1, result[e.Row.GetIndex()].time_startHH, result[e.Row.GetIndex()].time_startMM, 0);
            //        DateTime dtendi = new DateTime(2000, 10, 1, result[e.Row.GetIndex()].time_endHH, result[e.Row.GetIndex()].time_endMM, 0);
            //        DateTime dtstartj = new DateTime(2000, 10, 1, result[j].time_startHH, result[j].time_startMM, 0);
            //        DateTime dtendj = new DateTime(2000, 10, 1, result[j].time_endHH, result[j].time_endMM, 0);
            //        if (dtstarti == dtstartj || (dtstarti > dtstartj && dtstarti < dtendj) || (dtstartj > dtstarti && dtstartj < dtendi))
            //        {
            //            e.Row.Background = Brushes.Red;
            //        }
            //    }

            }
        }
    }

    



        

        
  
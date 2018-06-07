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
    /// Логика взаимодействия для Subject.xaml
    /// </summary>
    public partial class Subject : Window
    {
        public Subject()
        {
            InitializeComponent();
        }
        DataSet ds1 = new DataSet();
        public static string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"" + Settings.schedule_db_name + "\"";
        public static List<Lesson> result = new List<Lesson>();

        private void subject_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                string CmTxtDescr = "SELECT subjects.Name_cl, subjects.Credits, subjects.description_, curriculum.day_, curriculum.time_start, curriculum.time_end, Teachers.Name_teacher, curriculum.Address, curriculum.section_ FROM Teachers INNER JOIN (subjects INNER JOIN curriculum ON subjects.Code = curriculum.code_class) ON Teachers.Code = curriculum.teacher WHERE(((subjects.Name_cl) = '" + Schedule2.selected_sub + "'))";
                string CmTxtCur = "SELECT subjects.Name_cl, curriculum.day_, curriculum.time_start, curriculum.time_end, Teachers.Name_teacher, curriculum.Address, curriculum.section_ FROM Teachers INNER JOIN (subjects INNER JOIN curriculum ON subjects.Code = curriculum.code_class) ON Teachers.Code = curriculum.teacher WHERE(((subjects.Name_cl) = '" + Schedule2.selected_sub + "'))";
                OleDbDataAdapter DaDescr = new OleDbDataAdapter(CmTxtDescr, ConnectionString);
                OleDbDataAdapter DaCur = new OleDbDataAdapter(CmTxtCur, ConnectionString);
                DaDescr.Fill(ds1, "descriptions");
                DaCur.Fill(ds1, "curriculum");
                string name = ds1.Tables["descriptions"].Rows[0].ItemArray[0].ToString();
                string credit = ds1.Tables["descriptions"].Rows[0].ItemArray[1].ToString();
                string descr = ds1.Tables["descriptions"].Rows[0].ItemArray[2].ToString();
                lbl_name.Text = name + " (" + credit + ")";
                txtb_descripton.Text = descr;
                dataGrid_cur.ItemsSource = ds1.Tables["curriculum"].DefaultView;
                dataGrid_cur.Columns[0].Header = "Name of the course";
                dataGrid_cur.Columns[0].Width = DataGridLength.SizeToCells;
                dataGrid_cur.Columns[1].Header = "Day of week";
                dataGrid_cur.Columns[2].Header = "Time of the beginning";
                dataGrid_cur.Columns[3].Header = "Time of the end";
                dataGrid_cur.Columns[4].Header = "Name of the teacher";
                dataGrid_cur.Columns[5].Header = "Address";
                dataGrid_cur.Columns[6].Header = "Section";
            }
            catch (IndexOutOfRangeException) { }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Schedule2.dg.ItemsSource = "";
            DataGridCellInfo iname = new DataGridCellInfo(dataGrid_cur.Items[dataGrid_cur.SelectedIndex], dataGrid_cur.Columns[0]);
            DataGridCellInfo iday = new DataGridCellInfo(dataGrid_cur.Items[dataGrid_cur.SelectedIndex], dataGrid_cur.Columns[1]);
            DataGridCellInfo itime_start = new DataGridCellInfo(dataGrid_cur.Items[dataGrid_cur.SelectedIndex], dataGrid_cur.Columns[2]);
            DataGridCellInfo itime_end = new DataGridCellInfo(dataGrid_cur.Items[dataGrid_cur.SelectedIndex], dataGrid_cur.Columns[3]);
            DataGridCellInfo iaddress = new DataGridCellInfo(dataGrid_cur.Items[dataGrid_cur.SelectedIndex], dataGrid_cur.Columns[5]);
            DataGridCellInfo isection = new DataGridCellInfo(dataGrid_cur.Items[dataGrid_cur.SelectedIndex], dataGrid_cur.Columns[6]);
            DataGridCellInfo iteacher = new DataGridCellInfo(dataGrid_cur.Items[dataGrid_cur.SelectedIndex], dataGrid_cur.Columns[4]);
            var namee = iname.Column.GetCellContent(iname.Item) as TextBlock;
            var day = iday.Column.GetCellContent(iday.Item) as TextBlock;
            var time_start = itime_start.Column.GetCellContent(itime_start.Item) as TextBlock;
            var time_end = itime_end.Column.GetCellContent(itime_end.Item) as TextBlock;
            var address = iaddress.Column.GetCellContent(iaddress.Item) as TextBlock;
            var teacher = iteacher.Column.GetCellContent(iteacher.Item) as TextBlock;
            var section = isection.Column.GetCellContent(isection.Item) as TextBlock;
            for (int i = 0; i < dataGrid_cur.Items.Count; i++)
            {
                DataGridCellInfo iname1 = new DataGridCellInfo(dataGrid_cur.Items[i], dataGrid_cur.Columns[0]);
                var namee1 = iname1.Column.GetCellContent(iname1.Item) as TextBlock;
                DataGridCellInfo iday1 = new DataGridCellInfo(dataGrid_cur.Items[i], dataGrid_cur.Columns[1]);
                var day1 = iday1.Column.GetCellContent(iday1.Item) as TextBlock;
                DataGridCellInfo isection1 = new DataGridCellInfo(dataGrid_cur.Items[i], dataGrid_cur.Columns[6]);
                var section1 = isection1.Column.GetCellContent(isection1.Item) as TextBlock;
                if (namee.Text==namee1.Text && section.Text==section1.Text && day.Text != day1.Text)
                {
                    DataGridCellInfo itime_start1 = new DataGridCellInfo(dataGrid_cur.Items[i], dataGrid_cur.Columns[2]);
                    DataGridCellInfo itime_end1 = new DataGridCellInfo(dataGrid_cur.Items[i], dataGrid_cur.Columns[3]);
                    DataGridCellInfo iaddress1 = new DataGridCellInfo(dataGrid_cur.Items[i], dataGrid_cur.Columns[5]);
                    DataGridCellInfo iteacher1 = new DataGridCellInfo(dataGrid_cur.Items[i], dataGrid_cur.Columns[4]);
                    var time_start1 = itime_start1.Column.GetCellContent(itime_start1.Item) as TextBlock;
                    var time_end1 = itime_end1.Column.GetCellContent(itime_end1.Item) as TextBlock;
                    var address1 = iaddress1.Column.GetCellContent(iaddress1.Item) as TextBlock;
                    var teacher1 = iteacher1.Column.GetCellContent(iteacher1.Item) as TextBlock;
                    result.Add(new Lesson(namee1.Text, day1.Text, time_start1.Text, time_end1.Text, address1.Text, teacher1.Text, section1.Text));
                }
            }
            result.Add(new Lesson(namee.Text, day.Text, time_start.Text, time_end.Text, address.Text, teacher.Text, section.Text));
            Schedule2.dg.ItemsSource = result;
            Schedule2.dg.Columns[0].Header = "Name of the course";
            Schedule2.dg.Columns[0].Width = DataGridLength.SizeToCells;
            Schedule2.dg.Columns[1].Header = "Section";
            Schedule2.dg.Columns[2].Header = "Day of week";
            Schedule2.dg.Columns[3].Header = "Time of the beginning";
            Schedule2.dg.Columns[4].Header = "Time of the end";
            Schedule2.dg.Columns[5].Header = "Address";
            Schedule2.dg.Columns[6].Header = "Name of the teacher";
        }
    }
}

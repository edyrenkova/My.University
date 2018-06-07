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
using Microsoft.Office.Interop.Word;
using System.IO;
using System.Windows.Xps.Packaging;


namespace My.University
{
    /// <summary>
    /// Логика взаимодействия для Schedule2.xaml
    /// </summary>
    public partial class Schedule2 : System.Windows.Window
    {
        public Schedule2()
        {
            InitializeComponent();
        }
        public static int n = 0;
        public string ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"" + Settings.schedule_db_name + "\"";
        static DataSet ds = new DataSet();
        public static string selected_sub;
        public static DataGrid dg = new DataGrid();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ds.Tables.Clear();
            ds.Tables.Add("directions1");
            ds.Tables.Add("directions2");
            dg = dataGrid;
            string CommandText = "";
            cmb_major.Items.Add(new ComboBoxItem());
            cmb_major.Items[0] = "No major";
            cmb_minor.Items.Add(new ComboBoxItem());
            cmb_minor.Items[0] = "No minor";
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
            System.Windows.Application.Current.Shutdown();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            
            trv_req.Items.Clear();
            ds.Tables["directions1"].Clear();
            ds.Tables["directions2"].Clear();
            string ComTxtMajor = "SELECT specialties.Code, directions.Name_of_a_direction, directions.Credit_hours FROM subjects INNER JOIN (specialties INNER JOIN(directions INNER JOIN[direction-subject] ON directions.Code = [direction-subject].code_dir) ON specialties.Code = directions.Specialty_code) ON subjects.Code = [direction-subject].code_sub GROUP BY specialties.Code, directions.Name_of_a_direction, directions.Credit_hours HAVING(((specialties.Code) = '" + cmb_major.Text + "'))";
            string ComTxtMinor = "SELECT specialties.Code, directions.Name_of_a_direction, directions.Credit_hours FROM subjects INNER JOIN (specialties INNER JOIN(directions INNER JOIN[direction-subject] ON directions.Code = [direction-subject].code_dir) ON specialties.Code = directions.Specialty_code) ON subjects.Code = [direction-subject].code_sub GROUP BY specialties.Code, directions.Name_of_a_direction, directions.Credit_hours HAVING(((specialties.Code) = '" + cmb_minor.Text + "'))";
            OleDbDataAdapter DaMajor = new OleDbDataAdapter(ComTxtMajor, ConnectionString);
            OleDbDataAdapter DaMinor = new OleDbDataAdapter(ComTxtMinor, ConnectionString);
            DaMajor.Fill(ds, "directions1");
            DaMinor.Fill(ds, "directions2");
            TreeViewItem trv_major = new TreeViewItem() { Header = cmb_major.Text };
            TreeViewItem trv_minor = new TreeViewItem() { Header = cmb_minor.Text };
            
            for (int i = 0; i < ds.Tables["directions1"].Rows.Count; i++)
            {
                TreeViewItem trvi1 = new TreeViewItem();
                string a = ds.Tables["directions1"].Rows[i].ItemArray[1].ToString();
                trvi1.Header = ds.Tables["directions1"].Rows[i].ItemArray[1] + " (" + ds.Tables["directions1"].Rows[i].ItemArray[2] + ")";
                string ComTxtSub = "SELECT directions.Name_of_a_direction, subjects.Name_cl, subjects.Credits FROM subjects INNER JOIN (specialties INNER JOIN(directions INNER JOIN[direction-subject] ON directions.Code = [direction-subject].code_dir) ON specialties.Code = directions.Specialty_code) ON subjects.Code = [direction-subject].code_sub GROUP BY directions.Name_of_a_direction, subjects.Name_cl, subjects.Credits HAVING(((directions.Name_of_a_direction) = '" + a + "'))";
                OleDbDataAdapter DaTrV = new OleDbDataAdapter(ComTxtSub, ConnectionString);
                DaTrV.Fill(ds, "children-courses");
                for (int j = 0; j < ds.Tables["children-courses"].Rows.Count; j++)
                {
                    trvi1.Items.Add(new TreeViewItem() { Header = ds.Tables["children-courses"].Rows[j].ItemArray[1].ToString() + " (" + ds.Tables["children-courses"].Rows[j].ItemArray[2].ToString() + ")" });
                }
                trv_major.Items.Add(trvi1);
                ds.Tables["children-courses"].Clear();
            }
            for (int i = 0; i < ds.Tables["directions2"].Rows.Count; i++)
            {
                TreeViewItem trvi1 = new TreeViewItem();
                string a = ds.Tables["directions2"].Rows[i].ItemArray[1].ToString();
                trvi1.Header = ds.Tables["directions2"].Rows[i].ItemArray[1] + " (" + ds.Tables["directions2"].Rows[i].ItemArray[2] + ")";
                string ComTxtSub = "SELECT directions.Name_of_a_direction, subjects.Name_cl, subjects.Credits FROM subjects INNER JOIN (specialties INNER JOIN(directions INNER JOIN[direction-subject] ON directions.Code = [direction-subject].code_dir) ON specialties.Code = directions.Specialty_code) ON subjects.Code = [direction-subject].code_sub GROUP BY directions.Name_of_a_direction, subjects.Name_cl, subjects.Credits HAVING(((directions.Name_of_a_direction) = '" + a + "'))";
                OleDbDataAdapter DaTrV = new OleDbDataAdapter(ComTxtSub, ConnectionString);
                DaTrV.Fill(ds, "children-courses");
                for (int j = 0; j < ds.Tables["children-courses"].Rows.Count; j++)
                {
                    trvi1.Items.Add(new TreeViewItem() { Header = ds.Tables["children-courses"].Rows[j].ItemArray[1].ToString() + " (" + ds.Tables["children-courses"].Rows[j].ItemArray[2].ToString() + ")" });
                }
                trv_minor.Items.Add(trvi1);
                ds.Tables["children-courses"].Clear();
            }
            trv_req.Items.Add(trv_major);
            trv_req.Items.Add(trv_minor);
        }

        private void trv_req_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (trv_req.SelectedItem != null)
            {
                var sel = trv_req.SelectedItem as TreeViewItem;
                selected_sub = sel.Header.ToString().Remove(sel.Header.ToString().Length - 4, 4);
            }
        }

        private void trv_req_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Subject sub = new Subject();
            sub.ShowDialog();

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            n++;
            Microsoft.Office.Interop.Word.Application schedule = new Microsoft.Office.Interop.Word.Application();
            schedule.Visible = false;
            object missing = System.Reflection.Missing.Value;
            Document document = schedule.Documents.Add(ref missing, ref missing, ref missing, ref missing);
            try
            {
                List<string> days_of_week = new List<string>() { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
                foreach (Microsoft.Office.Interop.Word.Section section in document.Sections)
                {
                    Range headerRange = section.Headers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, WdFieldType.wdFieldPage);
                    headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                    headerRange.Font.Name = "Gill Sans MT";
                    headerRange.Font.Size = 20;
                    headerRange.Text = "My Schedule";

                }

                for (int i = 0; i < days_of_week.Count; i++)
                {
                    Microsoft.Office.Interop.Word.Paragraph para1 = document.Content.Paragraphs.Add(ref missing);
                    para1.Range.Text += days_of_week[i] + Environment.NewLine;
                    List<Lesson> day = new List<Lesson>();
                    for (int j = 0; j < Subject.result.Count; j++)
                    {
                        if (Subject.result[j].Day.Contains(days_of_week[i]) == true)
                        {
                            day.Add(Subject.result[j]);
                        }
                    }

                    Microsoft.Office.Interop.Word.Table schedule_table = document.Tables.Add(para1.Range, day.Count + 1, 4, ref missing, ref missing);
                    schedule_table.Borders.Enable = 1;
                    schedule_table.Rows[1].Cells[1].Range.Text = "Name of the class";
                    schedule_table.Rows[1].Cells[2].Range.Text = "Time";
                    schedule_table.Rows[1].Cells[3].Range.Text = "Teacher";
                    schedule_table.Rows[1].Cells[4].Range.Text = "Address";
                    for (int a = 0; a < day.Count; a++)
                    {
                        for (int j = 0; j < day.Count - a - 1; j++)
                        {
                            DateTime dtstartj1 = new DateTime(2000, 10, 1, day[j].time_startHH, day[j].time_startMM, 0);
                            DateTime dtstartj2 = new DateTime(2000, 10, 1, day[j + 1].time_startHH, day[j + 1].time_startMM, 0);
                            if (dtstartj1 > dtstartj2)
                            {
                                Lesson temp = day[j];
                                day[j] = day[j + 1];
                                day[j + 1] = temp;
                            }
                        }
                    }
                    for (int j = 0; j < day.Count; j++)
                    {
                        schedule_table.Rows[j + 2].Cells[1].Range.Text = day[j].Name;
                        schedule_table.Rows[j + 2].Cells[2].Range.Text = day[j].TimeStart + " - " + day[j].TimeEnd;
                        schedule_table.Rows[j + 2].Cells[3].Range.Text = day[j].Teacher;
                        schedule_table.Rows[j + 2].Cells[4].Range.Text = day[j].Address;
                    }
                }
                object filename = Settings.schedule_save_folder_name + "\\schedule" + n + ".docx";
                object filename1 = Settings.schedule_save_folder_name + "\\schedule" + n + ".xps";
                document.SaveAs2(ref filename);
                document.SaveAs2(ref filename1, WdSaveFormat.wdFormatXPS);
                document.Close(ref missing, ref missing, ref missing);
                document = null;
                schedule.Quit(ref missing, ref missing, ref missing);
                schedule = null;
                XpsDocument doc = new XpsDocument(Settings.schedule_save_folder_name + "\\schedule" + n + ".xps", FileAccess.Read);
                documentViewer.Document = doc.GetFixedDocumentSequence();
            }
            catch
            {
                document.Close(ref missing, ref missing, ref missing);
                document = null;
                schedule.Quit(ref missing, ref missing, ref missing);
                schedule = null;
            }
        }

        private void grad_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Hide();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            List<Lesson> res = new List<Lesson>();
            int sel = dataGrid.SelectedIndex;
            for (int i = 0; i < dataGrid.Items.Count; i++)
            {
                if (Subject.result[sel].Name == Subject.result[i].Name && Subject.result[sel].Section == Subject.result[i].Section)
                {
                    res.Add(Subject.result[i]);
                }

            }
            for (int i = 0; i < res.Count; i++)
            {
                for (int j = 0; j < Subject.result.Count; j++)
                {
                    if (Subject.result[j] == res[i])
                    {
                        Subject.result.Remove(Subject.result[j]);
                    }
                }
            }

            dataGrid.ItemsSource = "";
            dataGrid.ItemsSource = Subject.result;
            dg.Columns[0].Header = "Name of the course";
            dg.Columns[0].Width = DataGridLength.SizeToCells;
            dg.Columns[1].Header = "Section";
            dg.Columns[2].Header = "Day of week";
            dg.Columns[3].Header = "Time of the beginning";
            dg.Columns[4].Header = "Time of the end";
            dg.Columns[5].Header = "Address";
            dg.Columns[6].Header = "Name of the teacher";
        }
        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dataGrid.Items.Count > 0)
            {
                button.IsEnabled = true;
                button2.IsEnabled = true;
            }
        }

        private void dataGrid_LoadingRow(object sender, DataGridRowEventArgs e)
        {

            if (dataGrid.Items.Count > 1)
            {
                for (int j = 0; j < Subject.result.Count; j++)
                {

                    if (Subject.result[e.Row.GetIndex()].Name == Subject.result[j].Name && Subject.result[e.Row.GetIndex()].Section != Subject.result[j].Section && e.Row.GetIndex() != j)
                    {
                        e.Row.Background = Brushes.Red;
                    }
                    else
                    {
                        if (Subject.result[e.Row.GetIndex()].Day == Subject.result[j].Day && e.Row.GetIndex() != j)
                        {
                            DateTime dtstarti = new DateTime(2000, 10, 1, Subject.result[e.Row.GetIndex()].time_startHH, Subject.result[e.Row.GetIndex()].time_startMM, 0);
                            DateTime dtendi = new DateTime(2000, 10, 1, Subject.result[e.Row.GetIndex()].time_endHH, Subject.result[e.Row.GetIndex()].time_endMM, 0);
                            DateTime dtstartj = new DateTime(2000, 10, 1, Subject.result[j].time_startHH, Subject.result[j].time_startMM, 0);
                            DateTime dtendj = new DateTime(2000, 10, 1, Subject.result[j].time_endHH, Subject.result[j].time_endMM, 0);
                            if (dtstarti == dtstartj || (dtstarti > dtstartj && dtstarti < dtendj) || (dtstartj > dtstarti && dtstartj < dtendi))
                            {
                                e.Row.Background = Brushes.Red;
                            }
                        }
                    }
                }
            }
        }

        private void grad_Copy_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Help_Schedule hp = new Help_Schedule();
            hp.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
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
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Paragraph = iTextSharp.text.Paragraph;
using System.Data;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace _11._01_Кол
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Dolg_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new TableDolgnosti());
        }

        private void Poochr_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new TablePoochreniya());
        }

        private void Sotr_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new TableSotrudniki());
        }

        private void Oplata_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new TableOplata());
        }

        private void Uchet_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new TableUchet());
        }

        private void Poisk_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new Poisk());
        }

        private void Proc_Click(object sender, RoutedEventArgs e)
        {
            Nav.MainFrame.Navigate(new Proc());
        }

        private void Otch_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Oth1_Click(object sender, RoutedEventArgs e)
        {
            Excel.Application app = new Excel.Application()
            {
                Visible = true,
                SheetsInNewWorkbook = 1
            };
            Excel.Workbook workbook = app.Workbooks.Add();
            app.DisplayAlerts = false;
            Excel.Worksheet sheet = (Excel.Worksheet)app.Worksheets.get_Item(1);
            sheet.Name = "Учёт информации о сотрудниках";
            sheet.Cells[1, 1] = "id назначения";
            sheet.Cells[1, 2] = "Сотрудник";
            sheet.Cells[1, 3] = "Должность";
            sheet.Cells[1, 4] = "Дата приёма";
            int recordCount=0;
            var currentRow = 2;
            var s = Connect.context.Uchet_inform_o_sotrudnikah.Select(x =>
            new
            {
                Uchet_inform_o_sotrudnikah = x,
                Sotrudniki = x.Sotrudniki,
                Dolgnosty = x.Dolgnosty,
                Familia = x.Sotrudniki.Familia,
                Dolgnost = x.Dolgnosty.nazvanie,
            }).ToList();
            foreach (var item in s)
            {
                sheet.Cells[currentRow, 1] = item.Uchet_inform_o_sotrudnikah.id_naznachenia;
                sheet.Cells[currentRow, 2] = item.Familia;
                sheet.Cells[currentRow, 3] = item.Dolgnost;
                sheet.Cells[currentRow, 4] = item.Uchet_inform_o_sotrudnikah.data_priema;
                currentRow++;
                recordCount = s.Count();
            }
            sheet.Columns[1].ColumnWidth = 10;
            sheet.Columns[2].ColumnWidth = 20;
            sheet.Columns[3].ColumnWidth = 20;
            sheet.Columns[4].ColumnWidth = 20;
            sheet.Cells[currentRow + 1, 2] = "Количество записей: ";
            sheet.Cells[currentRow + 1, 3] = recordCount;
        }
        private void Oth2_Click(object sender, RoutedEventArgs e)
        {
            Excel.Application app = new Excel.Application()
            {
                Visible = true,
                SheetsInNewWorkbook = 1
            };
            Excel.Workbook workbook = app.Workbooks.Add();
            app.DisplayAlerts = false;
            Excel.Worksheet sheet = (Excel.Worksheet)app.Worksheets.get_Item(1);
            sheet.Name = "Ведомость начисления зарплаты";
            sheet.Cells[1, 1] = "Номер строки";
            sheet.Cells[1, 2] = "Фамилия";
            sheet.Cells[1, 3] = "Имя";
            sheet.Cells[1, 4] = "Отчество";
            sheet.Cells[1, 5] = "Оклад";
            sheet.Cells[1, 6] = "Сумма доплаты";
            sheet.Cells[1, 7] = "Всего начислено";
            var currentRow = 2;
            var s = Connect.context.Oplata.Select(x =>
            new
            {
                Oplata = x,
                Uchet_inform_o_sotrudnikah = x.Uchet_inform_o_sotrudnikah,
                Sotrudniki = x.Uchet_inform_o_sotrudnikah.Sotrudniki,
                Dolgnosty = x.Uchet_inform_o_sotrudnikah.Dolgnosty,
                Poochreniya = x.Poochreniya,
                id_sotrudnika = x.Uchet_inform_o_sotrudnikah.Sotrudniki.id_sotrudnika,
                Familia = x.Uchet_inform_o_sotrudnikah.Sotrudniki.Familia,
                Name = x.Uchet_inform_o_sotrudnikah.Sotrudniki.Name,
                Otchestvo = x.Uchet_inform_o_sotrudnikah.Sotrudniki.Otchestvo,
                Oklad = x.Uchet_inform_o_sotrudnikah.Dolgnosty.oklad,
                Sumdop = x.Poochreniya.procent_ot_oklada * x.Uchet_inform_o_sotrudnikah.Dolgnosty.oklad / 100,
                Summ = x.Uchet_inform_o_sotrudnikah.Dolgnosty.oklad + x.Poochreniya.procent_ot_oklada * x.Uchet_inform_o_sotrudnikah.Dolgnosty.oklad / 100,
            }).ToList();
            foreach (var item in s)
            {
                sheet.Cells[currentRow, 1] = currentRow;
                sheet.Cells[currentRow, 2] = item.Sotrudniki.Familia;
                sheet.Cells[currentRow, 3] = item.Sotrudniki.Name;
                sheet.Cells[currentRow, 4] = item.Sotrudniki.Otchestvo;
                sheet.Cells[currentRow, 5] = item.Dolgnosty.oklad;
                sheet.Cells[currentRow, 6] = item.Sumdop;
                sheet.Cells[currentRow, 7] = item.Summ;
                currentRow++;
            }
            sheet.Columns[1].ColumnWidth = 10;
            sheet.Columns[2].ColumnWidth = 30;
            sheet.Columns[3].ColumnWidth = 20;
            sheet.Columns[4].ColumnWidth = 20;
            sheet.Columns[5].ColumnWidth = 20;
            sheet.Columns[6].ColumnWidth = 20;
            sheet.Columns[7].ColumnWidth = 20;
            sheet.Cells[currentRow + 1, 2] = "Итого начислено за месяц: ";
            sheet.Cells[currentRow + 1, 3] = "=SUM(G2:G" + (currentRow - 1) + ")";
        }
        private void Oth3_Click(object sender, RoutedEventArgs e)
        {
            Excel.Application app = new Excel.Application()
            {
                Visible = true,
                SheetsInNewWorkbook = 1
            };
            Excel.Workbook workbook = app.Workbooks.Add();
            app.DisplayAlerts = false;
            Excel.Worksheet sheet = (Excel.Worksheet)app.Worksheets.get_Item(1);
            sheet.Name = "Группировка по дате назначения";
            sheet.Cells[1, 1] = "Дата";
            sheet.Cells[1, 2] = "Количество человек";
            var currentRow = 2;
            var s = Connect.context.Uchet_inform_o_sotrudnikah.GroupBy(x => x.data_priema).Select(g => new { Month = g.Key, Count = g.Count() }).ToList();
            foreach (var item in s)
            {
                sheet.Cells[currentRow, 1] = item.Month;
                sheet.Cells[currentRow, 2] = item.Count;
                currentRow++;
            }
            sheet.Columns[1].ColumnWidth = 10;
            sheet.Columns[2].ColumnWidth = 20;
        }
    }
}

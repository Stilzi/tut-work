using System.Linq;
using System.Windows;


namespace COMPUTERMANUFACTURER
{
    public partial class Window5 : Window
    {
        COMPUTEREntities7 D = new COMPUTEREntities7();

        public Window5()
        {
            InitializeComponent();
            //Отображение данных из таблицы
            MANUF_DATAGRID.ItemsSource = D.MANUFACTURER.ToList();
        }

        private void checkBox1_Checked(object sender, RoutedEventArgs e)
        {
            //Выборка 1
            var sel = D.MANUFACTURER.Where(t => t.ADDRESS == "Богодухов").OrderByDescending(t => t.SPECIFICATIONS.FREQUENCY).ToList();
            MANUF_DATAGRID.ItemsSource = sel;
        }

        private void checkBox1_Unchecked(object sender, RoutedEventArgs e)
        {
            MANUF_DATAGRID.ItemsSource = D.MANUFACTURER.ToList();
        }

        private void checkBox2_Checked(object sender, RoutedEventArgs e)
        {
            //Выборка 2
            MANUF_DATAGRID.ItemsSource = D.MANUFACTURER.Where(item => item.SPECIFICATIONS.CPU == "POWER-4").ToList();
        }
        private void checkBox2_Unchecked(object sender, RoutedEventArgs e)
        {
            MANUF_DATAGRID.ItemsSource = D.MANUFACTURER.ToList();
        }
        private void checkBox3_Checked(object sender, RoutedEventArgs e)
        {
            //Выборка 3
            var kafl = D.MANUFACTURER.Where(t => t.SPECIFICATIONS.CPU == "Pentium 4").OrderByDescending(t => t.SPECIFICATIONS.RELEASEdATE).ToList();
            MANUF_DATAGRID.ItemsSource = kafl;
        }
        private void checkBox3_Unchecked(object sender, RoutedEventArgs e)
        {
            MANUF_DATAGRID.ItemsSource = D.MANUFACTURER.ToList();
        }
        private void checkBox4_Checked(object sender, RoutedEventArgs e)
        {
            //Выборка 4
            var ASLAN = D.MANUFACTURER.OrderByDescending(t => t.CONSIGNMENT.PRICE).ToList();
            MANUF_DATAGRID.ItemsSource = ASLAN;
        }
        private void checkBox4_Unchecked(object sender, RoutedEventArgs e)
        {
            MANUF_DATAGRID.ItemsSource = D.MANUFACTURER.ToList();
        }

        private void redact_Click(object sender, RoutedEventArgs e)
        {
            method();
        }

        void method()
        {
            //Удаление данных
            MANUFACTURER DD = (MANUFACTURER)MANUF_DATAGRID.SelectedItem; 
            D.MANUFACTURER.Remove(DD);
            D.SaveChanges();
            MANUF_DATAGRID.ItemsSource = D.MANUFACTURER.ToList();
        }

        private void redact_red_Click(object sender, RoutedEventArgs e)
        {
            //Редактирование данных
            D.SaveChanges();
            MessageBox.Show("Изменения сохранены");
        }
    }
}


﻿using System.Linq;
using System.Windows;


namespace COMPUTERMANUFACTURER
{

    public partial class Window6 : Window
    {
        COMPUTEREntities7 h = new COMPUTEREntities7();
        public Window6()
        {
            InitializeComponent();
            //Отображение данных из таблицы
            CONS_DATAGRID.ItemsSource = h.CONSIGNMENT.ToList();
        }
    }
}

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

namespace WpfApp3
{
    /// <summary>
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

      

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string imiee= dodajimie.Text;

            int countt = int.Parse(dodajcount.Text);
            ((MainWindow)Application.Current.MainWindow).dodaj_osobe(imiee, countt);

            this.Close();
            
        }
    }
}

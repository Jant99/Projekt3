using Microsoft.Azure.Devices.Common;
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

namespace WpfApp3
{
    /// <summary>
    /// Logika interakcji dla klasy Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

    

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int number;
            string imie = Textbox1.Text;
            if (Int32.TryParse(imie, out number) == true)
            {
                var found = ((MainWindow)Application.Current.MainWindow).wyszukaj_po_wieku(number);
                foreach (object osoba in found)
                    Tabznalezionych.Items.Add(osoba);
            }
            else
            {
                var found = ((MainWindow)Application.Current.MainWindow).wyszukaj_po_imieniu(imie);
                foreach (object osoba in found)
                    Tabznalezionych.Items.Add(osoba);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

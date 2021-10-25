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

namespace WpfApp3
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public class osoba
        {
            public string name;
            public int id;
            public int count;
        }
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 oknododania = new Window1();
            oknododania.Show();
            var nowaosoba = new osoba();
            nowaosoba.name = Class1.imie;
            nowaosoba.count = Class1.count;
            lista.Items.Add(nowaosoba);

        }
    }
}

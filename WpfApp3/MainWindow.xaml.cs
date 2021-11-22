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
using System.IO;

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

        List<osoba> lista_osob = new List<osoba>();

        static void MoveItemAtIndexToFront(List<osoba> list, int index)
        {
            osoba item = list[index];
            list.RemoveAt(index);
            list.Insert(0, item);
        }

        public class osoba
        {

            public string Name { get; set; }
            public int ID { get; set; }
            public int Count { get; set; }
        }
        
          
        public void dodaj_osobe(string imie, int wiek)
        {
            osoba nowa_osoba = new osoba();
            nowa_osoba.Name = imie; 
            nowa_osoba.ID = lista_osob.Count() + 1;
            nowa_osoba.Count = wiek;
            lista_osob.Add(nowa_osoba);
            Tabela.Items.Add(nowa_osoba);
            ListViewItem item = new ListViewItem();
            Tabela.Items.Refresh();

        }

        public void wyszukaj_po_imieniu (string imie)
        {
            List<osoba> znalezione = lista_osob.Where(e => e.Name.Equals(imie)).ToList();
            for (int i = 0; i < znalezione.Count(); i++)
            {
                for (int j = 0; j < Tabela.Items.Count; j++)
                {
                    if ( == znalezione[i].ID)
                        MoveItemAtIndexToFront(lista_osob, j);
                }
            }
            Tabela.Items.Refresh();

        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 oknododania = new Window1();
            oknododania.Show();
          
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Tabela.Items.Clear();
            lista_osob.Clear();
            //StringBuilder csv_in_one_line = new StringBuilder();
            
            string path = @"C:\Users\Jan\source\repos\WpfApp3\WpfApp3\Wyjsscie.csv";
            var fileLines = File.ReadAllLines(path);
           
            foreach (var singleLine in fileLines)
            {
                
                string data = Convert.ToString(singleLine);
                string[] tab = data.Split(',');
                osoba new_person = new osoba();
                new_person.Name = tab[0];
                new_person.ID = Convert.ToInt32(tab[1]);
                new_person.Count = Convert.ToInt32(tab[2]);
                lista_osob.Add(new_person);
                Tabela.Items.Add(new_person);
            }
            
            
            

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string path = "C:/Users/Jan/source/repos/WpfApp3/WpfApp3/Wyjsscie.csv";
            StreamWriter sw = new StreamWriter(path);
            //var csv = new StringBuilder();
            foreach (osoba person in lista_osob)
            {
                
                var first = person.Name;
                var second = person.ID;
                var third = person.Count;
                var newLine = string.Format("{0},{1},{2}", first, second, third);
                //csv.AppendLine(newLine);
                sw.WriteLine(newLine);
   
            }
            sw.Close();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window2 oknowyszukiwania = new Window2();
            oknowyszukiwania.Show();
            Tabela.Items.Refresh();
        }
    }
}

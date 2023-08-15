using app1;
using entitati;
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

namespace WpfAppPOS
{
    /// <summary>
    /// Interaction logic for Fereastra_Produse.xaml
    /// </summary>
    public partial class Fereastra_Produse : Window
    {
        ProduseMgr produsMgr = new ProduseMgr();
        public List<Produs> lista = new List<Produs>();
        public static List<Produs> lista_add = new List<Produs>();

        public Fereastra_Produse()
        {
            InitializeComponent();
            lista = produsMgr.InitListafromXML();
        }

        private void buton_afisarep_Click(object sender, RoutedEventArgs e)
        {
            textbox_afisare_produse.Text = null;
            foreach (Produs prod in lista)
                textbox_afisare_produse.AppendText(prod.Descriere() + Environment.NewLine);
        }


        private void afisare_produsenoi_Click(object sender, RoutedEventArgs e)
        {
            textbox_afisare_produse.Text = null;
            foreach (Produs prod in lista_add)
                textbox_afisare_produse.AppendText(prod.Descriere() + Environment.NewLine);
        }

        private void buton_adaugap_Click_1(object sender, RoutedEventArgs e)
        {
            Produse_tastatura prod_add = new Produse_tastatura();
            prod_add.ShowDialog();
            textbox_afisare_produse.Text = null;
            foreach (Produs prod in lista_add)
                textbox_afisare_produse.AppendText(prod.Descriere() + Environment.NewLine);
        }

        private void textbox_afisare_produse_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

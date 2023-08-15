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
    /// Interaction logic for Produse_tastatura.xaml
    /// </summary>
    public partial class Produse_tastatura : Window
    {
        public Produse_tastatura()
        {
            InitializeComponent();
        }

        private void buton_adauga_Click(object sender, RoutedEventArgs e)
        {
            //se adauga un nou produs in lista
            Fereastra_Produse.lista_add.Add(new Produs(Fereastra_Produse.lista_add.Count + 1, textbox_nume.Text, textbox_cod.Text, textbox_producator.Text, int.Parse(textbox_pret.Text), textbox_categorie.Text));
            this.Close();
        }

        private void textbox_nume_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

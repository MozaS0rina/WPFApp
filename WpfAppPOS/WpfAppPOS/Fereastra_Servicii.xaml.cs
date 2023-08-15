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
    /// Interaction logic for Fereastra_Servicii.xaml
    /// </summary>
    public partial class Fereastra_Servicii : Window
    {
        ServiciuMgr serviciuMgr = new ServiciuMgr();
        public static List<Serviciu> lista_add = new List<Serviciu>();
    
        public Fereastra_Servicii()
        {
            InitializeComponent();

        }

        private void Fereastra_servicii_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void textbox_afisare_servicii_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        private void afisare_serviciinoi_Click(object sender, RoutedEventArgs e)
        {
            textbox_afisare_servicii.Text = null;
            foreach (Serviciu serv in lista_add)
                textbox_afisare_servicii.AppendText(serv.Descriere() + Environment.NewLine);
        }

        private void buton_adaugas_Click_1(object sender, RoutedEventArgs e)
        {
            Servicii_tastatura srv_add = new Servicii_tastatura();
            srv_add.ShowDialog();
            textbox_afisare_servicii.Text = null;
            foreach (Serviciu serv in lista_add)
                textbox_afisare_servicii.AppendText(serv.Descriere() + Environment.NewLine);
        }

        private void buton_afisares_Click_1(object sender, RoutedEventArgs e)
        {
            textbox_afisare_servicii.Text = null;
            List<Serviciu> lista = serviciuMgr.InitListafromXML();
            foreach (Serviciu serv in lista)
                textbox_afisare_servicii.AppendText(serv.Descriere() + Environment.NewLine);
        }
    }
}

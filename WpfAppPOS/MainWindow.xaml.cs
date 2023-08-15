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
using app1;

namespace WpfAppPOS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PacheteMgr pachetMgr = new PacheteMgr();
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void buton_afisareP_Click(object sender, RoutedEventArgs e)
        {
            pachetMgr.ReadPachet();
            foreach (entitati.Pachet pct in pachetMgr.packages)
            {
                textbox_pachete.AppendText(pct.Descriere() + Environment.NewLine);
                foreach (entitati.ProdusAbstract pda in pct.elem_pachet)
                    textbox_pachete.AppendText(pda.Descriere() + Environment.NewLine);
            }
        }

        private void textbox_pachete_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textbox_pachete_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void buton_produse_Click(object sender, RoutedEventArgs e)
        {
            Fereastra_Produse fereastra_Produse=new Fereastra_Produse();
            fereastra_Produse.Show();
        }

        private void buton_servicii_Click(object sender, RoutedEventArgs e)
        {
            Fereastra_Servicii fereastra_Servicii=new Fereastra_Servicii();
            fereastra_Servicii.Show();
        }
    }
}

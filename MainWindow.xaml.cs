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

namespace biblioteca
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
    //creo gli oggetti
        Libro l;
        libreria lb;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCreaLibro_Click(object sender, RoutedEventArgs e)
        {
            string[] s = txtinputlibro.Text.Split(',');
            l = new Libro(s[0], s[1], int.Parse(s[2]), s[3], int.Parse(s[4]));
        }

        private void btncreaBiblioteca_Click(object sender, RoutedEventArgs e)
        {
            string[] s = txtInputlibreria.Text.Split(',');
            lb = new libreria(s[0], s[1], int.Parse(s[2]), int.Parse(s[3]));
        }

        private void btnGetlibro_Click(object sender, RoutedEventArgs e)
        {   
            MessageBox.Show(lb.GetLibro(txtGetLibro.Text));
        }

        private void btnGetLibri_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(lb.GetLibri(txtGetLibri.Text));
        }

        private void btnLibriTotali_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(lb.numerolibriTotali().ToString());
        }
    }
}

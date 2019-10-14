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
using System.Xml.Linq;

namespace ProyectoSegundoParcial
{
    /// <summary>
    /// Lógica de interacción para ParametrosRefresco.xaml
    /// </summary>
    public partial class ParametrosRefresco : UserControl
    {

        public ParametrosRefresco()
        {
            InitializeComponent();
        }      

        public void TxtNombreProducto_TextChanged(object sender, TextChangedEventArgs e)
        {
            lAdvertencia.Visibility = Visibility.Hidden;
        }

        private void TxtPrecio_TextChanged(object sender, TextChangedEventArgs e)
        {
            lAdvertencia.Visibility = Visibility.Hidden;
        }

        private void TxtCodigo_TextChanged(object sender, TextChangedEventArgs e)
        {
            lAdvertencia.Visibility = Visibility.Hidden;

        }

        private void TxtDescuento_TextChanged(object sender, TextChangedEventArgs e)
        {
            lAdvertencia.Visibility = Visibility.Hidden;

        }

        private void TxtProvedor_TextChanged(object sender, TextChangedEventArgs e)
        {
            lAdvertencia.Visibility = Visibility.Hidden;

        }
    }
}

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

namespace ProyectoSegundoParcial
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            grdParametros.Children.Clear();
            grdParametros.Visibility = Visibility.Visible;
            btnGuardarM.Visibility = Visibility.Visible;
            btnCancelar.Visibility = Visibility.Visible;

            switch (cbProductos.SelectedIndex)
            {
                case 0:
                    grdParametros.Children.Add(new ParametrosRefresco());
                    break;
                case 1:
                    grdParametros.Children.Add(new ParametrosLeche());
                    break;
                case 2:
                    grdParametros.Children.Add(new ParametrosJabones());
                    break;
                case 3:
                    grdParametros.Children.Add(new ParametrosChicles());
                    break;
                case 4:
                    grdParametros.Children.Add(new ParametrosGalletas());
                    break;
                case 5:
                    grdParametros.Children.Add(new ParametrosFrituras());
                    break;
                default:
                    grdParametros.Visibility = Visibility.Hidden;
                    break;
            }


        }

        private void BtnGuardarM_Click(object sender, RoutedEventArgs e)
        {
            switch (cbProductos.SelectedIndex)
            {
                case 0:
                    var parametrosrefresco = ((ParametrosRefresco)(grdParametros.Children[0]));
                    if(parametrosrefresco.txtNombreProducto.Text == "" || parametrosrefresco.txtCodigo.Text == "" || parametrosrefresco.txtDescuento.Text == "" ||
                    parametrosrefresco.txtPrecio.Text == "" || parametrosrefresco.txtProvedor.Text == "")
                    {
                        lAdvertencia.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        grdParametros.Visibility = Visibility.Hidden;
                        btnGuardarM.Visibility = Visibility.Hidden;
                        btnCancelar.Visibility = Visibility.Hidden;
                    }
                    if(parametrosrefresco.txtNombreProducto.Text != "" && parametrosrefresco.txtCodigo.Text != "" && parametrosrefresco.txtDescuento.Text != "" &&
                    parametrosrefresco.txtPrecio.Text != "" && parametrosrefresco.txtProvedor.Text != "")
                    {
                        lAdvertencia.Visibility = Visibility.Hidden;
                    }
                    break;

                case 1:
                    var parametrosleche = ((ParametrosLeche)(grdParametros.Children[0]));
                    if (parametrosleche.txtNombreProducto.Text == "" || parametrosleche.txtCodigo.Text == "" || parametrosleche.txtDescuento.Text == "" ||
                    parametrosleche.txtPrecio.Text == "" || parametrosleche.txtProvedor.Text == "")
                    {
                        lAdvertencia.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        grdParametros.Visibility = Visibility.Hidden;
                        btnGuardarM.Visibility = Visibility.Hidden;
                        btnCancelar.Visibility = Visibility.Hidden;
                    }
                    if (parametrosleche.txtNombreProducto.Text != "" && parametrosleche.txtCodigo.Text != "" && parametrosleche.txtDescuento.Text != "" &&
                    parametrosleche.txtPrecio.Text != "" && parametrosleche.txtProvedor.Text != "")
                    {
                        lAdvertencia.Visibility = Visibility.Hidden;
                    }
                    break;

                case 2:
                    var parametrosjabones = ((ParametrosJabones)(grdParametros.Children[0]));
                    if (parametrosjabones.txtNombreProducto.Text == "" || parametrosjabones.txtCodigo.Text == "" || parametrosjabones.txtDescuento.Text == "" ||
                    parametrosjabones.txtPrecio.Text == "" || parametrosjabones.txtProvedor.Text == "")
                    {
                        lAdvertencia.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        grdParametros.Visibility = Visibility.Hidden;
                        btnGuardarM.Visibility = Visibility.Hidden;
                        btnCancelar.Visibility = Visibility.Hidden;
                    }
                    if (parametrosjabones.txtNombreProducto.Text != "" && parametrosjabones.txtCodigo.Text != "" && parametrosjabones.txtDescuento.Text != "" &&
                    parametrosjabones.txtPrecio.Text != "" && parametrosjabones.txtProvedor.Text != "")
                    {
                        lAdvertencia.Visibility = Visibility.Hidden;
                    }
                    break;

                case 3:
                    var parametroschicles = ((ParametrosChicles)(grdParametros.Children[0]));
                    if (parametroschicles.txtNombreProducto.Text == "" || parametroschicles.txtCodigo.Text == "" || parametroschicles.txtDescuento.Text == "" ||
                    parametroschicles.txtPrecio.Text == "" || parametroschicles.txtProvedor.Text == "")
                    {
                        lAdvertencia.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        grdParametros.Visibility = Visibility.Hidden;
                        btnGuardarM.Visibility = Visibility.Hidden;
                        btnCancelar.Visibility = Visibility.Hidden;
                    }
                    if (parametroschicles.txtNombreProducto.Text != "" && parametroschicles.txtCodigo.Text != "" && parametroschicles.txtDescuento.Text != "" &&
                    parametroschicles.txtPrecio.Text != "" && parametroschicles.txtProvedor.Text != "")
                    {
                        lAdvertencia.Visibility = Visibility.Hidden;
                    }
                    break;

                case 4:
                    var parametrosgalletas = ((ParametrosGalletas)(grdParametros.Children[0]));
                    if (parametrosgalletas.txtNombreProducto.Text == "" || parametrosgalletas.txtCodigo.Text == "" || parametrosgalletas.txtDescuento.Text == "" ||
                    parametrosgalletas.txtPrecio.Text == "" || parametrosgalletas.txtProvedor.Text == "")
                    {
                        lAdvertencia.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        grdParametros.Visibility = Visibility.Hidden;
                        btnGuardarM.Visibility = Visibility.Hidden;
                        btnCancelar.Visibility = Visibility.Hidden;
                    }
                    if (parametrosgalletas.txtNombreProducto.Text != "" && parametrosgalletas.txtCodigo.Text != "" && parametrosgalletas.txtDescuento.Text != "" &&
                    parametrosgalletas.txtPrecio.Text != "" && parametrosgalletas.txtProvedor.Text != "")
                    {
                        lAdvertencia.Visibility = Visibility.Hidden;
                    }
                    break;

                case 5:
                    var parametrosfrituras = ((ParametrosFrituras)(grdParametros.Children[0]));
                    if (parametrosfrituras.txtNombreProducto.Text == "" || parametrosfrituras.txtCodigo.Text == "" || parametrosfrituras.txtDescuento.Text == "" ||
                    parametrosfrituras.txtPrecio.Text == "" || parametrosfrituras.txtProvedor.Text == "")
                    {
                        lAdvertencia.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        grdParametros.Visibility = Visibility.Hidden;
                        btnGuardarM.Visibility = Visibility.Hidden;
                        btnCancelar.Visibility = Visibility.Hidden;
                    }
                    if (parametrosfrituras.txtNombreProducto.Text != "" && parametrosfrituras.txtCodigo.Text != "" && parametrosfrituras.txtDescuento.Text != "" &&
                    parametrosfrituras.txtPrecio.Text != "" && parametrosfrituras.txtProvedor.Text != "")
                    {
                        lAdvertencia.Visibility = Visibility.Hidden;
                    }
                    break;
            }

            /*if (parametrosrefresco.txtNombreProducto.Text == "" || parametrosrefresco.txtCodigo.Text == "" || parametrosrefresco.txtDescuento.Text == "" ||
               parametrosrefresco.txtPrecio.Text == "" || parametrosrefresco.txtProvedor.Text == "" || 
               parametrosleche.txtNombreProducto.Text == "" || parametrosleche.txtCodigo.Text == "" || parametrosleche.txtDescuento.Text == "" ||
               parametrosleche.txtPrecio.Text == "" || parametrosleche.txtProvedor.Text == "" ||
               parametrosjabones.txtNombreProducto.Text == "" || parametrosjabones.txtCodigo.Text == "" || parametrosjabones.txtDescuento.Text == "" ||
               parametrosjabones.txtPrecio.Text == "" || parametrosjabones.txtProvedor.Text == "" ||
               parametroschicles.txtNombreProducto.Text == "" || parametroschicles.txtCodigo.Text == "" || parametroschicles.txtDescuento.Text == "" ||
               parametroschicles.txtPrecio.Text == "" || parametroschicles.txtProvedor.Text == "" ||
               parametrosgalletas.txtNombreProducto.Text == "" || parametrosgalletas.txtCodigo.Text == "" || parametrosgalletas.txtDescuento.Text == "" ||
               parametrosgalletas.txtPrecio.Text == "" || parametrosgalletas.txtProvedor.Text == "" ||
               parametrosfrituras.txtNombreProducto.Text == "" || parametrosfrituras.txtCodigo.Text == "" || parametrosfrituras.txtDescuento.Text == "" ||
               parametrosfrituras.txtPrecio.Text == "" || parametrosfrituras.txtProvedor.Text == "")
            {
                lAdvertencia.Visibility = Visibility.Visible;
            }
            else
            {
                grdParametros.Visibility = Visibility.Hidden;
                btnGuardarM.Visibility = Visibility.Hidden;
                btnCancelar.Visibility = Visibility.Hidden;
            }
            if (parametrosrefresco.txtNombreProducto.Text != "" || parametrosrefresco.txtCodigo.Text != "" || parametrosrefresco.txtDescuento.Text != "" ||
               parametrosrefresco.txtPrecio.Text != "" || parametrosrefresco.txtProvedor.Text != "" ||
               parametrosleche.txtNombreProducto.Text != "" || parametrosleche.txtCodigo.Text != "" || parametrosleche.txtDescuento.Text != "" ||
               parametrosleche.txtPrecio.Text != "" || parametrosleche.txtProvedor.Text != "" ||
               parametrosjabones.txtNombreProducto.Text != "" || parametrosjabones.txtCodigo.Text != "" || parametrosjabones.txtDescuento.Text != "" ||
               parametrosjabones.txtPrecio.Text != "" || parametrosjabones.txtProvedor.Text != "" ||
               parametroschicles.txtNombreProducto.Text != "" || parametroschicles.txtCodigo.Text != "" || parametroschicles.txtDescuento.Text != "" ||
               parametroschicles.txtPrecio.Text != "" || parametroschicles.txtProvedor.Text != "" ||
               parametrosgalletas.txtNombreProducto.Text != "" || parametrosgalletas.txtCodigo.Text != "" || parametrosgalletas.txtDescuento.Text != "" ||
               parametrosgalletas.txtPrecio.Text != "" || parametrosgalletas.txtProvedor.Text != "" ||
               parametrosfrituras.txtNombreProducto.Text != "" || parametrosfrituras.txtCodigo.Text != "" || parametrosfrituras.txtDescuento.Text != "" ||
               parametrosfrituras.txtPrecio.Text != "" || parametrosfrituras.txtProvedor.Text != "")
            {
                lAdvertencia.Visibility = Visibility.Hidden;
            }*/
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            grdParametros.Visibility = Visibility.Hidden;
            btnCancelar.Visibility = Visibility.Hidden;
            btnGuardarM.Visibility = Visibility.Hidden;
            lAdvertencia.Visibility = Visibility.Hidden;
        }
    }
}

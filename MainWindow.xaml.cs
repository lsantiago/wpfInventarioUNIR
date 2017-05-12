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

namespace wpfInventarioUNIR
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<RadioButton> listaNombreDistribuidor = new List<RadioButton>();
        List<CheckBox> listaSucursal = new List<CheckBox>();


        public MainWindow()
        {
            InitializeComponent();

            llenarControles();
        }



        /// <summary>
        /// Crea la lista de controles de distribuidores y sucursales
        /// </summary>
        private void llenarControles()
        {
            listaNombreDistribuidor.Add(rbCemefar);
            listaNombreDistribuidor.Add(rbCofama);
            listaNombreDistribuidor.Add(rbEmpsephar);

            listaSucursal.Add(cbSucursalPrincipal);
            listaSucursal.Add(cbSucursalSecundaria);
        }

        /// <summary>
        /// Método para enviar información del pedido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Enviar_Click(object sender, RoutedEventArgs e)
        {
            /*Console.WriteLine(tbNombreMedicamento.Text);*/

            try
            {
                
                String strNombreMedicamento = tbNombreMedicamento.Text;
                String strTipoMedicamento = cbTipoMedicamento.SelectionBoxItem.ToString();
                String strCantidadMedicamento = tbCantidadMedicamento.Text;

                int cantidadMedicamento = Int32.Parse(strCantidadMedicamento);

                String strDistribuidor = getNombreDistribuidor();

                
                Resumen windowResumen = new Resumen(strNombreMedicamento, 
                    strTipoMedicamento, 
                    cantidadMedicamento, 
                    strDistribuidor, 
                    getListaDireccionesSucursales());


                windowResumen.Show();

            }
            catch (System.NullReferenceException)
            {
                Console.WriteLine("Seleccione el nombre del distribuidor!");
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Escriba un valor númerico en la cantidad de medicamentos!");
            }

        }


        /// <summary>
        /// Método para obtener el nombre del distribuidor
        /// </summary>
        /// <returns>
        /// Nombre del distribuidor
        /// </returns>
        private String getNombreDistribuidor()
        {
            foreach (RadioButton rb in listaNombreDistribuidor)
            {
                if (rb.IsChecked == true)
                    return rb.Content.ToString();
            }

            return "";
        }




        /// <summary>
        /// Obtiene la lista de direcciones de las sucursales
        /// </summary>
        /// <returns></returns>
        private List<String> getListaDireccionesSucursales()
        {
            List<String> direcciones = new List<String>();

            foreach(CheckBox cb in listaSucursal)
            {
                if (cb.IsChecked == true)
                {
                    direcciones.Add(cb.ToolTip.ToString());
                }
            }

            return direcciones;
        }



        private void btnBorrar_Click(object sender, RoutedEventArgs e)
        {
            
        }


        
    }
}

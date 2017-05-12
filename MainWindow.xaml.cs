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
        /// <summary>
        /// Constantes
        /// </summary>
        private const String DIRECCION_SUC_PRINC = "Calle de la Rosa n. 28";
        private const String DIRECCION_SUC_SEC = "Calle Alcazabilla n. 3";


        List<RadioButton> listaNombreDistribuidor = new List<RadioButton>();


        public MainWindow()
        {
            InitializeComponent();



        }

        private void llenarControles()
        {
            listaNombreDistribuidor.Add(rbCemefar);
            listaNombreDistribuidor.Add(rbCofama);
            listaNombreDistribuidor.Add(rbEmpsephar);
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
                String strTipoMedicamento = cbTipoMedicamento.SelectedValue.ToString();
                String strCantidadMedicamento = tbCantidadMedicamento.Text;

                int cantidadMedicamento = Int32.Parse(strCantidadMedicamento);

                String strDistribuido = getNombreDistribuidor();

                
                Resumen windowResumen = new Resumen(strNombreMedicamento, strTipoMedicamento, cantidadMedicamento, "Principal");
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

        private String getNombreDistribuidor()
        {
            foreach (RadioButton rb in listaNombreDistribuidor)
            {
                if (rb.IsChecked == true)
                    return rb.Content.ToString();
            }

            return "";
        }

        private void btnBorrar_Click(object sender, RoutedEventArgs e)
        {
            
        }


        
    }
}

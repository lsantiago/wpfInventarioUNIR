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
    /// Constantes
    /// </summary>
    //private const String DIRECCION_SUC_PRINC = "Calle de la Rosa n. 28";
    //private const String DIRECCION_SUC_SEC = "Calle Alcazabilla n. 3";

    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Método para enviar información del pedido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Enviar_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(tbNombreMedicamento.Text);

            try
            {
                /*
                String strNombreMedicamento = tbNombreMedicamento.Text;
                String strTipoMedicamento = cbTipoMedicamento.SelectedValue.ToString;
                String strCantidadMedicamento = tbCantidadMedicamento.Text;

                int cantidadMedicamento = Int32.Parse(strCantidadMedicamento);

                // obtiene el nombre del distribuidor
                var rbSelecDist = gbDistribuidor.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                String strDistribuido = rbSelecDist.Text;


                // obtiene el nombre donde se va a recibir el medicamento
                //List<CheckBox> listDestinos = gbDestinos.Controls.OfType<CheckBox>().All(r => r.Checked);


                //Console.WriteLine(strDistribuido);

                FormResumen frmResumen = new FormResumen(strNombreMedicamento, strTipoMedicamento, cantidadMedicamento, "Principal");
                frmResumen.ShowDialog();
                */
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
    }
}

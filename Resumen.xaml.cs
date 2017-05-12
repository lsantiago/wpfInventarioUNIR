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

namespace wpfInventarioUNIR
{
    /// <summary>
    /// Lógica de interacción para Resumen.xaml
    /// </summary>
    public partial class Resumen : Window
    {
        public Resumen(String nombreMedic,
            String tipoMedic,
            int cantidadMedic,
            String nombreDist, List<String> direcciones)
        {

            InitializeComponent();

            // define el título de la ventana
            this.Title = nombreDist;

            // detalle del medicamento
            lblMedicamento.Content = String.Format("{0} unidades del {1} {2}", cantidadMedic, tipoMedic, nombreMedic);


            lblDirecciones.Content = "";
            // detalle de las direcciones
            foreach(String direccion in direcciones)
            {
                lblDirecciones.Content += lblDirecciones.Content + ".: Para la farmacia situda en " + direccion;
            }

        }
    }
}

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

namespace Animaciones
{
    /// <summary>
    /// Lógica de interacción para winAnimaFrameSpline.xaml
    /// </summary>
    public partial class winAnimaFrameSpline : Window
    {
        public winAnimaFrameSpline()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MenuItem mitem = sender as MenuItem;
            int eltag = Convert.ToInt32(mitem.Tag); // Asignamos el valor de Tag
            string img = "";
            switch (eltag) // Según valor de Tag elegimos nombre imagen
            {
                case 1:
                    img = @"\imgCont\Ayahuasca.jpg";
                    break;
                case 2:
                    img = @"\imgCont\psyBG.png"; 
                    break;
                case 3:
                    img = @"\imgCont\psyche_tunnel.png"; 
                    break;
                case 4:
                    img = @"\imgCont\psychedelic.jpg"; 
                    break;
                case 5:
                    img = @"\imgCont\psychedelic.png"; 
                    break;
                case 6:
                    img = @"\imgCont\waterdrop.png";
                    break;
                case 7: // Maximizar ventana
                    winAnimaSpline.WindowState = WindowState.Maximized;
                    break;
                case 8: // No maximizar (restaurar) ventana
                    winAnimaSpline.WindowState = WindowState.Normal;
                    break;
                case 9:
                    Close();
                    break;
                default:
                    // Opción por defecto si ninguna etiqueta coincide
                    break;
            }

            try
            {
                if (!string.IsNullOrEmpty(img))
                {
                    // Cargamos imagen en control Image
                    ImgTotal.Source = new BitmapImage(new Uri(img, UriKind.Relative));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

        }
    }
}

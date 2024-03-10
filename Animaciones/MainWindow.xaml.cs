using MultiVentana;
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

namespace Animaciones
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
        private void btSalir_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btAcercade_Click(object sender, RoutedEventArgs e)
        {
            Window acercade = new vtAcercade();
            acercade.ShowDialog();
        }

        private void btTiposAnimaciones_Click(object sender, RoutedEventArgs e)
        {
            Window animavarios = new winAnimaVarios();
            animavarios.ShowDialog();
        }

        private void btControlTextBox_Click(object sender, RoutedEventArgs e)
        {
            Window animacioncontrol = new winAnimacionControl();
            animacioncontrol.ShowDialog();
        }

        private void btFigurasElipses_Click(object sender, RoutedEventArgs e)
        {
            Window elipses = new winAnimaFrameElipses();
            elipses.ShowDialog();
        }
    }
}

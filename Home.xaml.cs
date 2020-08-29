using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Quiz_DanielPatiño
{
    /// <summary>
    /// Lógica de interacción para Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
        }
        private void cbGaseosas_Checked(object sender, RoutedEventArgs e)
        {
            cmbProductos.Items.Add("Gaseosa de Manzana");
            cmbProductos.Items.Add("Gaseosa de Naranja");
            cmbProductos.Items.Add("Gaseosa de Uva");
            cmbProductos.Items.Add("Gaseosa de Piña");
        }

        private void cbJugos_Checked(object sender, RoutedEventArgs e)
        {
            cmbProductos.Items.Add("Jugo de Mango");
            cmbProductos.Items.Add("Jugo de Lulo");
            cmbProductos.Items.Add("Jugo de Mora");
            cmbProductos.Items.Add("Jugo Tropical");
        }

        private void cbGaseosas_Unchecked(object sender, RoutedEventArgs e)
        {
            cmbProductos.Items.Remove("Gaseosa de Manzana");
            cmbProductos.Items.Remove("Gaseosa de Naranja");
            cmbProductos.Items.Remove("Gaseosa de Uva");
            cmbProductos.Items.Remove("Gaseosa de Piña");
        }

        private void cbJugos_Unchecked(object sender, RoutedEventArgs e)
        {
            cmbProductos.Items.Remove("Jugo de Mango");
            cmbProductos.Items.Remove("Jugo de Lulo");
            cmbProductos.Items.Remove("Jugo de Mora");
            cmbProductos.Items.Remove("Jugo Tropical");
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            lbProductos.Items.Add(cmbProductos.SelectedItem);
        }

        private void btnRemover_Click(object sender, RoutedEventArgs e)
        {
            lbProductos.Items.Remove(lbProductos.SelectedItem);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lblPrecio.Visibility = Visibility.Visible;
            lblPrecio.Content = "$" + (lbProductos.Items.Count * 2000);
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow cerrar_sesion = (MainWindow)Window.GetWindow(this);
            cerrar_sesion.frame_Main.NavigationService.Navigate(new Login());
        }
    }
}

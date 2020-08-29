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
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (txtUsername.Text == "Daniel" && txtPassword.Password == "1234") 
            {
                MainWindow iniciar_sesion= (MainWindow)Window.GetWindow(this);
                iniciar_sesion.frame_Main.NavigationService.Navigate(new Home());
            }
            else
             {
                MessageBox.Show("Usuario no encontrado");
                txtUsername.Text = "";
                txtPassword.Password = "";
             }
        }
    }
}

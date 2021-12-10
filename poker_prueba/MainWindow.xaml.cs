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

namespace poker_prueba
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

        private void enviar1_Click(object sender, RoutedEventArgs e)
        {
            string usu = login.Text;
            string pass = password1.Text;

            //MessageBox.Show("Usuario:" + usu);


            //if (usu.Equals("poker2013") && pass.Equals("inacap123456"))
            if (usu.Equals("") && pass.Equals(""))
            {
                this.Hide();
                poker_prueba.Window1 segundoproyecto = new poker_prueba.Window1();
                segundoproyecto.Show();
                
            }
        }
    }
}

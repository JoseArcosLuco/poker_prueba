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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Collections;
namespace poker_prueba
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        ArrayList arrJugada = new ArrayList();
        Jugadas juegos = new Jugadas();
        public Window1()
        {
            InitializeComponent();
            juegos.apuesta = 0;
            juegos.creditos = 10;
            juegos.fechaHoraJuego = DateTime.Now.ToString();
            juegos.estadoJugada = 1;
            this.apuestaLabel.Content = juegos.apuesta;
            this.creditosLabel.Content = juegos.creditos;
        }
        public void creaBotonBase(int marginAsigna) {
                 
            Button boton = new Button();
            BitmapImage btm = new BitmapImage(new Uri(@"base.gif", UriKind.Relative));
            Image imagen = new Image();
            imagen.Source = btm;
            imagen.Stretch = Stretch.Fill;
            boton.Content = imagen;
            boton.Name = "imagen"+marginAsigna;
            boton.Height = 100;
            boton.Width = 100;
            grid1.Children.Add(boton);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            
            
            
            string cartaAnterior = "base.gif";

            if (juegos.estadoJugada.Equals(1) == true && juegos.apuesta > 0)
            {

                string carta_01 = cartaAleatoria(cartaAnterior);
                //BitmapImage imagen = new BitmapImage(new Uri(@"images/" + carta_01, UriKind.Relative));
                carta1.Source = new BitmapImage(new Uri(@"images/" + carta_01, UriKind.Relative));


                string carta_02 = cartaAleatoria(carta_01);
                BitmapImage imagen_2 = new BitmapImage(new Uri(@"images/" + carta_02, UriKind.Relative));
                carta2.Source = imagen_2;


                string carta_03 = cartaAleatoria(carta_02);
                BitmapImage imagen_3 = new BitmapImage(new Uri(@"images/" + carta_03, UriKind.Relative));
                carta3.Source = imagen_3;


                string carta_04 = cartaAleatoria(carta_03);
                BitmapImage imagen_4 = new BitmapImage(new Uri(@"images/" + carta_04, UriKind.Relative));
                carta4.Source = imagen_4;


                string carta_05 = cartaAleatoria(carta_04);
                BitmapImage imagen_5 = new BitmapImage(new Uri(@"images/" + carta_05, UriKind.Relative));
                carta5.Source = imagen_5;

                juegos.estadoJugada = 2;
            }
            else {
                MessageBox.Show("Debe apostar para continuar!", "Alerta");
            }


            if(juegos.estadoJugada.Equals(2) == true){
                //hasta aki no mas llegue profe sorri eso fue lo que intente hacer para la proxima prueba saludos
            }
            
        }
        
        //Function to get random number
        private static readonly Random getrandom = new Random();
        private static readonly object syncLock = new object();
        public static int GetRandomNumber(int min, int max)
        {
            lock(syncLock) { // synchronize
                return getrandom .Next(min, max);
            }
        }
        
        public string cartaAleatoria(string cartaAnterior) {


            //Function to get random number

            try
            {
                
                int iNumero = GetRandomNumber(1, 13);
                int iPinta = GetRandomNumber(1, 4);
                
                string iPintatexto;

                switch (iPinta)
                {
                    case 1:
                        iPintatexto = "c";
                        break;
                    case 2:
                        iPintatexto = "d";
                        break;
                    case 3:
                        iPintatexto = "p";
                        break;
                    case 4:
                        iPintatexto = "t";
                        break;
                    default:
                        iPintatexto = "base";
                        break;
                }
                if (cartaAnterior.Equals(iNumero + iPintatexto + ".gif") == true)
                {
                    return cartaAleatoria("");
                }
                else
                {
                    return iNumero + iPintatexto + ".gif";
                }
                         }
            catch (Exception ex)
            {
                
                return "base.gif";
            }
            finally {
                
            
            }

            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            juegos.apuestaMinima();
            this.apuestaLabel.Content = juegos.apuesta;
            this.creditosLabel.Content = juegos.creditos;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            juegos.apuestaMaxima();
            this.apuestaLabel.Content = juegos.apuesta;
            this.creditosLabel.Content = juegos.creditos;
        }

    }
}

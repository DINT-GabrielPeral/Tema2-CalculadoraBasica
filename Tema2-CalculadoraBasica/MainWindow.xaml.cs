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

namespace Tema2_CalculadoraBasica
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            calcularButton.IsEnabled = false;
        }

        private void calcularButton_Click(object sender, RoutedEventArgs e)
        {
            if (operadorTextBox.Text == "+")
            {
                double digito1 = int.Parse(digito1TextBox.Text);
                double digito2 = int.Parse(digito2TextBox.Text);
                double suma = digito1 + digito2;
                respuestaTextBlock.Text = suma.ToString();
            }

            if (operadorTextBox.Text == "-")
            {
                double digito1 = int.Parse(digito1TextBox.Text);
                double digito2 = int.Parse(digito2TextBox.Text);
                double resta = digito1 - digito2;
                respuestaTextBlock.Text = resta.ToString();
            }

            if (operadorTextBox.Text == "*")
            {
                double digito1 = int.Parse(digito1TextBox.Text);
                double digito2 = int.Parse(digito2TextBox.Text);
                double multiplicacion = digito1 * digito2;
                respuestaTextBlock.Text = multiplicacion.ToString();
            }

            if (operadorTextBox.Text == "/")
            {
                double digito1 = int.Parse(digito1TextBox.Text);
                double digito2 = int.Parse(digito2TextBox.Text);
                double division = digito1 / digito2;
                respuestaTextBlock.Text = division.ToString();
            }
        }

        private void operadorTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (operadorTextBox.Text == "+" || operadorTextBox.Text == "-" || operadorTextBox.Text == "*" || operadorTextBox.Text == "/")
            {
                calcularButton.IsEnabled = true;
            }
            else
                calcularButton.IsEnabled = false;
        }

        private void limpiarButton_Click(object sender, RoutedEventArgs e)
        {
            digito1TextBox.Text = "";
            digito2TextBox.Text = "";
            operadorTextBox.Text = "";
            respuestaTextBlock.Text = "";
        }
    }
}

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

namespace Projekt_Algorytmy
{
    /// <summary>
    /// Logika interakcji dla klasy Wielomian.xaml
    /// </summary>
    public partial class Wielomian : Window
    {
        public Wielomian()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Przykładowe wartości współczynników dla wielomianu stopnia piątego
            double a5 = double.Parse(textboxx5.Text);
            double a4 = double.Parse(textboxx4.Text);
            double a3 = double.Parse(textboxx3.Text);
            double a2 = double.Parse(textboxx2.Text);
            double a1 = double.Parse(textboxx.Text);
            double a0 = double.Parse(textboxwolny.Text);

            // Przykładowa wartość x
            double x = double.Parse(textboxxwynik.Text);

            // Wywołanie funkcji obliczającej wartość wielomianu
            double result = PolynomialFunction(a5, a4, a3, a2, a1, a0, x);

            // Wyświetlenie wyniku
            wynikblock.Text = $"Wartość wielomianu dla x = {x} wynosi: {result}";
        }

        static double PolynomialFunction(double a5, double a4, double a3, double a2, double a1, double a0, double x)
        {
            return a5 * Math.Pow(x, 5) + a4 * Math.Pow(x, 4) + a3 * Math.Pow(x, 3) + a2 * Math.Pow(x, 2) + a1 * x + a0;
        }
    }
}

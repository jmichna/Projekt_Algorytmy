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
    /// Logika interakcji dla klasy FSzescienna.xaml
    /// </summary>
    public partial class FSzescienna : Window
    {
        public FSzescienna()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(textboxa.Text);
            double b = double.Parse(textboxb.Text);
            double c = double.Parse(textboxc.Text);
            double d = double.Parse(textboxd.Text);

            double delta = 18 * a * b * c * d - 4 * Math.Pow(b, 3) * d + Math.Pow(b, 2) * Math.Pow(c, 2) - 4 * a * Math.Pow(c, 3) - 27 * Math.Pow(a, 2) * Math.Pow(d, 2);

            double[] wynik = SolveCubicEquation(a, b, c, d, delta);

            if (wynik.Length > 2)
            {
                wynikblock.Text = $"Wynik: x1 = {wynik[0]}, x2 = {wynik[1]}, x3 = {wynik[2]}";
            }
            else if (wynik.Length > 1)
            {
                wynikblock.Text = $"Wynik: x1 = {wynik[0]}, x2 = {wynik[1]}";
            }
            else if (wynik.Length > 0 )
            {
                wynikblock.Text = $"Wynik: x1 = {wynik[0]}";
            }

        }

        static double[] SolveCubicEquation(double a, double b, double c, double d, double delta)
        {
            double A = b / a;
            double B = c / a;
            double C = d / a;

            double Q = (3 * B - Math.Pow(A, 2)) / 9;
            double R = (9 * A * B - 27 * C - 2 * Math.Pow(A, 3)) / 54;
            double D = Math.Pow(Q, 3) + Math.Pow(R, 2);

            double[] roots;

            if (D > 0)
            {
                double S = CubeRoot(R + Math.Sqrt(D));
                double T = CubeRoot(R - Math.Sqrt(D));
                double x1 = -A / 3 + (S + T);
                roots = new double[] { x1 };
            }
            else if (D == 0)
            {
                double S = CubeRoot(R);
                double x1 = -A / 3 + 2 * S;
                double x2 = -A / 3 - S;
                roots = new double[] { x1, x2 };
            }
            else
            {
                double theta = Math.Acos(R / Math.Sqrt(-Math.Pow(Q, 3)));
                double x1 = 2 * Math.Sqrt(-Q) * Math.Cos(theta / 3) - A / 3;
                double x2 = 2 * Math.Sqrt(-Q) * Math.Cos((theta + 2 * Math.PI) / 3) - A / 3;
                double x3 = 2 * Math.Sqrt(-Q) * Math.Cos((theta + 4 * Math.PI) / 3) - A / 3;
                roots = new double[] { x1, x2, x3 };
            }

            return roots;
        }
        static double CubeRoot(double x)
        {
            return x >= 0 ? Math.Pow(x, 1.0 / 3.0) : -Math.Pow(-x, 1.0 / 3.0);
        }
    }
}

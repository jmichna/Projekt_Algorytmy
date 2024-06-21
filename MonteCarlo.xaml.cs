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
    /// Logika interakcji dla klasy MonteCarlo.xaml
    /// </summary>
    public partial class MonteCarlo : Window
    {
        public MonteCarlo()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Liczba punktów do wygenerowania
            int numberOfPoints = int.Parse(textboxpunkty.Text);

            // Obliczenie wartości Pi za pomocą algorytmu Monte Carlo
            double piEstimate = CalculatePiMonteCarlo(numberOfPoints);

            // Wyświetlenie wyniku
            wynikblock.Text = $"Szacowana wartość Pi: {piEstimate}";
        }

        static double CalculatePiMonteCarlo(int numberOfPoints)
        {
            Random random = new Random();
            int pointsInsideCircle = 0;

            for (int i = 0; i < numberOfPoints; i++)
            {
                // Generowanie losowych punktów (x, y) w przedziale [0, 1]
                double x = random.NextDouble();
                double y = random.NextDouble();

                // Sprawdzenie, czy punkt znajduje się wewnątrz ćwiartki koła
                if (x * x + y * y <= 0.25)
                {
                    pointsInsideCircle++;
                }
            }

            // Obliczenie wartości Pi
            return 4.0 * pointsInsideCircle / numberOfPoints;
        }
    }
}

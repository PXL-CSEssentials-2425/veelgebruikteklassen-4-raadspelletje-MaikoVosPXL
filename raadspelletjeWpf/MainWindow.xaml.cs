using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

namespace raadspelletjeWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void sluitenButton(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void startButton(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int raadGetal = rnd.Next(0, 101);
            bool hasWon = false;
            string input = "";
            int inputGetal = 0;
            int aantalBeurten = 0;

            input = Interaction.InputBox(
            "Raad het getal tussen 0 - 100",
            "Geef een getal in tussen 0 - 100!",
            "0");
            inputGetal = Convert.ToInt32(input);
            aantalBeurten++;
            Console.WriteLine(raadGetal);

            while (!hasWon)
            {

                if (inputGetal > raadGetal)
                {
                    for (int i = 0; inputGetal > raadGetal; i++)
                    {
                        MessageBox.Show($"Raad lager!");
                        input = Interaction.InputBox(
                        "Raad het getal tussen 0 - 100",
                        "Geef een getal in tussen 0 - 100!",
                        "0");
                        inputGetal = Convert.ToInt32(input);
                        Console.WriteLine(raadGetal);
                        aantalBeurten++;
                    }
                }
                if (inputGetal < raadGetal)
                {
                    for (int i = 0; inputGetal < raadGetal; i++)
                    {
                        MessageBox.Show($"Raad Hoger!");
                        input = Interaction.InputBox(
                        "Raad het getal tussen 0 - 100",
                        "Geef een getal in tussen 0 - 100!",
                        "0");
                        inputGetal = Convert.ToInt32(input);
                        Console.WriteLine(raadGetal);
                        aantalBeurten++;
                    }
                }
                else
                {

                    MessageBox.Show($"U heeft het getal geraden in {aantalBeurten} beurten!");
                    hasWon = true;
                }
            }
        }
    }
}

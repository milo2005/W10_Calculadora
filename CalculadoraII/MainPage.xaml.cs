using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CalculadoraII
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void operar(object sender, RoutedEventArgs e)
        {
            string n1 = num1.Text;
            string n2 = num2.Text;

            int nu1 = Convert.ToInt16(n1);
            int nu2 = Convert.ToInt16(n2);
            int nuRta = 0;

            Button btnSender = sender as Button;
            switch (btnSender.Name) {
                case "sumar":
                    nuRta = nu1 + nu2;
                    break;
                case "restar":
                    nuRta = nu1 - nu2;
                    break;
                case "mul":
                    nuRta = nu1 * nu2;
                    break;
                case "div":
                    nuRta = nu1 / nu2;
                    break;
            }

            result.Text = nuRta.ToString();
        }
    }
}

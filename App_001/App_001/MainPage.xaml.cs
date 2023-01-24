using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App_001
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAltura.Text))
            {
                if (!string.IsNullOrEmpty(txtPeso.Text))
                {
                    double altura = double.Parse(txtAltura.Text);
                    double peso = double.Parse(txtPeso.Text);

                    double imc = peso / (altura * altura);
                    string imcpeso="";

                    if (imc <= 18.5)
                    {
                        imcpeso = "Tiene bajo peso";
                    }
                    else if (imc <= 24.9 && imc > 18.5)
                    {
                        imcpeso = "Tiene un peso normal";
                    }
                    else if (imc <= 29.9 && imc > 24.9)
                    {
                        imcpeso = "Tiene Sobrepeso";
                    }
                    else if (imc > 29.9 && imc <= 34.9)
                    {
                        imcpeso = "Sufre de obesidad grado I";
                    }
                    else if (imc > 34.9 && imc <= 39.9)
                    {
                        imcpeso = "Sufre de obesidad grado II";
                    }
                    else if (imc > 39.9 && imc <= 49.9)
                    {
                        imcpeso = "Sufre de obesidad grado III";
                    }
                    else if (imc >= 50)
                    {
                        imcpeso = "Sufre de obesidad grado IV";
                    }

                    DisplayAlert("Infomacion IMC:", imcpeso, "OK");
                }
                else
                {
                    DisplayAlert("ERROR", "Ingrese el valor del peso", "OK");
                }
            }
            else
            {
                DisplayAlert("ERROR", "Ingrese el valor de la altura", "OK");
            }
            
        }
    }
}

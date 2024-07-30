using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4955511DistanciaEntrePuntos.Models
{
    partial class distanciaViewModel : ObservableObject
    {

        [ObservableProperty]
        public string x1;
        [ObservableProperty]
        public string x2;

        [ObservableProperty]
        public string y1;
        [ObservableProperty]
        public string y2;

        [ObservableProperty]
        public string distancia;

        [RelayCommand]
        private void CalculoDistancia()
        {
            if (double.TryParse(X1, out double x1) && double.TryParse(X2, out double x2) && double.TryParse(Y1, out double y1) && double.TryParse(Y2, out double y2))
            {
                Distancia = Math.Round(Math.Sqrt((Math.Pow(x1 - x2, 2)) + (Math.Pow(y1 - y2, 2))),2).ToString();
            }
            else
            {
                Distancia = "Ingrese números válidos";
            }
        }
    }
}

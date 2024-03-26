using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tabbed_Peod
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Detsember : ContentPage
    {
        Label nimetus, kirjeldus;
        public Detsember()
        {
            InitializeComponent();

            Grid grid = new Grid
            {
                RowDefinitions =
                {
                    new RowDefinition{Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition{Height = new GridLength(3, GridUnitType.Star) },
                    new RowDefinition{Height = new GridLength(2, GridUnitType.Star) },
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition{Width = new GridLength (1, GridUnitType.Star)}
                }
            };
            nimetus = new Label
            {
                Text = "Detsember",
                FontSize = 30,
            };
            kirjeldus = new Label
            {
                Text = "24. detsember – jõululaupäev \n25. detsember – esimene jõulupüha \n26. detsember – teine jõulupüha"
            };
            Image img = new Image
            {
                Source = "detsember"
            };
            grid.Children.Add(img, 0, 1);
            grid.Children.Add(nimetus, 0, 0);
            grid.Children.Add(kirjeldus, 0, 2);
            Content = grid;
        }
    }
}
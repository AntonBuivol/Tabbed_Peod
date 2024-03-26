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
    public partial class Aprill : ContentPage
    {
        Label nimetus, kirjeldus;
        public Aprill()
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
                Text = "Aprill",
                FontSize = 30,
            };
            kirjeldus = new Label
            {
                Text = "23. aprill – veteranipäev"
            };
            Image img = new Image
            {
                Source = "aprill"
            };
            grid.Children.Add(img, 0, 1);
            grid.Children.Add(nimetus, 0, 0);
            grid.Children.Add(kirjeldus, 0, 2);
            Content = grid;
        }
    }
}
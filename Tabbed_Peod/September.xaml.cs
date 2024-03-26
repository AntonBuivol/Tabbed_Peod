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
    public partial class September : ContentPage
    {
        Label nimetus, kirjeldus;
        public September()
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
                Text = "September",
                FontSize = 30,
            };
            kirjeldus = new Label
            {
                Text = "1. september – teadmistepäev \n8. september – vanavanemate päev \n22. september – vastupanuvõitluse päev"
            };
            Image img = new Image
            {
                Source = "september"
            };
            grid.Children.Add(img, 0, 1);
            grid.Children.Add(nimetus, 0, 0);
            grid.Children.Add(kirjeldus, 0, 2);
            Content = grid;
        }
    }
}
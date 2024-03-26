using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tabbed_Peod
{
    [DesignTimeVisible(false)]
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            Vali();
            InitializeComponent();
        }

        public async void Vali()
        {
            List<string> kuud = new List<string> { "Talv", "Kevad", "Suvi", "Sügis" };
            string pages = await DisplayActionSheet("Vali", "Sule", null, kuud.ToArray());
            switch (pages)
            {
                case "Talv":
                    ((MainPage)Application.Current.MainPage).CurrentPage = ((MainPage)Application.Current.MainPage).Children[0];
                    break;
                case "Kevad":
                    ((MainPage)Application.Current.MainPage).CurrentPage = ((MainPage)Application.Current.MainPage).Children[1];
                    break;
                case "Suvi":
                    ((MainPage)Application.Current.MainPage).CurrentPage = ((MainPage)Application.Current.MainPage).Children[2];
                    break;
                case "Sügis":
                    ((MainPage)Application.Current.MainPage).CurrentPage = ((MainPage)Application.Current.MainPage).Children[3];
                    break;
            }
        }
    }
}

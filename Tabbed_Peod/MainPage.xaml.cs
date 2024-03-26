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
            List<string> kuud = new List<string> { "Jaanuar", "Veebruar", "Märts", "Aprill", "Mai", "Juuni", "Juuli", "August", "September", "Oktoober", "November", "Detsember" };
            string pages = await DisplayActionSheet("Vali", "Sule", null, kuud.ToArray());
            if (pages == null )
            {
                await Navigation.PushAsync(new Jaanuar());
            }
            else
            {
                switch (pages)
                {
                    case "Jaanuar":
                        await Navigation.PushAsync(new Jaanuar());
                        break;
                    case "Veebruar":
                        await Navigation.PushAsync(new Veebruar());
                        break;
                    case "Marts":
                        await Navigation.PushAsync(new Marts());
                        break;
                    case "Aprill":
                        await Navigation.PushAsync(new Aprill());
                        break;
                    case "Mai":
                        await Navigation.PushAsync(new Mai());
                        break;
                    case "Juuni":
                        await Navigation.PushAsync(new Juuni());
                        break;
                    case "Juuli":
                        await Navigation.PushAsync(new Juuli());
                        break;
                    case "August":
                        await Navigation.PushAsync(new August());
                        break;
                    case "September":
                        await Navigation.PushAsync(new September());
                        break;
                    case "Oktoober":
                        await Navigation.PushAsync(new Oktoober());
                        break;
                    case "November":
                        await Navigation.PushAsync(new November());
                        break;
                    case "Detsember":
                        await Navigation.PushAsync(new Detsember());
                        break;
                }
            }
        }
    }
}

using DJChusinS2.Vistas;

namespace DJChusinS2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage (new Vistas.vGrid());
           
        }
    }
}

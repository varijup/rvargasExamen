namespace rvargasExamen
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Examen.Login1());
        }
    }
}

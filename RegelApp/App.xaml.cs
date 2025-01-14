namespace RegelApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState state)
        {
            var window = new Window(new MainPage());

#if WINDOWS
            window.X = 100;
            window.Y = 100;

            window.Width = 450;
            window.Height = 900;
#endif

            return window;
        }
    }
}
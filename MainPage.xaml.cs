namespace Module01Activity02
{
    public partial class MainPage : ContentPage
    {
        public string Firstname { get; set; }
        public Color ColorRed { get; set; }

        public MainPage()
        {
            InitializeComponent();

            Firstname = "Hello MAUI!";
            ColorRed = Colors.Red;
            this.BindingContext = this;
        }
        
        private void OnChangedLabelName(object sender, EventArgs e) 
        {
            this.Resources["StaticUsername"] = "Peter Butter";
        }

        private void OnChangedLabelNameDynamic(object sender, EventArgs e)
        {
            this.Resources["DynamicUsername"] = "Its Jover";
        }
        private void OnChangedBackgroundColorGreen(object sender, EventArgs e)
        {
            this.Resources["LocalBackgroundColor"] = Colors.Green;
        }
        private void OnChangedBackgroundColorGray(object sender, EventArgs e)
        {
            this.Resources["LocalBackgroundColor"] = Colors.Gray;
        }
        private void OnChangedBackgroundColorBlue(object sender, EventArgs e)
        {
            this.Resources["LocalBackgroundColor"] = Colors.Blue;
        }

        private void OnChangedBoxViewColor(object sender, EventArgs e)
        {
            this.Resources["DynamicBoxColor"] = Colors.LightGoldenrodYellow;
        }
    }


}

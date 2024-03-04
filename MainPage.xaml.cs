namespace miniZadanie_Maui3
{
    public partial class MainPage : ContentPage
    {
        int index = 0;
        string[] quotesArray = ["Be yourself; everyone else is already taken.",
            "So many books, so little time.",
            "Two things are infinite: the universe and human stupidity; and I'm not sure about the universe.",
            "A room without books is like a body without a soul.",
            "You only live once, but if you do it right, once is enough.",
            "Be the change that you wish to see in the world."];

        public MainPage()
        {
            InitializeComponent();
        }

        private void handleSlider(object sender, ValueChangedEventArgs e)
        {
            fontLabel.Text = String.Format("Font Size: {0:F0}", e.NewValue);
            quotes.FontSize = e.NewValue;
        }

        private void Next_button_Clicked(object sender, EventArgs e)
        {
            if (index == quotesArray.Length)
                index = 0;
            quotes.Text = quotesArray[index];
            index++;
        }
    }

}

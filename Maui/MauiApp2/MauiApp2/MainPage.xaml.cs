

namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        Random random = new Random();


        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            CounterBtn.BackgroundColor = Color.FromRgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
            CounterBtn.TextColor = Color.FromRgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
        }
    }

}

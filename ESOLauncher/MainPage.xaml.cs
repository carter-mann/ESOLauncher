using CommunityToolkit.Mvvm.Messaging;

namespace ESOLauncher
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            WeakReferenceMessenger.Default.Register<CountChangedMessage>(this, (r, m) => 
            {
                CounterBtn.Text = m.Text;
                SemanticScreenReader.Announce(m.Text);
            });
        }

        private async void OnPickerClicked(object sender, EventArgs e)
        {
            var result = await FilePicker.PickAsync(new PickOptions
            {
            });

            if (result == null)
            {
                return;
            }
        }
    }

}

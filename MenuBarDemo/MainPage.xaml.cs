using System;
using System.Windows.Input;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MenuBarDemo {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page {
        public ICommand SaveCommand { get; }
        public ICommand DemoCommand { get; }

        public MainPage() {
            this.InitializeComponent();
            this.SaveCommand = new RelayCommand(OnSave);
            this.DemoCommand = new RelayCommand<string>(OnDemo);
        }

        private async void OnDemo(string text) {
            await new MessageDialog($"Demo {text}").ShowAsync();
        }

        private async void OnSave() {
            await new MessageDialog("Save").ShowAsync();
        }

        private async void MenuFlyoutOpen_Click(object sender, RoutedEventArgs e) {
            await new MessageDialog("Open").ShowAsync();
        }

        private async void MenuFlyoutItemAbout_Click(object sender, RoutedEventArgs e) {
            await new MessageDialog("About").ShowAsync();
        }
    }


}

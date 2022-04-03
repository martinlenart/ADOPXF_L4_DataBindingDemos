using Xamarin.Forms;

namespace DataBindingDemos.Views
{
    public partial class BindingContextInheritancePage : ContentPage
    {
        public BindingContextInheritancePage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            entryInput.Focus();
        }
    }
}
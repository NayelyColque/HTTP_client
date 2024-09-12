using HTTPclind.ViewModels;

namespace HTTPclind.Views;

public partial class PostView : ContentPage
{
    public PostView()
    {
        InitializeComponent(); 
        BindingContext = new PostViewModel();   
    }
}

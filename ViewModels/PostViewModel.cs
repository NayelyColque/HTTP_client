using CommunityToolkit.Mvvm.ComponentModel;
using HTTPclind.Models;
using HTTPclind.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Threading.Tasks;

namespace HTTPclind.ViewModels
{
    internal partial class PostViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<Post> posts;

        public ICommand GetPostsCommand { get; }

        public PostViewModel()
        {
            Posts = new ObservableCollection<Post>(); 
            GetPostsCommand = new Command(async () => await GetPostsAsync());
        }

        public async Task GetPostsAsync()
        {
            PostService postService = new PostService();
            Posts = await postService.GetPostsAsync(); 
        }
    }
}

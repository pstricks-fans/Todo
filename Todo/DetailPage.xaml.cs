using Todo.ViewModel;

namespace Todo;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel  vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}
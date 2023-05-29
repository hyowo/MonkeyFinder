namespace MonkeyFinder;

//[QueryProperty("Monkey", "Monkey")]
public partial class DetailsPage : ContentPage
{

	//public Monkey Monkey { get; set; }
	public DetailsPage(MonkeyDetailsViewModel viewModel)
	{
		InitializeComponent();
		BindingContext
	}
}
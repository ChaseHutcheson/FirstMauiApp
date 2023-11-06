namespace FirstMauiApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
		{
			CounterBtn.Text = $"Clicked {count} time";
			label.Text = "Hey, you clicked it once";
		}
		else
		{
			CounterBtn.Text = $"Clicked {count} times";
			label.Text = "Hey, you clicked it more than once";
		}
        SemanticScreenReader.Announce(CounterBtn.Text);
	}
}


namespace NumberWithThousands;

public partial class MainPage
{
    public MainPage(MainViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = viewModel;
    }
}
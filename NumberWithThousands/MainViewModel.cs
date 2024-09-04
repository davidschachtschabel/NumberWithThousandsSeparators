using System.Globalization;
using CommunityToolkit.Mvvm.ComponentModel;

namespace NumberWithThousands;

public partial class MainViewModel : ObservableObject
{
    private string? _userInput;

    [ObservableProperty] private bool _isThousandsSeparatorEnabled;

    public string? UserInput
    {
        get
        {
            int.TryParse(_userInput, NumberStyles.AllowThousands | NumberStyles.Integer,
                Thread.CurrentThread.CurrentCulture, out var number);

            return number is 0 ? "" : number.ToString("N0");
        }
        set => SetProperty(ref _userInput, value);
    }
}
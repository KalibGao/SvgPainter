using CommunityToolkit.Mvvm.ComponentModel;
using System.Globalization;
using System.Threading;
using System.Windows;
using System.Windows.Media;

namespace SvgPainter
{
    [ObservableObject]
    public partial class MainViewModel
    {
        [ObservableProperty]
        private string? _svgText;

        partial void OnSvgTextChanged(string? value)
        {
            if (string.IsNullOrEmpty(value))
                return;

            try
            {
                SvgData = Geometry.Parse(value);
            }
            catch
            {

            }

        }

        [ObservableProperty]
        private Geometry? _svgData;
    }
}

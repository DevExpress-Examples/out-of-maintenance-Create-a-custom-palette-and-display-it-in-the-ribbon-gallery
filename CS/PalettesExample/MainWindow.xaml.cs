using DevExpress.Xpf.Core;
using System.Windows;
using System.Windows.Media;

namespace PalettesExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : DevExpress.Xpf.Core.ThemedWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var custompalette = new ThemePalette("CustomPalette");
            custompalette.SetColor("Foreground", (Color)ColorConverter.ConvertFromString("#FFFF7200"));
            custompalette.SetColor("Backstage.Focused", Colors.White);
            var customtheme = Theme.CreateTheme(custompalette, Theme.Office2016ColorfulSE);
            Theme.RegisterTheme(customtheme);
            ApplicationThemeHelper.ApplicationThemeName = customtheme.Name;
        }
    }
}

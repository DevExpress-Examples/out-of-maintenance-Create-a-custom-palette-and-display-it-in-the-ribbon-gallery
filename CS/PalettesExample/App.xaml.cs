using DevExpress.Xpf.Core;
using System.Windows;

namespace PalettesExample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application{
        protected override void OnStartup(StartupEventArgs e)
        {
            Theme.RegisterPredefinedPaletteThemes();
            ApplicationThemeHelper.ApplicationThemeName = PredefinedThemePalettes.RedWine.Name + Theme.Office2019White.Name;
            base.OnStartup(e);
        }
    }
}

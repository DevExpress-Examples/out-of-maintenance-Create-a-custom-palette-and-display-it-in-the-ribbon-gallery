Imports DevExpress.Xpf.Core
Imports System.Windows
Imports System.Windows.Media

Namespace PalettesExample
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits DevExpress.Xpf.Core.ThemedWindow

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			Dim custompalette = New ThemePalette("CustomPalette")
			custompalette.SetColor("Foreground", DirectCast(ColorConverter.ConvertFromString("#FFFF7200"), Color))
			custompalette.SetColor("Backstage.Focused", Colors.White)
			Dim customtheme = Theme.CreateTheme(custompalette, Theme.Office2016ColorfulSE)
			Theme.RegisterTheme(customtheme)
			ApplicationThemeHelper.ApplicationThemeName = customtheme.Name
		End Sub
	End Class
End Namespace

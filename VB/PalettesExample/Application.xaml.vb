Imports DevExpress.Xpf.Core
Imports System.Windows

Namespace PalettesExample
	''' <summary>
	''' Interaction logic for App.xaml
	''' </summary>
	Partial Public Class App
		Inherits Application

		Protected Overrides Sub OnStartup(ByVal e As StartupEventArgs)
			Theme.RegisterPredefinedPaletteThemes()
			ApplicationThemeHelper.ApplicationThemeName = PredefinedThemePalettes.RedWine.Name + Theme.Office2019White.Name
			MyBase.OnStartup(e)
		End Sub
	End Class
End Namespace

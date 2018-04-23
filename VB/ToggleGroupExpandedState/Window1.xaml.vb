Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Wpf.NavBar

Namespace ToggleGroupExpandedState
	''' <summary>
	''' Interaction logic for Window1.xaml
	''' </summary>
	Partial Public Class Window1
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub
		#Region "#CodeBehind"
		Private Sub button1_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			For i As Integer = 0 To navBarControl1.Groups.Count - 1
				Dim currentGroup As NavBarGroup = navBarControl1.Groups(i)
				currentGroup.IsExpanded = Not currentGroup.IsExpanded
			Next i

		End Sub
		#End Region ' #CodeBehind
	End Class
End Namespace

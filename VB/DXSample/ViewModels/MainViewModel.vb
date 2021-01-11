Imports System.Collections.ObjectModel
Imports DevExpress.Mvvm
Imports DevExpress.Xpf.Docking

Namespace DXSample.ViewModels
	Public Class MainViewModel
		Inherits ViewModelBase

		Public Property Panels() As ObservableCollection(Of PanelViewModel)
			Get
				Return GetValue(Of ObservableCollection(Of PanelViewModel))()
			End Get
			Set(ByVal value As ObservableCollection(Of PanelViewModel))
				SetValue(value)
			End Set
		End Property

		Public Sub New()
			Panels = New ObservableCollection(Of PanelViewModel)() From {
				New PanelViewModel() With {
					.Caption = "One",
					.Content = "A regular panel",
					.TargetName = "documentGroup"
				},
				New PanelViewModel() With {
					.Caption = "Two",
					.Content = "A regular panel",
					.TargetName = "documentGroup"
				},
				New PanelViewModel() With {
					.Caption = "Three",
					.Content = "A regular panel",
					.TargetName = "documentGroup"
				},
				New PanelViewModel() With {
					.Caption = "Five",
					.Content = "A panel",
					.TargetName = "layoutGroup"
				}
			}
		End Sub
	End Class

	Public Class PanelViewModel
		Inherits ViewModelBase
		Implements IMVVMDockingProperties

		Public Property Caption() As String
			Get
				Return GetValue(Of String)()
			End Get
			Set(ByVal value As String)
				SetValue(value)
			End Set
		End Property
		Public Property Content() As String
			Get
				Return GetValue(Of String)()
			End Get
			Set(ByVal value As String)
				SetValue(value)
			End Set
		End Property
		Public Property TargetName() As String
			Get
				Return GetValue(Of String)()
			End Get
			Set(ByVal value As String)
				SetValue(value)
			End Set
		End Property
	End Class
End Namespace
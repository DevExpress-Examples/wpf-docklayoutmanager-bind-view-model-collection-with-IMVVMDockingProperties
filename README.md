# DockLayoutManager - Bind the View Model Collection with IMVVMDockingProperties

You can use the **IMVVMDockingProperties** to populate and existing dock panels with a ViewModel collection. In this approach, the ViewModel should implement the  **IMVVMDockingProperties** interface. The **TargetName** property should return the name of the target layout group where DockLayoutManager places the created dock panel.

*Files to look at*:

* [MainWindow.xaml](https://github.com/DevExpress-Examples/docklayoutmanager-bind-view-model-collection-with-IMVVMDockingProperties/blob/20.2.3%2B/VB/DXSample/MainWindow.xaml) (**VB**: [MainWindow.xaml](https://github.com/DevExpress-Examples/docklayoutmanager-bind-view-model-collection-with-IMVVMDockingProperties/blob/20.2.3%2B/VB/DXSample/MainWindow.xaml))

* [MainViewModel.cs](https://github.com/DevExpress-Examples/docklayoutmanager-bind-view-model-collection-with-IMVVMDockingProperties/blob/20.2.3%2B/CS/DXSample/ViewModels/MainViewModel.cs) (**VB**: [MainViewModel.vb](https://github.com/DevExpress-Examples/docklayoutmanager-bind-view-model-collection-with-IMVVMDockingProperties/blob/20.2.3%2B/VB/DXSample/ViewModels/MainViewModel.vb))

Refer to the [MVVM Support - Bind to a Collection of Dock Panels](https://docs.devexpress.com/WPF/11386/#existing-dock-panels) documentation topic for more information on how to bind a ViewModel collection to the **DockLayoutManager**.

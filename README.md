<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/328658489/20.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T963702)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# DockLayoutManager - Bind the View Model Collection with IMVVMDockingProperties

You can use the **IMVVMDockingProperties** to populate and existing dock panels with a ViewModel collection. In this approach, the ViewModel should implement the  **IMVVMDockingProperties** interface. The **TargetName** property should return the name of the target layout group where DockLayoutManager places the created dock panel.

*Files to look at*:

* [MainWindow.xaml](./CS/DXSample/MainWindow.xaml) (**VB**: [MainWindow.xaml](./VB/DXSample/MainWindow.xaml))

* [MainViewModel.cs](./CS/DXSample/ViewModels/MainViewModel.cs) (**VB**: [MainViewModel.vb](./VB/DXSample/ViewModels/MainViewModel.vb))

Refer to the [MVVM Support - Bind to a Collection of Dock Panels](https://docs.devexpress.com/WPF/11386/#existing-dock-panels) documentation topic for more information on how to bind a ViewModel collection to the **DockLayoutManager**.

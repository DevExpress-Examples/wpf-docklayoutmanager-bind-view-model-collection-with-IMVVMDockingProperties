<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T963702)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WPF Dock Layout Manager - Bind the View Model Collection with IMVVMDockingProperties

You can use the **IMVVMDockingProperties** to populate and existing dock panels with a ViewModel collection. In this approach, the ViewModel should implement the  **IMVVMDockingProperties** interface. The **TargetName** property should return the name of the target layout group where DockLayoutManager places the created dock panel.

![image](https://user-images.githubusercontent.com/12169834/174008702-2b5ec402-0278-46a1-a25a-ad3f839d22d9.png)

<!-- default file list -->
## Files to Look At:

* [MainWindow.xaml](./CS/DXSample/MainWindow.xaml) (**VB**: [MainWindow.xaml](./VB/DXSample/MainWindow.xaml))
* [MainViewModel.cs](./CS/DXSample/ViewModels/MainViewModel.cs) (**VB**: [MainViewModel.vb](./VB/DXSample/ViewModels/MainViewModel.vb))
<!-- default file list end -->

## Documentation

- [MVVM Support - Bind to a Collection of Dock Panels](https://docs.devexpress.com/WPF/11386/#existing-dock-panels)

## More Examples

- [WPF Dock Layout Manager - Bind the View Model Collection with LayoutAdapters](https://github.com/DevExpress-Examples/wpf-docklayoutmanager-bind-view-model-collection-with-layoutadapters)
- [WPF Dock Layout Manager - Populate a LayoutGroup with the ViewModels collection](https://github.com/DevExpress-Examples/wpf-docklayoutmanager-display-viewmodels-collection-in-layoutgroup)
- [WPF Dock Layout Manager - Use Services That Implement the IDocumentManagerService Interface](https://github.com/DevExpress-Examples/wpf-docklayoutmanager-use-services-that-implement-the-idocumentmanagerservice)

<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/328658489/20.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T963702)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WPF Dock Layout Manager - Bind the View Model Collection with IMVVMDockingProperties

You can use **IMVVMDockingProperties** to populate existing dock panels with a ViewModel collection. In this technique, the ViewModel should implement the **IMVVMDockingProperties** interface. The **TargetName** property should return the name of the target layout group where DockLayoutManager places the created dock panel.

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
- [WPF Dock Layout Manager - Populate a LayoutGroup with the ViewModels Collection](https://github.com/DevExpress-Examples/wpf-docklayoutmanager-display-viewmodels-collection-in-layoutgroup)
- [WPF Dock Layout Manager - Use Services That Implement the IDocumentManagerService Interface](https://github.com/DevExpress-Examples/wpf-docklayoutmanager-use-services-that-implement-the-idocumentmanagerservice)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-docklayoutmanager-bind-view-model-collection-with-IMVVMDockingProperties&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-docklayoutmanager-bind-view-model-collection-with-IMVVMDockingProperties&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->

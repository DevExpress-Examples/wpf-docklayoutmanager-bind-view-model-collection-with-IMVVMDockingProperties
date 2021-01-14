# DockLayoutManager - Bind the View Model Collection with IMVVMDockingProperties

You can use the **IMVVMDockingProperties** to populate and existing dock panels with a ViewModel collection. In this approach, the ViewModel should implement the  **IMVVMDockingProperties** interface. The **TargetName** property should return the name of the target layout group where DockLayoutManager places the created dock panel.

Refer to the [documentation topic](https://docs.devexpress.com/WPF/11386/) for more information on how to bind the view model collection to the DockLayoutManager.

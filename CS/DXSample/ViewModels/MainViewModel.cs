using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Xpf.Docking;

namespace DXSample.ViewModels {
    public class MainViewModel : ViewModelBase {
        public ObservableCollection<PanelViewModel> Panels {
            get { return GetValue<ObservableCollection<PanelViewModel>>(); }
            set { SetValue(value); }
        }

        public MainViewModel() {
            Panels = new ObservableCollection<PanelViewModel>() {
                new PanelViewModel() { Caption = "One", Content = "A regular panel", TargetName = "documentGroup" },
                new PanelViewModel() { Caption = "Two", Content = "A regular panel", TargetName = "documentGroup" },
                new PanelViewModel() { Caption = "Three", Content = "A regular panel", TargetName = "documentGroup" },                
                new PanelViewModel() { Caption = "Five", Content = "A panel", TargetName = "layoutGroup" },
            };
        }
    }    

    public class PanelViewModel : ViewModelBase, IMVVMDockingProperties {
        public string Caption {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
        public string Content {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }        
        public string TargetName {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
    }
}
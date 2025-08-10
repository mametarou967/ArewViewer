using Prism.Commands;
using Prism.Events;
using Prism.Mvvm;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace AreaViewer.ViewModels
{

    public class MainWindowViewModel : BindableBase
    {
        private string _title = "AreaViewer";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel(IEventAggregator ea)
        {
        }
    }
}

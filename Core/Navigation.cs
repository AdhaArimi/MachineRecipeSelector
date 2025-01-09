using Recipe.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Recipe.Core
{
    public class Navigation : BindableBase
    {
        public event EventHandler NavigationChanged;

        private BindableView _currentView;
        public BindableView CurrentView 
        {
            get { return _currentView; }
            set { SetProperty(ref _currentView, value); }
        }

        private string _currentViewName;
        public string CurrentViewName
        {
            get { return _currentViewName; }
            set { SetProperty(ref _currentViewName, value); }
        }

        private List<ViewModelItem> _listViewModels;

        public Navigation()
        {
            _listViewModels = new List<ViewModelItem>();
        }

        #region Method

        public void NavigateTo(string ViewName)
        {
            CurrentViewName = ViewName;
            CurrentView = _listViewModels.SingleOrDefault(a => a.Name == ViewName).ViewModel;
            CurrentView.Refresh();
            OnNavigated();
        }

        public void AddViewModel(string ViewName, BindableView ViewModel)
        {
            _listViewModels.Add(new ViewModelItem() { Name = ViewName, ViewModel = ViewModel });
        }

        #endregion

        #region Events
        private void OnNavigated()
        {
            NavigationChanged?.Invoke(null, new EventArgs());
        }
        #endregion


    }

    public class ViewModelItem
    {
        public string Name { get; set; }
        public BindableView ViewModel { get; set; }
    }
}

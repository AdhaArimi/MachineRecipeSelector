using Recipe.Common;
using Recipe.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Recipe.ViewModel
{
    public class MainWindowViewModel : BindableView
    {

        public MainWindowViewModel()
        {
            AddViewModels();
            NavigateView("Main");
        }

        #region Method
        private void AddViewModels()
        {
            CommonVars.MainNavi.NavigationChanged += MainNavi_NavigationChanged;
        }

        private void MainNavi_NavigationChanged(object sender, EventArgs e)
        {
            CurrentView = CommonVars.MainNavi.CurrentView;
            CurrentView.Refresh();
        }

        private void NavigateView(string obj)
        {
            CommonVars.MainNavi.NavigateTo(obj);
        }
        #endregion


        #region Property
        private BindableView _currentView;
        public BindableView CurrentView
        {
            get => _currentView;
            set => SetProperty(ref _currentView, value);
        }
        #endregion
    }
}

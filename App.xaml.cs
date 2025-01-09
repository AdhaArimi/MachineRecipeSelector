using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Recipe.View;
using Recipe.ViewModel;

namespace Recipe
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            RegisterViewModel.Register();

            MainWindowViewModel mainWindowViewModel = new MainWindowViewModel();
            MainWindow window = new MainWindow() { DataContext = mainWindowViewModel };
            mainWindowViewModel.Refresh();
            window.Show();

            base.OnStartup(e);
        }

        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
        }
    }
}

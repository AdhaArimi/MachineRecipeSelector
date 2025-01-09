using Recipe.Common;
using Recipe.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Recipe.ViewModel
{
    public class MainViewModel : BindableView
    {
        public DelegateCommand CmdNext { get; }
        public MainViewModel()
        {
            CmdNext = new DelegateCommand(() => CommonVars.MainNavi.NavigateTo("Project"), () => true);
        }
    }
}

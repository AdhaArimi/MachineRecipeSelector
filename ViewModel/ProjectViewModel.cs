using Recipe.Common;
using Recipe.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Recipe.ViewModel
{
    public class ProjectViewModel : BindableView
    {
        public DelegateCommand CmdNext { get; }
        public DelegateCommand CmdBack { get; }
        public ProjectViewModel()
        {
            CmdNext = new DelegateCommand(() => CommonVars.MainNavi.NavigateTo("Stack"), () => true);
            CmdBack = new DelegateCommand(() => CommonVars.MainNavi.NavigateTo("Main"), () => true);
        }
    }
}

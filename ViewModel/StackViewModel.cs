using Recipe.Common;
using Recipe.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Recipe.ViewModel
{
    public class StackViewModel : BindableView
    {
        public DelegateCommand CmdNext { get; }
        public DelegateCommand CmdBack { get; }
        public StackViewModel()
        {
            CmdNext = new DelegateCommand(() => CommonVars.MainNavi.NavigateTo("Architecture"), () => true);
            CmdBack = new DelegateCommand(() => CommonVars.MainNavi.NavigateTo("Project"), () => true);
        }
    }
}

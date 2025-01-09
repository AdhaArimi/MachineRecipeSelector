using Recipe.Common;
using Recipe.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Recipe.ViewModel
{
    public class ArchitectureViewModel : BindableView
    {
        public DelegateCommand CmdNext { get; }
        public DelegateCommand CmdBack { get; }
        public ArchitectureViewModel()
        {
            CmdNext = new DelegateCommand(() => CommonVars.MainNavi.NavigateTo("Function"), () => true);
            CmdBack = new DelegateCommand(() => CommonVars.MainNavi.NavigateTo("Stack"), () => true);
        }
    }
}

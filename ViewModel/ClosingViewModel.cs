using Recipe.Common;
using Recipe.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Recipe.ViewModel
{
    public class ClosingViewModel : BindableView
    {
        public DelegateCommand CmdNext { get; }
        public DelegateCommand CmdBack { get; }
        public ClosingViewModel()
        {
            CmdBack = new DelegateCommand(() => CommonVars.MainNavi.NavigateTo("Outcome"), () => true);
        }
    }
}

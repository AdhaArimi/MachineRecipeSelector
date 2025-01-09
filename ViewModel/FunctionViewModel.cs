using Recipe.Common;
using Recipe.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Recipe.ViewModel
{
    public class FunctionViewModel : BindableView
    {
        public DelegateCommand CmdNext { get; }
        public DelegateCommand CmdBack { get; }
        public FunctionViewModel()
        {
            CmdNext = new DelegateCommand(() => CommonVars.MainNavi.NavigateTo("DB"), () => true);
            CmdBack = new DelegateCommand(() => CommonVars.MainNavi.NavigateTo("Architecture"), () => true);
        }
    }
}

using Recipe.Common;
using Recipe.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Recipe.ViewModel
{
    public class DBViewModel : BindableView
    {
        public DelegateCommand CmdNext { get; }
        public DelegateCommand CmdBack { get; }
        public DBViewModel()
        {
            CmdNext = new DelegateCommand(() => CommonVars.MainNavi.NavigateTo("Recipe"), () => true);
            CmdBack = new DelegateCommand(() => CommonVars.MainNavi.NavigateTo("Function"), () => true);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Recipe.ViewModel;
using Recipe.Common;

namespace Recipe
{
    public static class RegisterViewModel
    {
        public static void Register()
        {
            CommonVars.MainNavi.AddViewModel("Main", new MainViewModel());
            CommonVars.MainNavi.AddViewModel("Project", new ProjectViewModel());
            CommonVars.MainNavi.AddViewModel("Stack", new StackViewModel());
            CommonVars.MainNavi.AddViewModel("Architecture", new ArchitectureViewModel());
            CommonVars.MainNavi.AddViewModel("Function", new FunctionViewModel());
            CommonVars.MainNavi.AddViewModel("DB", new DBViewModel());
            CommonVars.MainNavi.AddViewModel("Recipe", new RecipeViewModel());
            CommonVars.MainNavi.AddViewModel("Outcome", new OutcomeViewModel());
            CommonVars.MainNavi.AddViewModel("Closing", new ClosingViewModel());
        }
    }
}

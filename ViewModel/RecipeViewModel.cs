using Recipe.Common;
using Recipe.Core;
using Recipe.Property;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows;

namespace Recipe.ViewModel
{
    public class RecipeViewModel : BindableView
    {
        public DelegateCommand CmdLoad { get; }
        public DelegateCommand CmdSave { get; }
        public DelegateCommand CmdAdd { get; }
        public DelegateCommand CmdRemove { get; }
        public DelegateCommand CmdNext { get; }
        public DelegateCommand CmdBack { get; }
        public RecipeViewModel()
        {
            CmdSave = new DelegateCommand(() => SaveRecipe(), () => true);
            CmdLoad = new DelegateCommand(() => LoadRecipe(), () => true);
            CmdAdd = new DelegateCommand(() => AddRecipe(), () => true);
            CmdRemove = new DelegateCommand(() => RemoveRecipe(), () => true);
            CmdNext = new DelegateCommand(() => CommonVars.MainNavi.NavigateTo("Outcome"), () => true);
            CmdBack = new DelegateCommand(() => CommonVars.MainNavi.NavigateTo("DB"), () => true);
        }

        public override void Refresh()
        {
            RecipeDB recipes = new RecipeDB();
            RecipeAvbList = recipes.GetAll();
        }

        private void RemoveRecipe()
        {
            RecipeDB recipes = new RecipeDB();
            recipes.Delete(SelectedRecipe);
            Refresh();
        }

        private void AddRecipe()
        {
            RecipeList = new RecipeProperty();
        }

        private void LoadRecipe()
        {
            try
            {
                RecipeDB recipes = new RecipeDB();
                EngineVar.RecipeList = (RecipeProperty)recipes.Load(_selectedRecipe, RecipeList.GetType());
            }
            catch (Exception ex)
            {

            }
        }

        private void SaveRecipe()
        {
            if (RecipeList.ModelName == null || RecipeList.ModelName == string.Empty) return;
            RecipeDB recipes = new RecipeDB();
            recipes.Save(RecipeList.ModelName, RecipeList);
            Refresh();
        }

        private List<string> _recipeAvbList;
        public List<string> RecipeAvbList
        {
            get => _recipeAvbList;
            set => SetProperty(ref _recipeAvbList, value);
        }

        private string _selectedRecipe;
        public string SelectedRecipe
        {
            get => _selectedRecipe;
            set
            {
                SetProperty(ref _selectedRecipe, value);
                RecipeDB recipes = new RecipeDB();
                RecipeList = new RecipeProperty();
                RecipeList = (RecipeProperty)recipes.Load(_selectedRecipe, RecipeList.GetType());
            }
        }

        private RecipeProperty _recipeList;
        public RecipeProperty RecipeList
        {
            get => _recipeList;
            set => SetProperty(ref _recipeList, value);
        }
    }
}

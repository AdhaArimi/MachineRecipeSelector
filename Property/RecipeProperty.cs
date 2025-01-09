using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Recipe.Property
{
    public class RecipeProperty
    {
        [Category("Model")] public string ModelName { get; set; }
        [Category("Model")] public bool IsValidated { get; set; }
        [Category("Parameter")] public double XOffset { get; set; }
        [Category("Parameter")] public double YOffset { get; set; }
        [Category("Parameter")] public double ZOffset { get; set; }
    }
}

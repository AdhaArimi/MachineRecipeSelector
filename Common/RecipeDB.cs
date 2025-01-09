using Newtonsoft.Json;
using Recipe.Common;
using Recipe.Common.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Xml;

namespace Recipe.Common
{
    public class RecipeDB
    {
        static DBEntities context;

        public RecipeDB()
        {
            context = new DBEntities();
        }

        public List<string> GetAll()
        {
            var result = context.Recipes.Select(x => x.Name).ToList();
            return result;
        }

        public object Load(string DataName, Type Data)
        {
            var result = context.Recipes.SingleOrDefault(x => x.Name == DataName);
            if (result != null)
            {
                return JsonConvert.DeserializeObject(result.Data, Data);
            }

            return null;
        }

        public void Save(string DataName, object Data)
        {
            string serializedData = JsonConvert.SerializeObject(Data, Newtonsoft.Json.Formatting.Indented);
            var result = context.Recipes.SingleOrDefault(x => x.Name == DataName);
            if (result != null)
            {
                result.Data = serializedData;
                result.LastUpdate = DateTime.Now;
            }
            else
            {
                context.Recipes.Add(new Recipe.Common.Database.Recipe() { Name = DataName, Data = serializedData, LastUpdate = DateTime.Now });
            }
            context.SaveChanges();
        }


        public bool Delete(string DataName)
        {
            var result = context.Recipes.SingleOrDefault(x => x.Name == DataName);
            if (result != null)
            {
                context.Recipes.Remove(result);
                context.SaveChanges();
                return true;
            }

            return false;
        }
    }
}

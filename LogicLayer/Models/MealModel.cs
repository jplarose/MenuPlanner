using System;
using System.Collections.Generic;
using System.Text;

namespace LogicLayer.Models
{
    public class MealModel
    {
        public string MealName { get; set; }
        public string MealImageFilePath { get; set; }
        public int Servings { get; set; }
        public int CaloriesPerServing { get; set; }
        public string IngredientList { get; set; }

        private Guid RefID = Guid.NewGuid();

        public Guid ReferenceID
        {
            get
            {
                return RefID;
            }
            set
            {
                RefID = value;
            }
        }
    }
}

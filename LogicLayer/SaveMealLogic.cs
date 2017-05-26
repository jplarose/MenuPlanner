using System;
using LogicLayer.Models;

namespace LogicLayer
{
    public class SaveMealLogic
    {

        // Debating between storing the whole meal as a JSON string to store in the DB vs.
        // storing the fields individually in a DB. Need to look for feedback as to pros 
        // and cons for each method
        public bool ConvertMealToJSON (MealModel mealModel)
        {

            // Send JSON String to DB for the whole meal
            return true;
        }

        // Alternatively

        public bool SaveMealToDB(MealModel mealModel)
        {

            // send fields individually to DB
            return true;
        }
        
    }
}

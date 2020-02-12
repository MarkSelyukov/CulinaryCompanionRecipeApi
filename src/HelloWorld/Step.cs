using System;
using System.Collections.Generic;

namespace HelloWorld
{
    public class Step
    {
        public int number { get; set; }
        public String step { get; set; }
        public List<Ingredient> ingredients { get; set; }
        public List<Equipment> equipment { get; set; }
        
        public Step(int number, string step, List<Ingredient> ingredients, List<Equipment> equipment)
        {
            this.number = number;
            this.step = step;
            this.ingredients = ingredients;
            this.equipment = equipment;
        }
    }
}
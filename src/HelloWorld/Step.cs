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
        public CookTime cookTime { get; set; }
    }
}
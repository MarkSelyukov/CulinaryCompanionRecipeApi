using System.Collections.Generic;

namespace HelloWorld
{
    public class ExtendedIngredient
    {
        public int id { get; set; }
        public string aisle { get; set; }
        public string image { get; set; }
        public string consitency { get; set; }
        public string name { get; set; }
        public string original { get; set; }
        public string originalString { get; set; }
        public string originalName { get; set; }
        public double amount { get; set; }
        public string unit { get; set; }
        public List<object> meta { get; set; }
        public List<object> metaInformation { get; set; }
        public Measures measures { get; set; }
    }
}
namespace HelloWorld
{
    //This file contains three classes just to simplify the class structure
    public class Measures
    {
        public Us us { get; set; }
        public Metric metric { get; set; }
    }

    public class Us
    {
        public double amount { get; set; }
        public string unitShort { get; set; }
        public string unitLong { get; set; }
    }

    public class Metric
    {
        public double amount { get; set; }
        public string unitShort { get; set; }
        public string unitLong { get; set; }
    }
}
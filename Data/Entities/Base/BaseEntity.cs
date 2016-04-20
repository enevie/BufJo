namespace Data.Entities.Base
{
    public abstract class BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Rating { get; set; }
        public int Grammage { get; set; }
        public double Calories { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }

    }
}

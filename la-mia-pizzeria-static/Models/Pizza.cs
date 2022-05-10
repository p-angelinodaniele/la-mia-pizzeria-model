



namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public double Prezzo { get; set; }

        public Pizza()
        {

        }

        public Pizza(string name, string description, string image, double prezzo)
        {
            Name = name;
            Description = description;
            Image = image;
            Prezzo = prezzo;
        }
    }
}

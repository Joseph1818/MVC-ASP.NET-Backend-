namespace MyApp.Models
{

    // The model class represent the data of the Application/ Repreresent a table in the database and each property represent a column.
    public class Item
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public double Price { get; set; }
    }
}

namespace Hackathon.API.Entities
{
    public class Categories
    {
        public int IdCategory { get; set; }
        public string categoryName { get; set; }

        public Categories(int IdCategory , string categoryName)
        {
            this.IdCategory = IdCategory;
            this.categoryName = categoryName;
        }
    }
}
namespace conexionBDDs
{
    public class categoria
    {
        public int CategoryID {get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public categoria()
        {
            this.CategoryID = 0;
            this.CategoryName = "";
            this.Description = "";
        }

        public categoria(int categoryId, string categoryName, string description)
        {
            CategoryID = categoryId;
            CategoryName = categoryName;
            Description = description;
        }
    }
}
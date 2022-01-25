namespace CSharpSecaoQuinze.AtividadeCompararHash.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string externalName, double externalPrice)
        {
            Name = externalName;
            Price = externalPrice;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode()
            + Price.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if(!(obj is Product))
            {
                return false;
            }

            Product other = obj as Product;
            return Name.Equals(other.Name) && Price.Equals(other.Price);
        }
    }
}
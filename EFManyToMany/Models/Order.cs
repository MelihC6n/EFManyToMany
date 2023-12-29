namespace EFManyToMany.Models
{
    public class Order : BaseClass
    {
        public int OrderNumber { get; set; }
        public int TotalPrice { get; set; }

        public virtual ICollection<Webuser> Webusers { get; set; }
    }
}

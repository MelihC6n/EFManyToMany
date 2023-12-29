﻿namespace EFManyToMany.Models
{
    public class Webuser : BaseClass
    {
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}

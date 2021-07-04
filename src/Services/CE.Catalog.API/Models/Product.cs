using System;
using CE.Core.DomainObjects;

namespace CE.Catalog.API.Models
{
    public class Product : EntityObject, IAggregateRoot
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public decimal Valor { get; set; }
        public DateTime RegisterDate { get; set; }
        public string Image { get; set; }
        public int QtdStock { get; set; }
    }
}

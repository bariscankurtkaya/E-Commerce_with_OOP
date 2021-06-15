using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Products:IEntity
    {
        public int ProductId { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public int ProductTypeId { get; set; }
        public decimal Price { get; set; }
        public int SexId { get; set; }
    }
}

using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class ProductType:IEntity
    {
        public int ProductTypeId { get; set; }
        public string Type { get; set; }

    }
}

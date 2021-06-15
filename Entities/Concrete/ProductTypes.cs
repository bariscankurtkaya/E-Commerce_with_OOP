using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class ProductTypes:IEntity
    {
        public int ProductTypeId { get; set; }
        public string ProductType { get; set; }

    }
}

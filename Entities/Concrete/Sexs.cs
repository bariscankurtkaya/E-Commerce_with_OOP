using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Sexs:IEntity
    {
        public int SexId { get; set; }
        public string Sex { get; set; }
    }
}

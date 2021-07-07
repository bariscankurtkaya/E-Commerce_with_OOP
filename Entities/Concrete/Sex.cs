using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Sex:IEntity
    {
        public int SexId { get; set; }
        public string SexType { get; set; }
    }
}

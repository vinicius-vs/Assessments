using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class Phase : Base
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Tests> Tests { get; set; }
    }
}

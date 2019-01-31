using System;
using System.Collections.Generic;
using System.Text;

namespace MyOpenHouse
{
    public class Wing
    {
       public string Name { get; set; }

        public List<Exhibit> Exhibits { get; set; } = new List<Exhibit>();

    }
}

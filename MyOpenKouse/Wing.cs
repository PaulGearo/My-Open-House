using System;
using System.Collections.Generic;
using System.Text;

namespace MyOpenHouse
{
    public class Wing
    {
        public string Name { get; set; }

        public Wing(string name, params Exhibit[] exhibits)
        {
            Name = name;
            foreach(Exhibit exhibit in exhibits)
            {
                Exhibits.Add(exhibit);
            }
        }

        public List<Exhibit> Exhibits { get; set; } = new List<Exhibit>();
    }
}

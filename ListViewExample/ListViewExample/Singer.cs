using System;
using System.Collections.Generic;
using System.Text;

namespace ListViewExample
{
    public class Singer
    {
        public string Name { get; set; }
        public string Song { get; set; }
        public Singer(string name, string song)
        {
            Name = name;
            Song = song;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3080ReleaseTool.Models
{
    public class RegionQuantities
    {
        public int UK { get; set; }
        public int US { get; set; }

        public RegionQuantities(int UK, int US)
        {
            this.UK = UK;
            this.US = US;
        }
    }
}
